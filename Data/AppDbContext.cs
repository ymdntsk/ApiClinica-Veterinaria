using ApiClinica_Veterinaria.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Tutor> Tutores { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Consulta> Consultas { get; set; }
}