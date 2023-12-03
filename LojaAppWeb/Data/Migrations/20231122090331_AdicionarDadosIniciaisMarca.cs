using LojaAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAppWeb.Data.Migrations;

/// <inheritdoc />
public partial class AdicionarDadosIniciaisMarca : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        var context = new LojaDbContext();
        context.Marca.AddRange(ObterCargaInicialMarca());
        context.SaveChanges();
    }

    private IList<Marca> ObterCargaInicialMarca()
    {
        return new List<Marca>()
        {
            new Marca() { MarcaNome = "Intermezzo"},
            new Marca() { MarcaNome = "Marfrig"},
            new Marca() { MarcaNome = "VPJ"},
            new Marca() { MarcaNome = "Cara Preta"},
            new Marca() { MarcaNome = "Cantagallo"},
            new Marca() { MarcaNome = "D'Pão"},
        };
    }

}
