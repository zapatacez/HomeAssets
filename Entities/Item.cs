using System.ComponentModel.DataAnnotations;

namespace HomeAssets.Entities;

public class Item
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public string Name { get; set; } = "";
    [Required] public string Description { get; set; } = "";
    public int Quantity { get; set; }
    public int AssetId { get; set; }
    public decimal Price { get; set; }
    public bool Insured { get; set; }
    public DateTime PurchaseDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string SerialNumber { get; set; } = "";
    public string ModelNumber { get; set; } = "";
    public string Manufacturer { get; set; }= "";
    public string Notes { get; set; }= "";
    //has many labels
    public ICollection<Label> Labels { get; set; } = new List<Label>();
    //has one location
    public Guid LocationId { get; set; }
    public Location Location { get; set; } = new Location();

}