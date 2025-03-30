using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Mane.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthSetup2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "owner_id",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Property_owner_id",
                table: "Property",
                column: "owner_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Owner_owner_id",
                table: "Property",
                column: "owner_id",
                principalTable: "Owner",
                principalColumn: "owner_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_Owner_owner_id",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_owner_id",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "owner_id",
                table: "Property");
        }
    }
}
