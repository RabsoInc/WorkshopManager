using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class AddedTitleToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TitleId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TitleId",
                table: "Customers",
                column: "TitleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Title_TitleId",
                table: "Customers",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Title_TitleId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TitleId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Customers");
        }
    }
}
