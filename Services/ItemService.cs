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
    
    //get Items Count
    public async Task<int> GetItemsCountAsync()
    {
        return await _itemRepository.CountAsync();
    }
    public async Task AddItemAsync(Item item)
    {
        // Set the AssetId.
        item.AssetId = await GetNextAssetId();
        await  _itemRepository.AddAsync(item);
        await _unitOfWork.SaveChangesAsync();
    }
 
    // Get the next available AssetId
    private async Task<int> GetNextAssetId()
    {
        // Check if there are any existing items
        var existingItems = await _itemRepository.GetAllAsync();

        if (existingItems.Any())
        {
            // If there are items, calculate the existing maximum AssetId
            int maxAssetId = existingItems.Max(i => i.AssetId);

            // Increment and return the next AssetId
            return maxAssetId + 1;
        }
        else
        {
            // If no items exist, start with AssetId of 1
            return 1;
        }
    }
    

}