﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20210119191545_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cons");

                    b.Property<string>("Name");

                    b.Property<string>("Pros");

                    b.Property<string>("Rating");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Cons = "Very Expensive",
                            Name = "New Zealand",
                            Pros = "Great for outdoor lovers!",
                            Rating = "5 Stars"
                        },
                        new
                        {
                            LocationId = 2,
                            Cons = "Rudeness",
                            Name = "France",
                            Pros = "Bread",
                            Rating = "4 Stars"
                        },
                        new
                        {
                            LocationId = 3,
                            Cons = "Might Get Kidnapped",
                            Name = "Somalia",
                            Pros = "Very Cheap",
                            Rating = "1 Star"
                        },
                        new
                        {
                            LocationId = 4,
                            Cons = "Endless Winter",
                            Name = "Antartica",
                            Pros = "Snow Angels",
                            Rating = "2 Stars"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
