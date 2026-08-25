using Microsoft.AspNetCore.Mvc;
using teste_api.Data;
using teste_api.Models;

namespace teste_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = _context.Clientes.ToList();
            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] Cliente novoCliente)
        {
            _context.Clientes.Add(novoCliente);
            _context.SaveChanges();

            return Ok(new { mensagem = "Cliente cadastrado com sucesso!" });
        }
    }
}