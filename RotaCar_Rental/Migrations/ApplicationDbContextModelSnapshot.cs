﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RotaCar_Rental;

#nullable disable

namespace RotaCar_Rental.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RentalRateDaily")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RentalRateWeekly")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fuel = "Gasoline",
                            LicensePlate = "XYZ-5678",
                            LocationID = 1,
                            Make = "Toyota",
                            Mileage = 10000,
                            Model = "Corolla",
                            RentalRateDaily = 45.5m,
                            RentalRateWeekly = 300.00m,
                            Seats = 4,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "Sedan",
                            Year = 2021
                        },
                        new
                        {
                            Id = 2,
                            Fuel = "Diesel",
                            LicensePlate = "ABC-1234",
                            LocationID = 1,
                            Make = "Ford",
                            Mileage = 12000,
                            Model = "Escape",
                            RentalRateDaily = 60.00m,
                            RentalRateWeekly = 400.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "SUV",
                            Year = 2022
                        },
                        new
                        {
                            Id = 3,
                            Fuel = "Electric",
                            LicensePlate = "LMN-9876",
                            LocationID = 1,
                            Make = "Tesla",
                            Mileage = 8000,
                            Model = "Model 3",
                            RentalRateDaily = 90.00m,
                            RentalRateWeekly = 600.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "Sedan",
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            Fuel = "Hybrid",
                            LicensePlate = "JKL-3456",
                            LocationID = 1,
                            Make = "Honda",
                            Mileage = 15000,
                            Model = "CR-V",
                            RentalRateDaily = 55.00m,
                            RentalRateWeekly = 350.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "SUV",
                            Year = 2020
                        },
                        new
                        {
                            Id = 5,
                            Fuel = "Gasoline",
                            LicensePlate = "PQR-1122",
                            LocationID = 1,
                            Make = "BMW",
                            Mileage = 9000,
                            Model = "4 Series",
                            RentalRateDaily = 80.00m,
                            RentalRateWeekly = 500.00m,
                            Seats = 4,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "Coupe",
                            Year = 2021
                        },
                        new
                        {
                            Id = 6,
                            Fuel = "Gasoline",
                            LicensePlate = "GHJ-7789",
                            LocationID = 1,
                            Make = "Nissan",
                            Mileage = 14000,
                            Model = "Altima",
                            RentalRateDaily = 50.00m,
                            RentalRateWeekly = 330.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "Sedan",
                            Year = 2021
                        },
                        new
                        {
                            Id = 7,
                            Fuel = "Gasoline",
                            LicensePlate = "ZXY-3344",
                            LocationID = 1,
                            Make = "Subaru",
                            Mileage = 5000,
                            Model = "Forester",
                            RentalRateDaily = 70.00m,
                            RentalRateWeekly = 450.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "SUV",
                            Year = 2022
                        },
                        new
                        {
                            Id = 8,
                            Fuel = "Gasoline",
                            LicensePlate = "VWX-9987",
                            LocationID = 1,
                            Make = "Chevrolet",
                            Mileage = 18000,
                            Model = "Traverse",
                            RentalRateDaily = 65.00m,
                            RentalRateWeekly = 420.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "SUV",
                            Year = 2020
                        },
                        new
                        {
                            Id = 9,
                            Fuel = "Gasoline",
                            LicensePlate = "YUI-2345",
                            LocationID = 1,
                            Make = "Audi",
                            Mileage = 6000,
                            Model = "Q5",
                            RentalRateDaily = 85.00m,
                            RentalRateWeekly = 570.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "SUV",
                            Year = 2022
                        },
                        new
                        {
                            Id = 10,
                            Fuel = "Gasoline",
                            LicensePlate = "MNB-5567",
                            LocationID = 1,
                            Make = "Mercedes-Benz",
                            Mileage = 7000,
                            Model = "C-Class",
                            RentalRateDaily = 75.00m,
                            RentalRateWeekly = 500.00m,
                            Seats = 5,
                            Status = "Available",
                            Transmission = "Automatic",
                            Type = "Sedan",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableCar")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableCar = 25,
                            City = "Los Angeles",
                            Lat = 0.0,
                            Long = 0.0,
                            Name = "Sunset Car Rentals",
                            Phone = "555-5678",
                            State = "California",
                            Street = "123 Sunset Blvd",
                            Zip = "90001"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("Date");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.HasIndex("PaymentID");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("Date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("RotaCar_Rental.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarID = 1,
                            Name = "GPS"
                        },
                        new
                        {
                            Id = 2,
                            CarID = 1,
                            Name = "Bluetooth"
                        },
                        new
                        {
                            Id = 3,
                            CarID = 1,
                            Name = "Audio input"
                        },
                        new
                        {
                            Id = 4,
                            CarID = 1,
                            Name = "Climate control"
                        },
                        new
                        {
                            Id = 5,
                            CarID = 1,
                            Name = "Airconditions"
                        },
                        new
                        {
                            Id = 6,
                            CarID = 2,
                            Name = "Car Kit"
                        },
                        new
                        {
                            Id = 7,
                            CarID = 2,
                            Name = "Bluetooth"
                        },
                        new
                        {
                            Id = 8,
                            CarID = 2,
                            Name = "Audio input"
                        },
                        new
                        {
                            Id = 9,
                            CarID = 2,
                            Name = "Seat Belt"
                        },
                        new
                        {
                            Id = 10,
                            CarID = 2,
                            Name = "Airconditions"
                        });
                });

            modelBuilder.Entity("RotaCar_Rental.Models.MaintenanceHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.ToTable("maintenanceHistories");
                });

            modelBuilder.Entity("RotaCar_Rental.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DriverLicenseExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DriverLicenseIssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriverLicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Car", b =>
                {
                    b.HasOne("Location", "location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("location");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rental", b =>
                {
                    b.HasOne("Car", "car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payment", "payment")
                        .WithMany()
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");

                    b.Navigation("payment");
                });

            modelBuilder.Entity("Review", b =>
                {
                    b.HasOne("Car", "car")
                        .WithMany("Reviews")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("RotaCar_Rental.Models.Feature", b =>
                {
                    b.HasOne("Car", "Car")
                        .WithMany("Features")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("RotaCar_Rental.Models.MaintenanceHistory", b =>
                {
                    b.HasOne("Car", "Car")
                        .WithMany("MaintenanceHistory")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Car", b =>
                {
                    b.Navigation("Features");

                    b.Navigation("MaintenanceHistory");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
