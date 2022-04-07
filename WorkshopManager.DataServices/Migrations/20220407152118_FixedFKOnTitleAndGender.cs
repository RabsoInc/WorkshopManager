using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class FixedFKOnTitleAndGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TitleId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TitleId",
                table: "Customers",
                column: "TitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TitleId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TitleId",
                table: "Customers",
                column: "TitleId",
                unique: true);
        }
    }
}
