using LojaAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new LojaDbContext();
            context.Categoria.AddRange(ObterCargaInicialCategoria());
            context.SaveChanges();
        }
        private IList<Categoria> ObterCargaInicialCategoria()
        {
            return new List<Categoria>()
            {
                new Categoria() { CategoriaNome = "Ofertas para o seu Churrasco" },
                new Categoria() { CategoriaNome = "Bovino" },
                new Categoria() { CategoriaNome = "Angus" },
                new Categoria() { CategoriaNome = "Wagyu" },
                new Categoria() { CategoriaNome = "Cortes Resfriados" },
                new Categoria() { CategoriaNome = "Cortes Congelados" },
                new Categoria() { CategoriaNome = "Hamburguer" },                
                new Categoria() { CategoriaNome = "Outros" },
            };
        }
    }
}
