using AgendoCita.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendoCita.Infrastructure;

public class AgendoCitaDbContext : DbContext
{
    public AgendoCitaDbContext(DbContextOptions<AgendoCitaDbContext> options) : base(options)
    {
    }
    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<Profesional> Profesionales { get; set; } = null!;
    public DbSet<Turno> Turnos { get; set; } = null!;
    public DbSet<AgendaProfesional> AgendaProfesionales { get; set; } = null!;

}
