using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class AddedTitleToDbFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Title_TitleId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Title",
                table: "Title");

            migrationBuilder.RenameTable(
                name: "Title",
                newName: "Titles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titles",
                table: "Titles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Titles_TitleId",
                table: "Customers",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Titles_TitleId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Titles",
                table: "Titles");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Title",
                table: "Title",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Title_TitleId",
                table: "Customers",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
