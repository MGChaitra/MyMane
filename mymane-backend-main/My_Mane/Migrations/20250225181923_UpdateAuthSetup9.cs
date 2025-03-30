using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Mane.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthSetup9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PG_Property_PropertyId",
                table: "PG");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Owner_owner_id",
                table: "Property");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "PG",
                newName: "property_id");

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    owner_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "GETDATE()"),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.owner_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_PG_Property_property_id",
                table: "PG",
                column: "property_id",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Owners_owner_id",
                table: "Property",
                column: "owner_id",
                principalTable: "Owners",
                principalColumn: "owner_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PG_Property_property_id",
                table: "PG");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Owners_owner_id",
                table: "Property");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.RenameColumn(
                name: "property_id",
                table: "PG",
                newName: "PropertyId");

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    owner_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "GETDATE()"),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.owner_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_PG_Property_PropertyId",
                table: "PG",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Owner_owner_id",
                table: "Property",
                column: "owner_id",
                principalTable: "Owner",
                principalColumn: "owner_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
