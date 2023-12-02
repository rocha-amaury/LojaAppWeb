using LojaAppWeb.Models;

namespace LojaAppWeb.Services;

public interface IMercadoriaServico
{
    IList<Mercadoria> ObterTodos();
    Mercadoria Obter(int id);
    void Incluir(Mercadoria Mercadoria);
    void Alterar(Mercadoria Mercadoria);
    public void Excluir(int id);
    IList<Marca> ObterTodasMarcas();
    Marca ObterMarca(int id);
    IList<Categoria> ObterTodasCategorias();
}
