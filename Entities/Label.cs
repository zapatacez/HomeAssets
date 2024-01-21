namespace HomeAssets.Entities;

public class Label
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }= "";
    public string Description { get; set; }= "";
    //has one Item
    public List<ItemLabel> ItemLabels { get; set; } = new List<ItemLabel>();
}