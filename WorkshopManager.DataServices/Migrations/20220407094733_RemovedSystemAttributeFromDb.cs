using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class RemovedSystemAttributeFromDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderId1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderIdId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleId1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleIdId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "SystemAttributeValues");

            migrationBuilder.DropTable(
                name: "SystemAttributes");

            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderIdId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TitleId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TitleIdId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GenderId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GenderIdId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TitleId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TitleIdId",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GenderId1",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GenderIdId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TitleId1",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TitleIdId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "SystemAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mapcode = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemAttributeValues_SystemAttributes_SystemAttributeId",
                        column: x => x.SystemAttributeId,
                        principalTable: "SystemAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId1",
                table: "Customers",
                column: "GenderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderIdId",
                table: "Customers",
                column: "GenderIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TitleId1",
                table: "Customers",
                column: "TitleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TitleIdId",
                table: "Customers",
                column: "TitleIdId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAttributeValues_SystemAttributeId",
                table: "SystemAttributeValues",
                column: "SystemAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderId1",
                table: "Customers",
                column: "GenderId1",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderIdId",
                table: "Customers",
                column: "GenderIdId",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleId1",
                table: "Customers",
                column: "TitleId1",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleIdId",
                table: "Customers",
                column: "TitleIdId",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
