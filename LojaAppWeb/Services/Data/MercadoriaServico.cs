using LojaAppWeb.Data;
using LojaAppWeb.Models;

namespace LojaAppWeb.Services.Data;

public class MercadoriaServico : IMercadoriaServico
{
    private LojaDbContext _context;
    public MercadoriaServico(LojaDbContext context)
    {
        _context = context;
    }

    public void Alterar(Mercadoria Mercadoria)
    {
        var MercadoriaEncontrada = Obter(Mercadoria.MercadoriaId);
        MercadoriaEncontrada.Nome = Mercadoria.Nome;
        MercadoriaEncontrada.Descricao = Mercadoria.Descricao;
        MercadoriaEncontrada.ImagemUri = Mercadoria.ImagemUri;
        MercadoriaEncontrada.Preco = Mercadoria.Preco;
        MercadoriaEncontrada.EntregaExpressa = Mercadoria.EntregaExpressa;
        MercadoriaEncontrada.DataCadastro = Mercadoria.DataCadastro;
        MercadoriaEncontrada.MarcaId = Mercadoria.MarcaId;
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var MercadoriaEncontrada = Obter(id);
        _context.Mercadoria.Remove(MercadoriaEncontrada);
        _context.SaveChanges();
    }

    public void Incluir(Mercadoria Mercadoria)
    {
        _context.Mercadoria.Add(Mercadoria);
        _context.SaveChanges();
    }

    public Mercadoria Obter(int id)
    {
        return _context.Mercadoria.SingleOrDefault(item => item.MercadoriaId == id);
    }

    public IList<Mercadoria> ObterTodos()
    {
        return _context.Mercadoria.ToList();
    }

    public IList<Marca> ObterTodasMarcas() => _context.Marca.ToList();

    public Marca ObterMarca(int id) => _context.Marca.SingleOrDefault(item => item.MarcaId == id);
  
}
