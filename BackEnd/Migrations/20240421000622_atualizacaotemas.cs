using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacaotemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Th_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Th_PluralTheme = table.Column<string>(type: "TEXT", nullable: true),
                    Th_SingleTheme = table.Column<string>(type: "TEXT", nullable: true),
                    Th_QtyTips = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Th_Id);
                });

            migrationBuilder.CreateTable(
                name: "ThemeComplements",
                columns: table => new
                {
                    Tc_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tc_ThemeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tc_Complements = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeComplements", x => x.Tc_Id);
                    table.ForeignKey(
                        name: "FK_ThemeComplements_Themes_Tc_ThemeId",
                        column: x => x.Tc_ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Th_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThemeComplements_Tc_ThemeId",
                table: "ThemeComplements",
                column: "Tc_ThemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThemeComplements");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
