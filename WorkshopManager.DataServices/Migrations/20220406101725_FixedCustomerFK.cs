using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class FixedCustomerFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "TitleId1");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_TitleId",
                table: "Customers",
                newName: "IX_Customers_TitleIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                newName: "IX_Customers_TitleId1");

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId1",
                table: "Customers",
                column: "GenderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderIdId",
                table: "Customers",
                column: "GenderIdId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderIdId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GenderId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GenderIdId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "TitleIdId",
                table: "Customers",
                newName: "TitleId");

            migrationBuilder.RenameColumn(
                name: "TitleId1",
                table: "Customers",
                newName: "GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_TitleIdId",
                table: "Customers",
                newName: "IX_Customers_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_TitleId1",
                table: "Customers",
                newName: "IX_Customers_GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_GenderId",
                table: "Customers",
                column: "GenderId",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemAttributeValues_TitleId",
                table: "Customers",
                column: "TitleId",
                principalTable: "SystemAttributeValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
