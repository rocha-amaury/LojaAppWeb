namespace LojaAppWeb.Models;

public class Marca
{
    public int MarcaId { get; set; }
    public string MarcaNome { get; set;}

    public ICollection<Mercadoria>? Mercadorias { get; set; }
}
