// Entities/Location.cs

using HomeAssets.Entities;

public class Location
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public string Description { get; set; }="";

    // Foreign key for the parent location
    public Guid? ParentLocationId { get; set; }

    // Navigation property for the parent location
    public Location ParentLocation { get; set; } 

    // Collection navigation property for child locations
    public ICollection<Location> ChildLocations { get; set; } = new List<Location>();  
    // has many items
    public ICollection<Item> Items { get; set; } = new List<Item>();
    public Location()
    {
        // Initialize collections in the constructor
        ChildLocations = new List<Location>();
        Items = new List<Item>();
    }
    
}