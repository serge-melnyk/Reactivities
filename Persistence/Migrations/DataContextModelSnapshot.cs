﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Venue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("035045ef-f7c8-4b19-9807-fa1a217275e8"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2020, 1, 6, 17, 8, 47, 896, DateTimeKind.Local).AddTicks(1342),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("fb626182-6b7d-45d8-9365-3e81d5cd12a0"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2020, 2, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8750),
                            Description = "Activity 1 month ago",
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("43b83e5c-7d45-4290-83a6-31973ed55883"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2020, 4, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8893),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("96a12317-f91b-4b6e-ab83-f1c1f7c5abd7"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2020, 5, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8901),
                            Description = "Activity 2 months in future",
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("9a20e5ee-e775-4940-9a83-bec0ae55563d"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2020, 6, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8904),
                            Description = "Activity 3 months in future",
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("f69cd766-e854-4dee-8f8c-f693827bf93a"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2020, 7, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8912),
                            Description = "Activity 4 months in future",
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("fcd24396-9014-4cc6-9a2d-09ecce7609c5"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2020, 8, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8916),
                            Description = "Activity 5 months in future",
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("b8702e43-67b5-419f-aeb6-798a9edda887"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2020, 9, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8920),
                            Description = "Activity 6 months in future",
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("46715405-eb5d-4798-b7f6-de8984d9c7b0"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2020, 10, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8923),
                            Description = "Activity 2 months ago",
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("65e679f4-cb48-4fbb-8500-aef52293d653"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2020, 11, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8927),
                            Description = "Activity 8 months in future",
                            Title = "Future Activity 8",
                            Venue = "Cinema"
                        });
                });

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Value 101"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Value 102"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Value 103"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Value 103"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
