using Microsoft.EntityFrameworkCore.Migrations;

namespace FindABand.Migrations
{
    public partial class addedFingerPrint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FingerPrint",
                table: "Songs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FingerPrint",
                table: "Songs");
        }
    }
}
