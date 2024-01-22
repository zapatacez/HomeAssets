using HomeAssets.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAssets.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Location> Locations { get; set; } = null!;
    public DbSet<Item> Items { get; set; } = null!;
    public DbSet<Label> Labels { get; set; } = null!;
    public DbSet<ItemLabel> ItemLabels { get; set; } = null!;
    public DbSet<ItemField> ItemFields { get; set; } = null!;
 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Location>()
            .HasOne(l => l.ParentLocation)
            .WithMany(l => l.ChildLocations)
            .HasForeignKey(l => l.ParentLocationId);
    }
}