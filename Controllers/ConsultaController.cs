using ApiClinica_Veterinaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ApiClinica_Veterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConsultasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Consulta>>> GetConsultas()
        {
            return await _context.Consultas.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarConsulta(Consulta consulta)
        {
            
            if (consulta.DataHora < DateTime.Now)
            {
                return BadRequest("Nao e possivel agendar uma consulta em uma data/hora que ja passou.");
            }

            _context.Consultas.Add(consulta);
            await _context.SaveChangesAsync();
            return Ok("Consulta salva com sucesso");
        }
    }
}
