using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RotaCar_Rental.Migrations
{
    /// <inheritdoc />
    public partial class seedCarsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "AvailableCar", "City", "Name", "Phone", "State", "Street", "Zip" },
                values: new object[] { 1, 25, "Los Angeles", "Sunset Car Rentals", "555-5678", "California", "123 Sunset Blvd", "90001" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Fuel", "ImageUrl", "LicensePlate", "LocationID", "Make", "Mileage", "Model", "RentalRateDaily", "RentalRateWeekly", "Seats", "Status", "Transmission", "Type", "Year" },
                values: new object[,]
                {
                    { 1, "Gasoline", null, "XYZ-5678", 1, "Toyota", 10000, "Corolla", 45.5m, 300.00m, 4, "Available", "Automatic", "Sedan", 2021 },
                    { 2, "Diesel", null, "ABC-1234", 1, "Ford", 12000, "Escape", 60.00m, 400.00m, 5, "Available", "Automatic", "SUV", 2022 },
                    { 3, "Electric", null, "LMN-9876", 1, "Tesla", 8000, "Model 3", 90.00m, 600.00m, 5, "Available", "Automatic", "Sedan", 2023 },
                    { 4, "Hybrid", null, "JKL-3456", 1, "Honda", 15000, "CR-V", 55.00m, 350.00m, 5, "Available", "Automatic", "SUV", 2020 },
                    { 5, "Gasoline", null, "PQR-1122", 1, "BMW", 9000, "4 Series", 80.00m, 500.00m, 4, "Available", "Automatic", "Coupe", 2021 },
                    { 6, "Gasoline", null, "GHJ-7789", 1, "Nissan", 14000, "Altima", 50.00m, 330.00m, 5, "Available", "Automatic", "Sedan", 2021 },
                    { 7, "Gasoline", null, "ZXY-3344", 1, "Subaru", 5000, "Forester", 70.00m, 450.00m, 5, "Available", "Automatic", "SUV", 2022 },
                    { 8, "Gasoline", null, "VWX-9987", 1, "Chevrolet", 18000, "Traverse", 65.00m, 420.00m, 5, "Available", "Automatic", "SUV", 2020 },
                    { 9, "Gasoline", null, "YUI-2345", 1, "Audi", 6000, "Q5", 85.00m, 570.00m, 5, "Available", "Automatic", "SUV", 2022 },
                    { 10, "Gasoline", null, "MNB-5567", 1, "Mercedes-Benz", 7000, "C-Class", 75.00m, 500.00m, 5, "Available", "Automatic", "Sedan", 2021 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
