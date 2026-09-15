using ApiClinica_Veterinaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ApiClinica_Veterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PetsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            return await _context.Pets.ToListAsync();
        }


        [HttpPost]
        public async Task<IActionResult> AddPet(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return Ok("Pet Cadrastado com sucesso");
        }
    }
}
