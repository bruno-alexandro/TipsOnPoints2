using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoNomesTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThemeComplements_Themes_Tc_ThemeId",
                table: "ThemeComplements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Themes",
                table: "Themes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThemeComplements",
                table: "ThemeComplements");

            migrationBuilder.RenameTable(
                name: "Themes",
                newName: "Theme");

            migrationBuilder.RenameTable(
                name: "ThemeComplements",
                newName: "ThemeComplement");

            migrationBuilder.RenameIndex(
                name: "IX_ThemeComplements_Tc_ThemeId",
                table: "ThemeComplement",
                newName: "IX_ThemeComplement_Tc_ThemeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Theme",
                table: "Theme",
                column: "Th_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThemeComplement",
                table: "ThemeComplement",
                column: "Tc_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeComplement_Theme_Tc_ThemeId",
                table: "ThemeComplement",
                column: "Tc_ThemeId",
                principalTable: "Theme",
                principalColumn: "Th_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThemeComplement_Theme_Tc_ThemeId",
                table: "ThemeComplement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThemeComplement",
                table: "ThemeComplement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Theme",
                table: "Theme");

            migrationBuilder.RenameTable(
                name: "ThemeComplement",
                newName: "ThemeComplements");

            migrationBuilder.RenameTable(
                name: "Theme",
                newName: "Themes");

            migrationBuilder.RenameIndex(
                name: "IX_ThemeComplement_Tc_ThemeId",
                table: "ThemeComplements",
                newName: "IX_ThemeComplements_Tc_ThemeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThemeComplements",
                table: "ThemeComplements",
                column: "Tc_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Themes",
                table: "Themes",
                column: "Th_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeComplements_Themes_Tc_ThemeId",
                table: "ThemeComplements",
                column: "Tc_ThemeId",
                principalTable: "Themes",
                principalColumn: "Th_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
