using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgendoCita.Domain.Entities;
using AgendoCita.Domain.Repositories;  
using Microsoft.EntityFrameworkCore;


namespace AgendoCita.Infrastructure.Repositories;

public class ClienteRepository : Repository<Cliente>, IClienteRepository
{
    public ClienteRepository(AgendoCitaDbContext context) : base(context) { }

    public async Task<Cliente?> GetByEmailAsync(string email) 
        => await _context.Clientes.FirstOrDefaultAsync(c => c.Mail == email);

    public async Task<IEnumerable<Cliente>> GetByProfesionalIdAsync(int profesionalId) 
        => await _context.Clientes.Where(c => c.Turnos.Any(t => t.ProfesionalId == profesionalId)).ToListAsync();
}
