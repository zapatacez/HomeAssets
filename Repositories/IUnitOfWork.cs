using HomeAssets.Entities;

namespace HomeAssets.Components.Repositories;

public interface IUnitOfWork
{
    IRepository<Item> ItemRepository { get; }
    IRepository<Location> LocationRepository { get; }
    IRepository<Label> LabelRepository { get; }

    Task SaveChangesAsync();
}