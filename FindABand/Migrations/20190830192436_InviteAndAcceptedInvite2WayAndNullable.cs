using Microsoft.EntityFrameworkCore.Migrations;

namespace FindABand.Migrations
{
    public partial class InviteAndAcceptedInvite2WayAndNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "AcceptedInvites");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "AcceptedInvites");

            migrationBuilder.AddColumn<int>(
                name: "BandRecipientId",
                table: "Invites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRecipientId",
                table: "Invites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserSenderId",
                table: "Invites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BandRecipientId",
                table: "AcceptedInvites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BandSenderId",
                table: "AcceptedInvites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRecipientId",
                table: "AcceptedInvites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserSenderId",
                table: "AcceptedInvites",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BandRecipientId",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "UserRecipientId",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "UserSenderId",
                table: "Invites");

            migrationBuilder.DropColumn(
                name: "BandRecipientId",
                table: "AcceptedInvites");

            migrationBuilder.DropColumn(
                name: "BandSenderId",
                table: "AcceptedInvites");

            migrationBuilder.DropColumn(
                name: "UserRecipientId",
                table: "AcceptedInvites");

            migrationBuilder.DropColumn(
                name: "UserSenderId",
                table: "AcceptedInvites");

            migrationBuilder.AddColumn<int>(
                name: "RecipientId",
                table: "Invites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "Invites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipientId",
                table: "AcceptedInvites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "AcceptedInvites",
                nullable: false,
                defaultValue: 0);
        }
    }
}
