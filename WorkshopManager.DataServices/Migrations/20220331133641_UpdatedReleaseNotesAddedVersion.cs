using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkshopManager.DataServices.Migrations
{
    public partial class UpdatedReleaseNotesAddedVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReleaseVersion",
                table: "ReleaseNotes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseVersion",
                table: "ReleaseNotes");
        }
    }
}
