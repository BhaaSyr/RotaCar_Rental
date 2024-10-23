



using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RotaCar_Rental.Models;

namespace RotaCar_Rental
{
 public class ApplicationDbContext : IdentityDbContext

    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MaintenanceHistory> maintenanceHistories  { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
		public DbSet<AppUser> appUsers { get; set; }
		public DbSet<Review> Reviews { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    State = "California",
                    Street = "123 Sunset Blvd",
                    AvailableCar = 25,
                    City = "Los Angeles",
                    Name = "Sunset Car Rentals",
                    Phone = "555-5678",
                    Zip = "90001"
                }
                );
            modelBuilder.Entity<Feature>().HasData(
				new Feature
				{
					Id = 1,
					CarID = 1,
                    Name = "GPS",
				},
				new Feature
				{
					Id = 2,
					CarID = 1,
					Name = "Bluetooth",
				},
				new Feature
				{
					Id = 3,
					CarID = 1,
					Name = "Audio input",
				}, 
                new Feature
				{
					Id = 4,
					CarID = 1,
					Name = "Climate control",
				},
				new Feature
				{
					Id = 5,
					CarID = 1,
					Name = "Airconditions",
				},

				new Feature
				{
					Id = 6,
					CarID = 2,
					Name = "Car Kit",
				},
				new Feature
				{
					Id = 7,
					CarID =2,
					Name = "Bluetooth",
				},
				new Feature
				{
					Id = 8,
					CarID = 2,
					Name = "Audio input",
				},
				new Feature
				{
					Id = 9,
					CarID = 2,
					Name = "Seat Belt",
				},
				new Feature
				{
					Id = 10,
					CarID = 2,
					Name = "Airconditions",
				}
				);

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    LicensePlate = "XYZ-5678",
                    LocationID = 1,
                    Fuel = "Gasoline",
                    Make = "Toyota",
                    Seats = 4,
                    Status = "Available",
                    Year = 2021,
                    Type = "Sedan",
                    Model = "Corolla",
                    Mileage = 10000,
                    RentalRateDaily = 45.5m,
                    RentalRateWeekly = 300.00m,
                    Transmission = "Automatic"
                },

                    new Car
                    {
                        Id = 2,
                        LocationID = 1,
                        LicensePlate = "ABC-1234",
                        Fuel = "Diesel",
                        Make = "Ford",
                        Seats = 5,
                        Status = "Available",
                        Year = 2022,
                        Type = "SUV",
                        Model = "Escape",
                        Mileage = 12000,
                        RentalRateDaily = 60.00m,
                        RentalRateWeekly = 400.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 3,
                        LocationID = 1,
                        LicensePlate = "LMN-9876",
                        Fuel = "Electric",
                        Make = "Tesla",
                        Seats = 5,
                        Status = "Available",
                        Year = 2023,
                        Type = "Sedan",
                        Model = "Model 3",
                        Mileage = 8000,
                        RentalRateDaily = 90.00m,
                        RentalRateWeekly = 600.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 4,
                        LocationID = 1,
                        LicensePlate = "JKL-3456",
                        Fuel = "Hybrid",
                        Make = "Honda",
                        Seats = 5,
                        Status = "Available",
                        Year = 2020,
                        Type = "SUV",
                        Model = "CR-V",
                        Mileage = 15000,
                        RentalRateDaily = 55.00m,
                        RentalRateWeekly = 350.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 5,
                        LocationID = 1,

                        LicensePlate = "PQR-1122",
                        Fuel = "Gasoline",
                        Make = "BMW",
                        Seats = 4,
                        Status = "Available",
                        Year = 2021,
                        Type = "Coupe",
                        Model = "4 Series",
                        Mileage = 9000,
                        RentalRateDaily = 80.00m,
                        RentalRateWeekly = 500.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 6,
                        LocationID = 1,
                        LicensePlate = "GHJ-7789",
                        Fuel = "Gasoline",
                        Make = "Nissan",
                        Seats = 5,
                        Status = "Available",
                        Year = 2021,
                        Type = "Sedan",
                        Model = "Altima",
                        Mileage = 14000,
                        RentalRateDaily = 50.00m,
                        RentalRateWeekly = 330.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 7,
                        LocationID = 1,
                        LicensePlate = "ZXY-3344",
                        Fuel = "Gasoline",
                        Make = "Subaru",
                        Seats = 5,
                        Status = "Available",
                        Year = 2022,
                        Type = "SUV",
                        Model = "Forester",
                        Mileage = 5000,
                        RentalRateDaily = 70.00m,
                        RentalRateWeekly = 450.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 8,
                        LocationID = 1,
                        LicensePlate = "VWX-9987",
                        Fuel = "Gasoline",
                        Make = "Chevrolet",
                        Seats = 5,
                        Status = "Available",
                        Year = 2020,
                        Type = "SUV",
                        Model = "Traverse",
                        Mileage = 18000,
                        RentalRateDaily = 65.00m,
                        RentalRateWeekly = 420.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 9,
                        LocationID = 1,
                        LicensePlate = "YUI-2345",
                        Fuel = "Gasoline",
                        Make = "Audi",
                        Seats = 5,
                        Status = "Available",
                        Year = 2022,
                        Type = "SUV",
                        Model = "Q5",
                        Mileage = 6000,
                        RentalRateDaily = 85.00m,
                        RentalRateWeekly = 570.00m,
                        Transmission = "Automatic"
                    },

                    new Car
                    {
                        Id = 10,
                        LocationID = 1,
                        LicensePlate = "MNB-5567",
                        Fuel = "Gasoline",
                        Make = "Mercedes-Benz",
                        Seats = 5,
                        Status = "Available",
                        Year = 2021,
                        Type = "Sedan",
                        Model = "C-Class",
                        Mileage = 7000,
                        RentalRateDaily = 75.00m,
                        RentalRateWeekly = 500.00m,
                        Transmission = "Automatic"
                    }
                );



        }
    }





}
   

