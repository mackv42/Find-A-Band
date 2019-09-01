using Microsoft.EntityFrameworkCore.Migrations;

namespace FindABand.Migrations
{
    public partial class addTestBoolToBand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Test",
                table: "Bands",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Bands");
        }
    }
}
