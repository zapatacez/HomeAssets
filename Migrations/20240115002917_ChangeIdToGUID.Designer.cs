﻿// <auto-generated />
using System;
using HomeAssets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeAssets.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240115002917_ChangeIdToGUID")]
    partial class ChangeIdToGUID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

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

            modelBuilder.Entity("Location", b =>
                {
                    b.HasOne("Location", "ParentLocation")
                        .WithMany("ChildLocations")
                        .HasForeignKey("ParentLocationId");

                    b.Navigation("ParentLocation");
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.Navigation("ChildLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
