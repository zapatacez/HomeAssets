using HomeAssets.Entities;

namespace HomeAssets.Services;

public interface IItemService
{
    //implement CRUD operations
    Task AddItemAsync(Item item);
    Task<int> GetItemsCountAsync();
    Task<Item> GetItemAsync(Guid id);
    
}