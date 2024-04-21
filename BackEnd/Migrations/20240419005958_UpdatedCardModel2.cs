using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCardModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ca_SingularTheme",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Ca_Theme",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "Ca_ThemeId",
                table: "Cards",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ca_ThemeId",
                table: "Cards");

            migrationBuilder.AddColumn<string>(
                name: "Ca_SingularTheme",
                table: "Cards",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ca_Theme",
                table: "Cards",
                type: "TEXT",
                nullable: true);
        }
    }
}
