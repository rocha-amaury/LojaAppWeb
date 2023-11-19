using System.ComponentModel.DataAnnotations;

namespace LojaAppWeb.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Display(Name = "Descrição")]
    public string Descricao { get; set; }
    
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUri { get; set; }

    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    [Display(Name = "Entrega expressa")]
    public bool EntregaExpressa { get; set; }

    public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

    [Display(Name = "Disponível desde")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    public DateTime DataCadastro { get; set; }

}
