using HomeAssets.Data;
using HomeAssets.Entities;

namespace HomeAssets.Components.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        ItemRepository = new Repository<Item>(_dbContext);
        LocationRepository = new Repository<Location>(_dbContext);
        LabelRepository = new Repository<Label>(_dbContext);
    }

    public IRepository<Item> ItemRepository { get; }
    public IRepository<Location> LocationRepository { get; }
    public IRepository<Label> LabelRepository { get; }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}