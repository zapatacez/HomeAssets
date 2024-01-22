using System.ComponentModel.DataAnnotations;

namespace HomeAssets.DTOs;

public class ItemDTO
{
    public Guid Id { get; set; } 
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; } = "";
    [Required] 
    [Display(Name = "Description")]
    public string Description { get; set; } = "";
    public int Quantity { get; set; } = 1;
    public int AssetId { get; set; }
    public decimal Price { get; set; }= 0;
    public bool Insured { get; set; }
    [Display(Name = "Purchase Price")]
    public decimal PurchasePrice { get; set; }= 0;
    [Display(Name = "Purchase Date")]
    public DateTime PurchaseDate { get; set; }
    //write 3 fields for warranty
    [Display(Name = "Lifetime Warranty")]
    public bool LifetimeWarranty { get; set; }
    [Display(Name = "Warranty Details")]
    public string WarrantyDetails { get; set; }= "";
    [Display(Name = "Warranty Expiration Date")]
    public DateTime? WarrantyExpirationDate { get; set; }
    [Display(Name = "Expiration Date")]
    public DateTime? ExpirationDate { get; set; }
    [Display(Name = "Serial Number")]
    public string SerialNumber { get; set; } = "";
    [Display(Name = "Model Number")]
    public string ModelNumber { get; set; } = "";
    [Display(Name = "Manufacturer")]
    public string Manufacturer { get; set; }= "";
    public string Notes { get; set; }= "";
}