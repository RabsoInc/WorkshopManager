using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class AddedSystemAttributeValueToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MapCode",
                table: "SystemAttributes",
                newName: "Mapcode");

            migrationBuilder.CreateTable(
                name: "SystemAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttributeValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SystemAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                name: "IX_SystemAttributeValues_SystemAttributeId",
                table: "SystemAttributeValues",
                column: "SystemAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemAttributeValues");

            migrationBuilder.RenameColumn(
                name: "Mapcode",
                table: "SystemAttributes",
                newName: "MapCode");
        }
    }
}
