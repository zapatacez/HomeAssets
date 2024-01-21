using System.Linq.Expressions;
using HomeAssets.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeAssets.Components.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _dbContext;

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _dbContext.Set<T>();

        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return await query.ToListAsync();
    }
    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }
    
    //get entity count 
    public async Task<int> CountAsync()
    {
        return await _dbContext.Set<T>().CountAsync();
    }
    public async Task<T> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _dbContext.Set<T>();

        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return await query.FirstOrDefaultAsync(entity => EF.Property<Guid>(entity, "Id") == id);
    }
    
    public async Task<Location> GetLocationWithRelatedAsync(Guid id)
    {
        return await _dbContext.Locations
            .Include(l => l.ParentLocation)
            .Include(l => l.ChildLocations)
            .Include(l => l.Items)
            .ThenInclude(i => i.ItemLabels)
            .ThenInclude(il => il.Label)
            .FirstOrDefaultAsync(l => l.Id == id);
    }


   

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbContext.Set<T>().Remove(entity);
        }
    }
}
