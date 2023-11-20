using LojaAppWeb.Models;

namespace LojaAppWeb.Services;

public interface IProdutoServico
{
    IList<Produto> ObterTodos();
    Produto Obter(int id);
    void Incluir(Produto produto);
    void Alterar(Produto produto);
    public void Excluir(int id);

}
