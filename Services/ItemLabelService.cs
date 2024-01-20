using HomeAssets.Components.Repositories;
using HomeAssets.Entities;

namespace HomeAssets.Services;

public class ItemLabelService: IItemLabelService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<ItemLabel> _itemLabelRepository;

    public ItemLabelService(IUnitOfWork unitOfWork, IRepository<ItemLabel> itemLabelRepository)
    {
        _unitOfWork = unitOfWork;
        _itemLabelRepository = itemLabelRepository;
    }
    public async Task AddItemLabelAsync(ItemLabel itemLabel)
    {
        await  _itemLabelRepository.AddAsync(itemLabel);
        await _unitOfWork.SaveChangesAsync();
    }
    
    
}