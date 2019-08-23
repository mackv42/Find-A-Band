using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindABand.Data.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_UserAccounts_UserAccountProfileId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_UserAccounts_UserAccountProfileId",
                table: "Instruments");

            migrationBuilder.DropIndex(
                name: "IX_Instruments_UserAccountProfileId",
                table: "Instruments");

            migrationBuilder.DropIndex(
                name: "IX_Genres_UserAccountProfileId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "UserAccountProfileId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "UserAccountProfileId",
                table: "Genres");

            migrationBuilder.CreateTable(
                name: "TalentByGenre",
                columns: table => new
                {
                    TalentKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentByGenre", x => x.TalentKey);
                    table.ForeignKey(
                        name: "FK_TalentByGenre_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalentByInstrument",
                columns: table => new
                {
                    TalentKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentByInstrument", x => x.TalentKey);
                    table.ForeignKey(
                        name: "FK_TalentByInstrument_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TalentByGenre_UserId",
                table: "TalentByGenre",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentByInstrument_UserId",
                table: "TalentByInstrument",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TalentByGenre");

            migrationBuilder.DropTable(
                name: "TalentByInstrument");

            migrationBuilder.AddColumn<int>(
                name: "UserAccountProfileId",
                table: "Instruments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserAccountProfileId",
                table: "Genres",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_UserAccountProfileId",
                table: "Instruments",
                column: "UserAccountProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_UserAccountProfileId",
                table: "Genres",
                column: "UserAccountProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_UserAccounts_UserAccountProfileId",
                table: "Genres",
                column: "UserAccountProfileId",
                principalTable: "UserAccounts",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_UserAccounts_UserAccountProfileId",
                table: "Instruments",
                column: "UserAccountProfileId",
                principalTable: "UserAccounts",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
