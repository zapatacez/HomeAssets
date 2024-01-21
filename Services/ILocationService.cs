namespace HomeAssets.Services;

public interface ILocationService
{
    //implement CRUD operations
    Task AddLocationAsync(Location location);
    Task<List<Location>> GetAllLocationsAsync();
    Task<List<Location>> GetLocationsWithItemsAsync();
    Task<Location> GetLocationByIdAsync(Guid id);
}