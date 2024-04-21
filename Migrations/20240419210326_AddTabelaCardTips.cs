using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsOnPoints2.Migrations
{
    /// <inheritdoc />
    public partial class AddTabelaCardTips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ca_Test",
                table: "Cards");

            migrationBuilder.CreateTable(
                name: "CardTips",
                columns: table => new
                {
                    Ct_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ct_CardId = table.Column<int>(type: "INTEGER", nullable: false),
                    Ct_Tip = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTips", x => x.Ct_Id);
                    table.ForeignKey(
                        name: "FK_CardTips_Cards_Ct_CardId",
                        column: x => x.Ct_CardId,
                        principalTable: "Cards",
                        principalColumn: "Ca_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardTips_Ct_CardId",
                table: "CardTips",
                column: "Ct_CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTips");

            migrationBuilder.AddColumn<int>(
                name: "Ca_Test",
                table: "Cards",
                type: "INTEGER",
                nullable: true);
        }
    }
}
