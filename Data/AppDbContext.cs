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
    // public DbSet<Asset> Assets { get; set; } = null!;
    // public DbSet<AssetType> AssetTypes { get; set; } = null!;
    // public DbSet<AssetLocation> AssetLocations { get; set; } = null!;
    // public DbSet<AssetOwner> AssetOwners { get; set; } = null!;
    // public DbSet<AssetStatus> AssetStatuses { get; set; } = null!;
    // public DbSet<AssetUsage> AssetUsages { get; set; } = null!;
    // public DbSet<AssetUser> AssetUsers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Location>()
            .HasOne(l => l.ParentLocation)
            .WithMany(l => l.ChildLocations)
            .HasForeignKey(l => l.ParentLocationId);

        //
        // modelBuilder.Entity<Asset>()
        //     .HasOne(a => a.AssetType)
        //     .WithMany(a => a.Assets)
        //     .HasForeignKey(a => a.AssetTypeId);
        //
        // modelBuilder.Entity<Asset>()
        //     .HasOne(a => a.AssetStatus)
        //     .WithMany(a => a.Assets)
        //     .HasForeignKey(a => a.AssetStatusId);
        //
        // modelBuilder.Entity<Asset>()
        //     .HasOne(a => a.AssetOwner)
        //     .WithMany(a => a.Assets)
        //     .HasForeignKey(a => a.AssetOwnerId);
        //
        // modelBuilder.Entity<Asset>()
        //     .HasOne(a => a.AssetUsage)
        //     .WithMany(a => a.Assets)
        //     .HasForeignKey(a => a.AssetUsageId);
        //
        // modelBuilder.Entity<Asset>()
        //     .HasOne(a => a.AssetUser)
        //     .WithMany(a => a.Assets)
        //     .HasForeignKey(a => a.AssetUserId);
        //
        // modelBuilder.Entity<Asset>()
        //     .HasMany(a => a.AssetLocations)
        //     .WithOne(a => a.Asset)
        //     .HasForeignKey(a => a.AssetId);
        //
        // modelBuilder.Entity<AssetLocation>()
        //     .HasOne(a => a.Location)
        //     .WithMany(a => a.AssetLocations)
        //     .HasForeignKey(a => a.LocationId);
        //
        // modelBuilder.Entity<AssetLocation>()
        //     .HasOne(a => a.Asset)
        //     .WithMany(a => a.AssetLocations)
        //     .HasForeignKey(a => a.AssetId);
        //
        // modelBuilder.Entity<AssetLocation>();

    }
}