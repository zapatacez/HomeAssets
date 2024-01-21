namespace HomeAssets.Services;

public interface ILocationService
{
    //implement CRUD operations
    Task AddLocationAsync(Location location);
    Task<List<Location>> GetAllLocationsAsync();
    Task<List<Location>> GetLocationsWithItemsAsync();
    Task<Location> GetLocationByIdAsync(Guid id);
    Task<Location> GetLocationByIdWithItemsAsync(Guid id);
    Task<int> GetLocationsCountAsync();
    Task UpdateLocationAsync(Location location);
}