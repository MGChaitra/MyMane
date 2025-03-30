using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Mane.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthSetup8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Owner",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Owner",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "RentNegotiable",
                table: "HouseRent",
                newName: "rent_negotiable");

            migrationBuilder.RenameColumn(
                name: "ExpectedRent",
                table: "HouseRent",
                newName: "expected_rent");

            migrationBuilder.RenameColumn(
                name: "ExpectedDeposit",
                table: "HouseRent",
                newName: "expected_deposit");

            migrationBuilder.RenameColumn(
                name: "BuiltUpArea",
                table: "HouseRent",
                newName: "built_up_area");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Owner",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Owner",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "rent_negotiable",
                table: "HouseRent",
                newName: "RentNegotiable");

            migrationBuilder.RenameColumn(
                name: "expected_rent",
                table: "HouseRent",
                newName: "ExpectedRent");

            migrationBuilder.RenameColumn(
                name: "expected_deposit",
                table: "HouseRent",
                newName: "ExpectedDeposit");

            migrationBuilder.RenameColumn(
                name: "built_up_area",
                table: "HouseRent",
                newName: "BuiltUpArea");
        }
    }
}
