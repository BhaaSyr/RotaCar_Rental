using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RotaCar_Rental.Migrations
{
    /// <inheritdoc />
    public partial class editUserYable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Payments_PaymentID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PaymentID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "AspNetUsers",
                newName: "DriverLicenseNumber");

            migrationBuilder.RenameColumn(
                name: "IssueDate",
                table: "AspNetUsers",
                newName: "DriverLicenseIssueDate");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "AspNetUsers",
                newName: "DriverLicenseExpiryDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DriverLicenseNumber",
                table: "AspNetUsers",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "DriverLicenseIssueDate",
                table: "AspNetUsers",
                newName: "IssueDate");

            migrationBuilder.RenameColumn(
                name: "DriverLicenseExpiryDate",
                table: "AspNetUsers",
                newName: "ExpiryDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PaymentID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PaymentID",
                table: "AspNetUsers",
                column: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Payments_PaymentID",
                table: "AspNetUsers",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
