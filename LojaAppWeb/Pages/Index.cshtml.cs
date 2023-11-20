using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class IndexModel : PageModel
{
    private readonly IProdutoServico _service;

    public IndexModel(IProdutoServico service)
    {
        _service = service;
    }

    public IList<Produto> ListaProdutos { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        //var service = new ProdutoServico();        
        ListaProdutos = _service.ObterTodos();
                
    }    

}