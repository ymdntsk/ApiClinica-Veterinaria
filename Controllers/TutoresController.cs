using ApiClinica_Veterinaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ApiClinica_Veterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TutoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> GetTutores()
        {
            return await _context.Tutores.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddTutor(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();
            return Ok("Tutor salvo com sucesso");
        }
    }
}
