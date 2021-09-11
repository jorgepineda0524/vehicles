﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vehicles.Api.Data;

namespace Vehicles.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210908003840_AddTableBrandIndex")]
    partial class AddTableBrandIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HistoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("LaborPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProcedureId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SparePartsPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HistoryId");

                    b.HasIndex("ProcedureId");

                    b.ToTable("Detail");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Procedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Model")
                        .HasColumnType("int");

                    b.Property<string>("Plaque")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.VehiclePhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehiclePhoto");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Detail", b =>
                {
                    b.HasOne("Vehicles.Api.Data.Entities.History", "History")
                        .WithMany("Details")
                        .HasForeignKey("HistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vehicles.Api.Data.Entities.Procedure", "Procedure")
                        .WithMany()
                        .HasForeignKey("ProcedureId");

                    b.Navigation("History");

                    b.Navigation("Procedure");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.History", b =>
                {
                    b.HasOne("Vehicles.Api.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Vehicles.Api.Data.Entities.Vehicle", "Vehicle")
                        .WithMany("Histories")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.User", b =>
                {
                    b.HasOne("Vehicles.Api.Data.Entities.DocumentType", "DocumentType")
                        .WithMany("Users")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentType");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Vehicle", b =>
                {
                    b.HasOne("Vehicles.Api.Data.Entities.Brand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vehicles.Api.Data.Entities.User", "User")
                        .WithMany("Vehicles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vehicles.Api.Data.Entities.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId");

                    b.Navigation("Brand");

                    b.Navigation("User");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.VehiclePhoto", b =>
                {
                    b.HasOne("Vehicles.Api.Data.Entities.Vehicle", "Vehicle")
                        .WithMany("VehiclePhotos")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Brand", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.DocumentType", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.History", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.User", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Vehicles.Api.Data.Entities.Vehicle", b =>
                {
                    b.Navigation("Histories");

                    b.Navigation("VehiclePhotos");
                });
#pragma warning restore 612, 618
        }
    }
}
