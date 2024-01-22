namespace HomeAssets.Entities;

public class ItemField
{
    public Guid Id { get; set; } = new Guid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public Guid ItemId { get; set; }
    public Item Item { get; set; }
}