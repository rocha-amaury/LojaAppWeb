using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentomercadoriaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaMercadoria",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    MercadoriasMercadoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaMercadoria", x => new { x.CategoriasCategoriaId, x.MercadoriasMercadoriaId });
                    table.ForeignKey(
                        name: "FK_CategoriaMercadoria_Categoria_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaMercadoria_Mercadoria_MercadoriasMercadoriaId",
                        column: x => x.MercadoriasMercadoriaId,
                        principalTable: "Mercadoria",
                        principalColumn: "MercadoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaMercadoria_MercadoriasMercadoriaId",
                table: "CategoriaMercadoria",
                column: "MercadoriasMercadoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaMercadoria");
        }
    }
}
