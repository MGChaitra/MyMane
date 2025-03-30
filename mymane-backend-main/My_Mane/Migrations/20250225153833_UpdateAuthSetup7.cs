using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Mane.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthSetup7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseRent_Property_PropertyId",
                table: "HouseRent");

            migrationBuilder.RenameColumn(
                name: "AvailableFrom",
                table: "HouseRent",
                newName: "available_from");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "HouseRent",
                newName: "property_id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseRent_Property_property_id",
                table: "HouseRent",
                column: "property_id",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseRent_Property_property_id",
                table: "HouseRent");

            migrationBuilder.RenameColumn(
                name: "available_from",
                table: "HouseRent",
                newName: "AvailableFrom");

            migrationBuilder.RenameColumn(
                name: "property_id",
                table: "HouseRent",
                newName: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseRent_Property_PropertyId",
                table: "HouseRent",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
