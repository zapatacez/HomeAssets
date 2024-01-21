using HomeAssets.Entities;

namespace HomeAssets.Services;

public interface ILabelService
{
    //implement CRUD operations
    Task AddLabelAsync(Label label);
    Task<IEnumerable<Label>> GetAllLabelsAsync();

}