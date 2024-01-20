using HomeAssets.Components.Repositories;
using HomeAssets.Data;
using HomeAssets.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAssets.Services;

// Services/LocationService.cs
// Services/LocationService.cs
public class LocationService: ILocationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Location> _locationRepository;

    public LocationService(IUnitOfWork unitOfWork, IRepository<Location> locationRepository)
    {
        _unitOfWork = unitOfWork;
        _locationRepository = locationRepository;
    }
    
    public async Task AddLocationAsync(Location location)
    {
        await  _locationRepository.AddAsync(location);
        await _unitOfWork.SaveChangesAsync();
    }
    
    public async Task<List<Location>> GetAllLocationsAsync()
    {
        return await _locationRepository.GetAllAsync();
    }
 
}