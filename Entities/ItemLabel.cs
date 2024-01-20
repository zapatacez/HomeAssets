namespace HomeAssets.Entities;

public class ItemLabel
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid ItemId { get; set; }
    public Item Item { get; set; }

    public Guid LabelId { get; set; }
    public Label Label { get; set; }
}