namespace HomeAssets.Components.Repositories;

public interface IRepository<T>
{
    Task AddAsync(T entity);
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
}
