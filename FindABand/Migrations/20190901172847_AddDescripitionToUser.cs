using Microsoft.EntityFrameworkCore.Migrations;

namespace FindABand.Migrations
{
    public partial class AddDescripitionToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserAccounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserAccounts");
        }
    }
}
