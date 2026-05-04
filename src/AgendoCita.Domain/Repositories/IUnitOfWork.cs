using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendoCita.Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    IClienteRepository Clientes { get; }
    //Task<int> SaveChangesAsync();   
    Task<int> CompleteAsync();
}
