using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaAppWeb.Models;

//[Table("TBL_PRODUTO")]
public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage ="Campo 'Nome' obrigatório")]
    [StringLength(50, MinimumLength = 5, ErrorMessage ="Campo 'Nome' deve ter entre 5  e 50 caracteres.")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    //[Column("DESCRICAO")]
    [Required(ErrorMessage = "Campo 'Descrição' obrigatório")]
    [StringLength(100, MinimumLength = 5, ErrorMessage = "Campo 'Descrição' deve ter entre 5 e 100 caracteres.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Campo 'Caminho URL da imagem' obrigatório")]
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUri { get; set; }

    [Required(ErrorMessage = "Campo 'Preço' obrigatório")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    [Display(Name = "Entrega expressa")]
    public bool EntregaExpressa { get; set; }

    public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

    //[NotMapped]
    [Required(ErrorMessage = "Campo 'Disponível desde' obrigatório")]
    [Display(Name = "Disponível desde")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    [DataType("month")]
    public DateTime DataCadastro { get; set; }

}
