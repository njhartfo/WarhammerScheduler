using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerScheduler.Migrations
{
    /// <inheritdoc />
    public partial class AddDetachmentToGamePlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detachment",
                table: "GamePlayers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detachment",
                table: "GamePlayers");
        }
    }
}
