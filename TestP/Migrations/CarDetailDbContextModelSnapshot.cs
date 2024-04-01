﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestP.Models;

#nullable disable

namespace TestP.Migrations
{
    [DbContext(typeof(CarDetailDbContext))]
    partial class CarDetailDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestP.Models.CarsDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LicensePlateNumber")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Marke")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OwnerContactInfo")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CarsDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
