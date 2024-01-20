using HomeAssets.Entities;

namespace HomeAssets.Services;

public interface IItemLabelService
{
    Task AddItemLabelAsync(ItemLabel itemLabel);
}