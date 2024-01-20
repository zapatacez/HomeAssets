using HomeAssets.Components.Repositories;
using HomeAssets.Data;
using HomeAssets.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAssets.Services;

// Services/LocationService.cs
// Services/LocationService.cs
public class ItemService: IItemService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Item> _itemRepository;

    public ItemService(IUnitOfWork unitOfWork, IRepository<Item> itemRepository)
    {
        _unitOfWork = unitOfWork;
        _itemRepository = itemRepository;
    }
    
    public async Task AddItemAsync(Item item)
    {
        // Set the AssetId.
        item.AssetId = await GetNextAssetId();
        await  _itemRepository.AddAsync(item);
        await _unitOfWork.SaveChangesAsync();
    }
 
    private async Task<int> GetNextAssetId()
    {
        // Check the existing maximum AssetId
        var items =  await _itemRepository.GetAllAsync();
        int maxAssetId = items.Max(i => i.AssetId);

        // Increment and return the next AssetId
        return maxAssetId + 1;
    }

}