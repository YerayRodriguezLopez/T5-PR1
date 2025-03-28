﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(EnergyDBContext))]
    partial class EnergyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.EnergyIndicator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("CleanProduction")
                        .HasColumnType("real");

                    b.Property<float>("DisposableProduction")
                        .HasColumnType("real");

                    b.Property<float>("ElectricDemand")
                        .HasColumnType("real");

                    b.Property<float>("GasolineConsum")
                        .HasColumnType("real");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EnergyIndicator", (string)null);
                });

            modelBuilder.Entity("DB.System", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CostPerKWh")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("GeneratedEnergy")
                        .HasColumnType("float");

                    b.Property<double>("PricePerKWh")
                        .HasColumnType("float");

                    b.Property<double>("Ratio")
                        .HasColumnType("float");

                    b.Property<double>("SunHours")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WaterFlow")
                        .HasColumnType("float");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("System", (string)null);
                });

            modelBuilder.Entity("DB.WaterConsum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Consum")
                        .HasColumnType("real");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WaterConsum", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
