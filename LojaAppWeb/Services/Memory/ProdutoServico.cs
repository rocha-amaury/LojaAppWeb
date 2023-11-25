using LojaAppWeb.Models;

namespace LojaAppWeb.Services.Memory;

public class ProdutoServico : IProdutoServico
{
    public ProdutoServico()
        => CarregarListaInicial();

    private IList<Produto> _produtos;

    private void CarregarListaInicial()
    {
        _produtos = new List<Produto>()
    {
        new Produto
        {
            ProdutoId = 1,
            Nome = "Ancho Intermezzo",
            Descricao = "Ancho Intermezzo",
            ImagemUri= "/images/01_ancho_intermezzo.webp",
            Preco =19.00,
            EntregaExpressa= true,
            DataCadastro = DateTime.Now
        },

        new Produto
        {
            ProdutoId = 2,
            Nome = "Prime Rib Bassi Marfrig",
            Descricao = "Prime Rib Bassi Marfrig",
            ImagemUri= "/images/02_prime_rib_bassi_marfrig.webp",
            Preco =29.00,
            EntregaExpressa= false,
            DataCadastro = DateTime.Now
        },

        new Produto
        {
            ProdutoId = 3,
            Nome = "Ancho Bassi Marfrig",
            Descricao = "Ancho Bassi Marfrig",
            ImagemUri= "/images/03_ancho_bassi_marfrig.webp",
            Preco =22.00,
            EntregaExpressa= true,
            DataCadastro = DateTime.Now
        },

        new Produto
        {
            ProdutoId = 4,
            Nome = "T-Bone Intermezzo",
            Descricao = "T-Bone Intermezzo",
            ImagemUri= "/images/04_t_bone_intermezzo.webp",
            Preco =25.00,
            EntregaExpressa= false,
            DataCadastro = DateTime.Now
        },


        //05 - Shoulder Black VPJ
        //06 - Flat Iron Intermezzo
        //07 - Chuck Steak Intermezzo
        //08 - Prime Rib Bassi Marfrig
        //09 - Maminha Bassi Marfrig
        //10 - Tomahawk Cara Preta

    };
    }

    public IList<Produto> ObterTodos()
        => _produtos;

    public Produto Obter(int id)
        => ObterTodos().SingleOrDefault(item => item.ProdutoId == id);

    public void Incluir(Produto produto)
    {
        var proximoId = _produtos.Max(item => item.ProdutoId) + 1;
        produto.ProdutoId = proximoId;
        _produtos.Add(produto);
    }

    public void Alterar(Produto produto)
    {
        var produtoEncontrado = _produtos.SingleOrDefault(item => item.ProdutoId == produto.ProdutoId);
        produtoEncontrado.Nome = produto.Nome;
        produtoEncontrado.Descricao = produto.Descricao;
        produtoEncontrado.ImagemUri = produto.ImagemUri;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.EntregaExpressa = produto.EntregaExpressa;
        produtoEncontrado.DataCadastro = produto.DataCadastro;
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _produtos.Remove(produtoEncontrado);
    }
}
