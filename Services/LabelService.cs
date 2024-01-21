using HomeAssets.Components.Repositories;
using HomeAssets.Data;
using HomeAssets.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAssets.Services;

// Services/LabelService.cs
// Services/LabelService.cs
public class LabelService: ILabelService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Label> _labelRepository;

    public LabelService(IUnitOfWork unitOfWork, IRepository<Label> labelRepository)
    {
        _unitOfWork = unitOfWork;
        _labelRepository = labelRepository;
    }
    
    public async Task AddLabelAsync(Label label)
    {
        await  _labelRepository.AddAsync(label);
        await _unitOfWork.SaveChangesAsync();
    }
    
    //get all labels
    public async Task<IEnumerable<Label>> GetAllLabelsAsync()
    {
        return await _labelRepository.GetAllAsync();
    }
 
}