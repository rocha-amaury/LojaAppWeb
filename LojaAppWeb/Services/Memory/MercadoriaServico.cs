using LojaAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaAppWeb.Services.Memory;

public class MercadoriaServico : IMercadoriaServico
{
    public MercadoriaServico()
        => CarregarListaInicial();

    private IList<Mercadoria> _Mercadorias;

    private void CarregarListaInicial()
    {
        _Mercadorias = new List<Mercadoria>()
    {
        new Mercadoria
        {
            MercadoriaId = 1,
            Nome = "Ancho Intermezzo",
            Descricao = "Ancho Intermezzo",
            ImagemUri= "/images/01_ancho_intermezzo.webp",
            Preco =19.00,
            EntregaExpressa= true,
            DataCadastro = DateTime.Now
        },

        new Mercadoria
        {
            MercadoriaId = 2,
            Nome = "Prime Rib Bassi Marfrig",
            Descricao = "Prime Rib Bassi Marfrig",
            ImagemUri= "/images/02_prime_rib_bassi_marfrig.webp",
            Preco =29.00,
            EntregaExpressa= false,
            DataCadastro = DateTime.Now
        },

        new Mercadoria
        {
            MercadoriaId = 3,
            Nome = "Ancho Bassi Marfrig",
            Descricao = "Ancho Bassi Marfrig",
            ImagemUri= "/images/03_ancho_bassi_marfrig.webp",
            Preco =22.00,
            EntregaExpressa= true,
            DataCadastro = DateTime.Now
        },

        new Mercadoria
        {
            MercadoriaId = 4,
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

    public IList<Mercadoria> ObterTodos()
        => _Mercadorias;

    public Mercadoria Obter(int id)
        => ObterTodos().SingleOrDefault(item => item.MercadoriaId == id);

    public void Incluir(Mercadoria Mercadoria)
    {
        var proximoId = _Mercadorias.Max(item => item.MercadoriaId) + 1;
        Mercadoria.MercadoriaId = proximoId;
        _Mercadorias.Add(Mercadoria);
    }

    public void Alterar(Mercadoria Mercadoria)
    {
        var MercadoriaEncontrado = _Mercadorias.SingleOrDefault(item => item.MercadoriaId == Mercadoria.MercadoriaId);
        MercadoriaEncontrado.Nome = Mercadoria.Nome;
        MercadoriaEncontrado.Descricao = Mercadoria.Descricao;
        MercadoriaEncontrado.ImagemUri = Mercadoria.ImagemUri;
        MercadoriaEncontrado.Preco = Mercadoria.Preco;
        MercadoriaEncontrado.EntregaExpressa = Mercadoria.EntregaExpressa;
        MercadoriaEncontrado.DataCadastro = Mercadoria.DataCadastro;
    }

    public void Excluir(int id)
    {
        var MercadoriaEncontrado = Obter(id);
        _Mercadorias.Remove(MercadoriaEncontrado);
    }

    public IList<Marca> ObterTodasMarcas() => throw new NotImplementedException();

    public Marca ObterMarca(int id)
    {
        throw new NotImplementedException();
    }
}
