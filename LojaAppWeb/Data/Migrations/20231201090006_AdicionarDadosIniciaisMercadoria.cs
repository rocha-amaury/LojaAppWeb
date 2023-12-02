using LojaAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAppWeb.Data.Migrations;

/// <inheritdoc />
public partial class AdicionarDadosIniciaisMercadoria : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        var context = new LojaDbContext();
        context.Mercadoria.AddRange(ObterCargaInicialMercadoria());
        context.SaveChanges();

    }

    private IList<Mercadoria> ObterCargaInicialMercadoria()
    {
        return new List<Mercadoria>()
{
    new Mercadoria
    {
        Nome = "Ancho Intermezzo",
        Descricao = "Ancho Intermezzo",
        ImagemUri= "/images/01_ancho_intermezzo.webp",
        Preco =19.00,
        EntregaExpressa= true,
        DataCadastro = DateTime.Now
    },

    new Mercadoria
    {
        Nome = "Prime Rib Bassi Marfrig",
        Descricao = "Prime Rib Bassi Marfrig",
        ImagemUri= "/images/02_prime_rib_bassi_marfrig.webp",
        Preco =29.00,
        EntregaExpressa= false,
        DataCadastro = DateTime.Now
    },

    new Mercadoria
    {
        Nome = "Ancho Bassi Marfrig",
        Descricao = "Ancho Bassi Marfrig",
        ImagemUri= "/images/03_ancho_bassi_marfrig.webp",
        Preco =22.00,
        EntregaExpressa= true,
        DataCadastro = DateTime.Now
    },

    new Mercadoria
    {
        Nome = "T-Bone Intermezzo",
        Descricao = "T-Bone Intermezzo",
        ImagemUri= "/images/04_t_bone_intermezzo.webp",
        Preco =25.00,
        EntregaExpressa= false,
        DataCadastro = DateTime.Now
    },
};
    }
}
