using AgendoCita.Domain.Repositories;
using AgendoCita.Infrastructure.Repositories;

namespace AgendoCita.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly AgendoCitaDbContext _context;

    public IClienteRepository Clientes { get; }

    public UnitOfWork(AgendoCitaDbContext context)
    {
        _context = context;
        Clientes = new ClienteRepository(_context);
    }
    public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

    public void Dispose() => _context.Dispose();
}
