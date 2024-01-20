﻿// <auto-generated />
using System;
using HomeAssets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeAssets.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("HomeAssets.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AssetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Insured")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("HomeAssets.Entities.Label", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ParentLocationId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentLocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HomeAssets.Entities.Item", b =>
                {
                    b.HasOne("Location", "Location")
                        .WithMany("Items")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HomeAssets.Entities.Label", b =>
                {
                    b.HasOne("HomeAssets.Entities.Item", "Item")
                        .WithMany("Labels")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.HasOne("Location", "ParentLocation")
                        .WithMany("ChildLocations")
                        .HasForeignKey("ParentLocationId");

                    b.Navigation("ParentLocation");
                });

            modelBuilder.Entity("HomeAssets.Entities.Item", b =>
                {
                    b.Navigation("Labels");
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.Navigation("ChildLocations");

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
