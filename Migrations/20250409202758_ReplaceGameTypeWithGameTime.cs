using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerScheduler.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceGameTypeWithGameTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GameType",
                table: "Games",
                newName: "GameTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GameTime",
                table: "Games",
                newName: "GameType");
        }
    }
}
