using HomeAssets.Entities;
using Microsoft.AspNetCore.Http.Features;

namespace HomeAssets.DTOs;

public class HomeDTO
{
    public int TotalLocations { get; set; }
    public int TotalItems { get; set; }
    public int TotalLabels { get; set; }
    public List<Item> Items { get; set; } = new();
}