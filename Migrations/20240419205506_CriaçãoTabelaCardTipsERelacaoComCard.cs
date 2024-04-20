using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    /// <inheritdoc />
    public partial class CriaçãoTabelaCardTipsERelacaoComCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ca_Test",
                table: "Cards",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ca_Test",
                table: "Cards");
        }
    }
}
