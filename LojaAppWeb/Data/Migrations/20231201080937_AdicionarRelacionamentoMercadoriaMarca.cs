using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoMercadoriaMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Mercadoria",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercadoria_MarcaId",
                table: "Mercadoria",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mercadoria_Marca_MarcaId",
                table: "Mercadoria",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mercadoria_Marca_MarcaId",
                table: "Mercadoria");

            migrationBuilder.DropIndex(
                name: "IX_Mercadoria_MarcaId",
                table: "Mercadoria");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Mercadoria");
        }
    }
}
