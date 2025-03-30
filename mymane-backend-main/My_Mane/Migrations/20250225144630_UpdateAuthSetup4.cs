using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Mane.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthSetup4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommercialRentLease_Property_PropertyId",
                table: "CommercialRentLease");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommercialRentLease",
                table: "CommercialRentLease");

            migrationBuilder.RenameColumn(
                name: "WaterStorage",
                table: "CommercialRentLease",
                newName: "water_storage");

            migrationBuilder.RenameColumn(
                name: "RentNegotiable",
                table: "CommercialRentLease",
                newName: "rent_negotiable");

            migrationBuilder.RenameColumn(
                name: "PropertyAge",
                table: "CommercialRentLease",
                newName: "property_age");

            migrationBuilder.RenameColumn(
                name: "PowerBackup",
                table: "CommercialRentLease",
                newName: "power_backup");

            migrationBuilder.RenameColumn(
                name: "LeaseDuration",
                table: "CommercialRentLease",
                newName: "lease_duration");

            migrationBuilder.RenameColumn(
                name: "ExpectedRent",
                table: "CommercialRentLease",
                newName: "expected_rent");

            migrationBuilder.RenameColumn(
                name: "ExpectedDeposit",
                table: "CommercialRentLease",
                newName: "expected_deposit");

            migrationBuilder.RenameColumn(
                name: "CleanItAfterTenure",
                table: "CommercialRentLease",
                newName: "clean_it_before_tenure");

            migrationBuilder.RenameColumn(
                name: "BuiltUpArea",
                table: "CommercialRentLease",
                newName: "built_up_area");

            migrationBuilder.AddColumn<int>(
                name: "property_id",
                table: "CommercialRentLease",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "clean_it_after_tenure",
                table: "CommercialRentLease",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommercialRentLease",
                table: "CommercialRentLease",
                column: "property_id");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    publish_date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Heading = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuthorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialRentLease_Property_property_id",
                table: "CommercialRentLease",
                column: "property_id",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommercialRentLease_Property_property_id",
                table: "CommercialRentLease");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommercialRentLease",
                table: "CommercialRentLease");

            migrationBuilder.DropColumn(
                name: "property_id",
                table: "CommercialRentLease");

            migrationBuilder.DropColumn(
                name: "clean_it_after_tenure",
                table: "CommercialRentLease");

            migrationBuilder.RenameColumn(
                name: "water_storage",
                table: "CommercialRentLease",
                newName: "WaterStorage");

            migrationBuilder.RenameColumn(
                name: "rent_negotiable",
                table: "CommercialRentLease",
                newName: "RentNegotiable");

            migrationBuilder.RenameColumn(
                name: "property_age",
                table: "CommercialRentLease",
                newName: "PropertyAge");

            migrationBuilder.RenameColumn(
                name: "power_backup",
                table: "CommercialRentLease",
                newName: "PowerBackup");

            migrationBuilder.RenameColumn(
                name: "lease_duration",
                table: "CommercialRentLease",
                newName: "LeaseDuration");

            migrationBuilder.RenameColumn(
                name: "expected_rent",
                table: "CommercialRentLease",
                newName: "ExpectedRent");

            migrationBuilder.RenameColumn(
                name: "expected_deposit",
                table: "CommercialRentLease",
                newName: "ExpectedDeposit");

            migrationBuilder.RenameColumn(
                name: "clean_it_before_tenure",
                table: "CommercialRentLease",
                newName: "CleanItAfterTenure");

            migrationBuilder.RenameColumn(
                name: "built_up_area",
                table: "CommercialRentLease",
                newName: "BuiltUpArea");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommercialRentLease",
                table: "CommercialRentLease",
                column: "PropertyId");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuthorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Heading = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialRentLease_Property_PropertyId",
                table: "CommercialRentLease",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
