using ApiClinica_Veterinaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ApiClinica_Veterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeterinariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();
            return Ok("Veterinario salvo com sucesso");
        }
    }
}
