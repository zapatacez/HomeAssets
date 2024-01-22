using System.ComponentModel.DataAnnotations;

namespace HomeAssets.Entities;

public class Item
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public string Name { get; set; } = "";
    [Required] public string Description { get; set; } = "";
    public int Quantity { get; set; } = 1;
    public int AssetId { get; set; }
    public decimal Price { get; set; }= 0;
    //added datetime 
    public DateTime? CreatedDate { get; set; } = DateTime.Now;
    public bool Insured { get; set; }
    public decimal PurchasePrice { get; set; }= 0;
    public DateTime PurchaseDate { get; set; }
    //write 3 fields for warranty
    public bool LifetimeWarranty { get; set; }
    public string WarrantyDetails { get; set; }= "";
    public DateTime? WarrantyExpirationDate { get; set; }
    
    public DateTime? ExpirationDate { get; set; }
    public string SerialNumber { get; set; } = "";
    public string ModelNumber { get; set; } = "";
    public string Manufacturer { get; set; }= "";
    public string Notes { get; set; }= "";
    public  string Vendor { get; set; }= "";
    //has many labels
    public ICollection<ItemLabel> ItemLabels { get; set; } = new List<ItemLabel>();
    //has one location
    public Guid LocationId { get; set; }
    public Location Location { get; set; } = new Location();

}