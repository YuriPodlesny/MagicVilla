﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230501203214_addUsersToDb")]
    partial class addUsersToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 5, 2, 1, 32, 14, 783, DateTimeKind.Local).AddTicks(7167),
                            Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/417140169.jpg?k=794dd7b184f101b8aa59e7260923931a1e25589de58b7ce011294797408be673&o=&hp=1",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 0.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 5, 2, 1, 32, 14, 783, DateTimeKind.Local).AddTicks(7340),
                            Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/200990168.jpg?k=efdbcb6b8000ed684476b3abb5eae43a36a8e10a0b3680026ce73af0cb83ee90&o=&hp=1",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 0.0,
                            Sqft = 250,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 5, 2, 1, 32, 14, 783, DateTimeKind.Local).AddTicks(7342),
                            Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/375779638.jpg?k=61801f9d0506627a342055c873c539af50b89c8706fc226eb02ea901fe124e38&o=&hp=1",
                            Name = "Diamond Pool Villa",
                            Occupancy = 2,
                            Rate = 0.0,
                            Sqft = 350,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 5, 2, 1, 32, 14, 783, DateTimeKind.Local).AddTicks(7344),
                            Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/375779625.jpg?k=9347d660e6fb93f528a74ee4f0789b2f80aed1a877820497923bdc74029fafa3&o=&hp=1",
                            Name = "Wild Orchid Villa",
                            Occupancy = 1,
                            Rate = 0.0,
                            Sqft = 150,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 5, 2, 1, 32, 14, 783, DateTimeKind.Local).AddTicks(7345),
                            Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/177185852.jpg?k=653c282762e3dab1087205beb9ac90af00308f4f387c09986dcb8ed8c8a6260a&o=&hp=1",
                            Name = "Wild Orchid Villa",
                            Occupancy = 6,
                            Rate = 0.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
