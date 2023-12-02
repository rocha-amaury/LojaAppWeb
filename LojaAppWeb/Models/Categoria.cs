namespace LojaAppWeb.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string CategoriaNome { get; set; }
    public ICollection<Mercadoria>? Mercadorias { get; set; }

}
