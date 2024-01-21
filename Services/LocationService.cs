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
    
    //get locations count 
    public async Task<int> GetLocationsCountAsync()
    {
        return await _locationRepository.CountAsync();
    }
    public async Task AddLocationAsync(Location location)
    {
        await  _locationRepository.AddAsync(location);
        await _unitOfWork.SaveChangesAsync();
    }
    //update location
    public async Task UpdateLocationAsync(Location location)
    {
        await _locationRepository.UpdateAsync(location);
        await _unitOfWork.SaveChangesAsync();
    }
    public async Task<List<Location>> GetAllLocationsAsync()
    {
        return await _locationRepository.GetAllAsync();
    }
    
    //Get location by Id
    public async Task<Location> GetLocationByIdAsync(Guid id)
    {
        return await _locationRepository.GetByIdAsync(id);
    }
    
    
    public async Task<List<Location>> GetLocationsWithItemsAsync()
    {
        return await _locationRepository.GetAllAsync(l => l.Items);
    }
    public async Task<Location> GetLocationByIdWithItemsAsync(Guid id)
    {
        return await _locationRepository.GetLocationWithRelatedAsync(id);
    }
 
}