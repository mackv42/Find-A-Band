using Microsoft.EntityFrameworkCore.Migrations;

namespace FindABand.Migrations
{
    public partial class addedCityAndState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "UserAccounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "State",
                table: "UserAccounts");
        }
    }
}
