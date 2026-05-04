using AgendoCita.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AgendoCita.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AgendoCitaDbContext _context;

    public Repository(AgendoCitaDbContext context) => _context = context;

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }
    public void Update(T entity) => _context.Set<T>().Update(entity);

    public void Remove(T entity) => _context.Set<T>().Remove(entity);
}
