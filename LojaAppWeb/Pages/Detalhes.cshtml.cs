using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class DetalhesModel : PageModel
{
    public Produto Produto { get; private set; }

    public void OnGet(int id)
    {
        var service = new ProdutoServico();
        Produto = service.Obter(id);

    }
}
