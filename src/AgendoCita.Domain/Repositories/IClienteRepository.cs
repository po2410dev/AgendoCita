using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgendoCita.Domain.Entities;
namespace AgendoCita.Domain.Repositories;

public interface IClienteRepository : IRepository<Cliente>
{
    Task<Cliente?> GetByEmailAsync(string email);
    Task<IEnumerable<Cliente>> GetByProfesionalIdAsync(int profesionalId);
}
