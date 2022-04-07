using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class CustomerFKFixToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderIdId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleIdId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "TitleIdId",
                table: "Customers",
                newName: "TitleId");

            migrationBuilder.RenameColumn(
                name: "GenderIdId",
                table: "Customers",
                newName: "GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_TitleIdId",
                table: "Customers",
                newName: "IX_Customers_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_GenderIdId",
                table: "Customers",
                newName: "IX_Customers_GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderId",
                table: "Customers",
                column: "GenderId",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleId",
                table: "Customers",
                column: "TitleId",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "TitleId",
                table: "Customers",
                newName: "TitleIdId");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Customers",
                newName: "GenderIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_TitleId",
                table: "Customers",
                newName: "IX_Customers_TitleIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                newName: "IX_Customers_GenderIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderIdId",
                table: "Customers",
                column: "GenderIdId",
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
