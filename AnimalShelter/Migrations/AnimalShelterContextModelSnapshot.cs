﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("AvailableForAdoption")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Breed")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<bool>("SpayedOrNeutered")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            AvailableForAdoption = true,
                            Breed = "Main Coon",
                            Gender = "Male",
                            Name = "George",
                            SpayedOrNeutered = true,
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 12,
                            AvailableForAdoption = true,
                            Breed = "Domestic short hair",
                            Gender = "Female",
                            Name = "Lilly",
                            SpayedOrNeutered = true,
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            AvailableForAdoption = true,
                            Breed = "Labrador Retriever",
                            Gender = "Male",
                            Name = "Rover",
                            SpayedOrNeutered = true,
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            AvailableForAdoption = true,
                            Breed = "Dachshund",
                            Gender = "Male",
                            Name = "Fido",
                            SpayedOrNeutered = true,
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 2,
                            AvailableForAdoption = true,
                            Breed = "Syrian",
                            Gender = "Male",
                            Name = "Gerald",
                            SpayedOrNeutered = false,
                            Species = "Hamster"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
