using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class IndexModel : PageModel
{

    public IList<Produto> ListaProdutos { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        var service = new ProdutoServico();
        
        ListaProdutos = service.ObterTodos();
                
    }    

}