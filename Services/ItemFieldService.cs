using HomeAssets.Components.Repositories;
using HomeAssets.Entities;

namespace HomeAssets.Services;

public class ItemFieldService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<ItemField> _itemFieldRepository;

    public ItemFieldService(IUnitOfWork unitOfWork, IRepository<ItemField> itemFieldRepository)
    {
        _unitOfWork = unitOfWork;
        _itemFieldRepository = itemFieldRepository;
    }
    
    //Add item field
    public async Task AddItemFieldAsync(ItemField itemField)
    {
        await  _itemFieldRepository.AddAsync(itemField);
        await _unitOfWork.SaveChangesAsync();
    }
    //get all item fields by ItemId
    public async Task<IEnumerable<ItemField>> GetAllItemFieldsByItemIdAsync(Guid itemId)
    {
        return await _itemFieldRepository.GetAllAsync(i => i.ItemId == itemId);
    }
    
}