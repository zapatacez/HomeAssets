namespace HomeAssets.Entities;

public class Label
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }= "";
    public string Description { get; set; }= "";
    //has one Item
    public Item Item { get; set; } = new Item();
}