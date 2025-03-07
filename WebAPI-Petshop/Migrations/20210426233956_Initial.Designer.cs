﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Petshop.Data;

namespace WebAPI_Petshop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210426233956_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("WebAPI_Petshop.Models.Accommodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccommodationName")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccommodationState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Accommodations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccommodationName = "Acomodação 1",
                            AccommodationState = 0,
                            PetId = 2
                        },
                        new
                        {
                            Id = 2,
                            AccommodationName = "Acomodação 2",
                            AccommodationState = 0,
                            PetId = 3
                        },
                        new
                        {
                            Id = 3,
                            AccommodationName = "Acomodação 3",
                            AccommodationState = 0,
                            PetId = 1
                        },
                        new
                        {
                            Id = 4,
                            AccommodationName = "Acomodação 4",
                            AccommodationState = 0,
                            PetId = 0
                        },
                        new
                        {
                            Id = 5,
                            AccommodationName = "Acomodação 5",
                            AccommodationState = 0,
                            PetId = 0
                        },
                        new
                        {
                            Id = 6,
                            AccommodationName = "Acomodação 6",
                            AccommodationState = 0,
                            PetId = 0
                        },
                        new
                        {
                            Id = 7,
                            AccommodationName = "Acomodação 7",
                            AccommodationState = 0,
                            PetId = 0
                        },
                        new
                        {
                            Id = 8,
                            AccommodationName = "Acomodação 8",
                            AccommodationState = 0,
                            PetId = 0
                        },
                        new
                        {
                            Id = 9,
                            AccommodationName = "Acomodação 9",
                            AccommodationState = 0,
                            PetId = 0
                        },
                        new
                        {
                            Id = 10,
                            AccommodationName = "Acomodação 10",
                            AccommodationState = 0,
                            PetId = 0
                        });
                });

            modelBuilder.Entity("WebAPI_Petshop.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccommodationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PetCause")
                        .HasColumnType("TEXT");

                    b.Property<int>("PetHeaulthState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PetOwnerAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("PetOwnerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PetOwnerPhone")
                        .HasColumnType("TEXT");

                    b.HasKey("PetId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            AccommodationId = 3,
                            PetCause = "Febre canina",
                            PetHeaulthState = 0,
                            PetName = "Bethoven",
                            PetOwnerAddress = "Av. dos Pets, 1234",
                            PetOwnerName = "Antônio Vasconcelos",
                            PetOwnerPhone = "85912345678"
                        },
                        new
                        {
                            PetId = 2,
                            AccommodationId = 1,
                            PetCause = "Incômodo na coluna vertebral",
                            PetHeaulthState = 0,
                            PetName = "Yoda",
                            PetOwnerAddress = "Av. dos Jedi, s/n",
                            PetOwnerName = "Anakim",
                            PetOwnerPhone = "85901101010"
                        },
                        new
                        {
                            PetId = 3,
                            AccommodationId = 2,
                            PetCause = "Perda de visão no olho",
                            PetHeaulthState = 0,
                            PetName = "Dalek",
                            PetOwnerAddress = "Av. Tardis, 987",
                            PetOwnerName = "Dora Holanda",
                            PetOwnerPhone = "85543215678"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
