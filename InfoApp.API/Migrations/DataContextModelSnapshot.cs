﻿// <auto-generated />
using InfoApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InfoApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("InfoApp.API.Models.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AWB")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FronLoc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("ToLoc")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Examples");
                });

            modelBuilder.Entity("InfoApp.API.Models.Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("B")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Building_no")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Contact_no")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Delivery_option")
                        .HasColumnType("TEXT");

                    b.Property<int>("H")
                        .HasColumnType("INTEGER");

                    b.Property<int>("L")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Locality")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pickup_address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pin_code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Shipment_type")
                        .HasColumnType("TEXT");

                    b.Property<int>("Street_no")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("InfoApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
