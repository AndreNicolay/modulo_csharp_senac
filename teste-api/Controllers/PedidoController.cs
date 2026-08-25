using Microsoft.AspNetCore.Mvc;
using teste_api.Data;
using teste_api.Models;
using System;
using System.Linq;

namespace teste_api.Controllers
{
    // 1. DTO (Data Transfer Object) - Molde para receber apenas o necessário no Swagger
    public class NovoPedidoRequest
    {
        public int cliente_id { get; set; }
        public int fruta_id { get; set; }
        public int quantidade { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPedidos()
        {
            var pedidos = _context.Pedidos.ToList();
            return Ok(pedidos);
        }

        [HttpPost("fazer-pedido")]
        public IActionResult FazerPedido([FromBody] NovoPedidoRequest requisicao)
        {
            // 2. Busca a Fruta e o Cliente no banco de dados para ver se existem
            var fruta = _context.Frutas.Find(requisicao.fruta_id);
            var cliente = _context.Clientes.Find(requisicao.cliente_id);

            // Validações de segurança
            if (fruta == null) return NotFound("Fruta não encontrada no sistema!");
            if (cliente == null) return NotFound("Cliente não encontrado no sistema!");

            // 3. O Backend faz o cálculo matemático forçando a conversão para decimal (evita erros de tipagem)
            var valorTotalCalculado = Convert.ToDecimal(fruta.preco) * requisicao.quantidade;

            // 4. Monta o pedido completo mapeando para a entidade do banco
            var novoPedido = new Pedido
            {
                cliente_id = requisicao.cliente_id,
                fruta_id = requisicao.fruta_id,
                quantidade_comprada = requisicao.quantidade,
                valor_total = valorTotalCalculado,
                data_compra = DateTime.Now
            };

            // 5. Adiciona o pedido no banco
            _context.Pedidos.Add(novoPedido);

            // 6. Regra de Negócio: Baixa no estoque da fruta
            fruta.quantidade -= requisicao.quantidade;

            // Salva tudo de uma vez (tanto a criação do pedido quanto a atualização do estoque)
            _context.SaveChanges();

            // 7. Retorna um "Recibo" virtual formatado no Swagger
            return Ok(new
            {
                mensagem = "Pedido realizado com sucesso!",
                comprador = cliente.nome,
                produto = fruta.nome,
                quantidade_levada = requisicao.quantidade,
                valor_da_conta = $"R$ {valorTotalCalculado:F2}"
            });
        }
    }
}