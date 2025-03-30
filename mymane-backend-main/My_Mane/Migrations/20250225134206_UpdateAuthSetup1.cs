using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_Mane.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthSetup1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommercialRentLeases_Properties_PropertyId",
                table: "CommercialRentLeases");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseRents_Properties_PropertyId",
                table: "HouseRents");

            migrationBuilder.DropForeignKey(
                name: "FK_PGs_Properties_PropertyId",
                table: "PGs");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Owners_OwnerId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfos",
                table: "UserInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PGs",
                table: "PGs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseRents",
                table: "HouseRents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommercialRentLeases",
                table: "CommercialRentLeases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyNumber",
                table: "Properties");

            migrationBuilder.RenameTable(
                name: "UserInfos",
                newName: "UserInfo");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameTable(
                name: "PGs",
                newName: "PG");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "Owner");

            migrationBuilder.RenameTable(
                name: "HouseRents",
                newName: "HouseRent");

            migrationBuilder.RenameTable(
                name: "CommercialRentLeases",
                newName: "CommercialRentLease");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Property",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PropertyType",
                table: "Property",
                newName: "property_number");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Property",
                newName: "property_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Property",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AdminApproval",
                table: "Property",
                newName: "admin_approval");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Owner",
                newName: "owner_id");

            migrationBuilder.AlterColumn<int>(
                name: "property_id",
                table: "Property",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "property_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PG",
                table: "PG",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owner",
                table: "Owner",
                column: "owner_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseRent",
                table: "HouseRent",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommercialRentLease",
                table: "CommercialRentLease",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialRentLease_Property_PropertyId",
                table: "CommercialRentLease",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseRent_Property_PropertyId",
                table: "HouseRent",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PG_Property_PropertyId",
                table: "PG",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "property_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommercialRentLease_Property_PropertyId",
                table: "CommercialRentLease");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseRent_Property_PropertyId",
                table: "HouseRent");

            migrationBuilder.DropForeignKey(
                name: "FK_PG_Property_PropertyId",
                table: "PG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PG",
                table: "PG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owner",
                table: "Owner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseRent",
                table: "HouseRent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommercialRentLease",
                table: "CommercialRentLease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "UserInfos");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameTable(
                name: "PG",
                newName: "PGs");

            migrationBuilder.RenameTable(
                name: "Owner",
                newName: "Owners");

            migrationBuilder.RenameTable(
                name: "HouseRent",
                newName: "HouseRents");

            migrationBuilder.RenameTable(
                name: "CommercialRentLease",
                newName: "CommercialRentLeases");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Properties",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "property_number",
                table: "Properties",
                newName: "PropertyType");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Properties",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "admin_approval",
                table: "Properties",
                newName: "AdminApproval");

            migrationBuilder.RenameColumn(
                name: "property_id",
                table: "Properties",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "owner_id",
                table: "Owners",
                newName: "OwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Properties",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "PropertyNumber",
                table: "Properties",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfos",
                table: "UserInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PGs",
                table: "PGs",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseRents",
                table: "HouseRents",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommercialRentLeases",
                table: "CommercialRentLeases",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialRentLeases_Properties_PropertyId",
                table: "CommercialRentLeases",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseRents_Properties_PropertyId",
                table: "HouseRents",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PGs_Properties_PropertyId",
                table: "PGs",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Owners_OwnerId",
                table: "Properties",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
