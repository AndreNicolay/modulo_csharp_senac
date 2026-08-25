using Microsoft.AspNetCore.Mvc;
using teste_api.Data;
using teste_api.Models;

namespace teste_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrutaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FrutaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFrutas()
        {
            var resultado = _context.Frutas.Select(f => new { f.id, f.nome, f.cor, f.preco }).ToList();

            return Ok(resultado);
        }

        [HttpPost("adicionar")]
        public IActionResult AdicionarFruta([FromBody] Fruta novaFruta)
        {
            _context.Frutas.Add(novaFruta);

            _context.SaveChanges();

            return Ok(new { mensagem = "Fruta cadastrada com sucesso!" });
        }
    }
}