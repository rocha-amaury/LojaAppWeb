using LojaAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaAppWeb.Data;

public class LojaDbContext : DbContext
{
    public LojaDbContext()
    {
    }

    public LojaDbContext(DbContextOptions options) : base(options)
    {
    }

    //Mapeando classe do modelo como entidade no EF
    public DbSet<Mercadoria> Mercadoria { get; set; }
    public DbSet<Marca> Marca { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string conn = config.GetConnectionString("MyConn");
        optionsBuilder.UseSqlServer(conn);
    }

}
