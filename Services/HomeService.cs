using HomeAssets.Components.Repositories;
using HomeAssets.DTOs;
using HomeAssets.Entities;

namespace HomeAssets.Services;

public class HomeService:IHomeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Location> _locationRepository;
    private readonly IRepository<Item> _itemRepository;
    private readonly IRepository<Label> _itemLabelRepository;

    //initialize the repositories
    public HomeService(IUnitOfWork unitOfWork, IRepository<Location> locationRepository,
        IRepository<Item> itemRepository, IRepository<Label> itemLabelRepository)
    {
        _unitOfWork = unitOfWork;
        _locationRepository = locationRepository;
        _itemRepository = itemRepository;
        _itemLabelRepository = itemLabelRepository;
    }
    
    //Fill HomeDTO with data
    public async Task<HomeDTO> GetHomeDataAsync()
    {
        var homeDto = new HomeDTO();
        
        homeDto.TotalLocations = await _locationRepository.CountAsync();
        homeDto.TotalItems = await _itemRepository.CountAsync();
        homeDto.TotalLabels = await _itemLabelRepository.CountAsync();
        homeDto.Items = await _itemRepository.GetAllAsync();
        return homeDto;
    }
    
    
}