using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerScheduler.Migrations
{
    /// <inheritdoc />
    public partial class AddFactionAndDetachmentToGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detachment",
                table: "Games",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Faction",
                table: "Games",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detachment",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Faction",
                table: "Games");
        }
    }
}
