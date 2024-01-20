namespace HomeAssets.Services;

public interface ILocationService
{
    //implement CRUD operations
    Task AddLocationAsync(Location location);
    Task<List<Location>> GetAllLocationsAsync();
}