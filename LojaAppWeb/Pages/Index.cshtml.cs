using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class IndexModel : PageModel
{
    public string BancoDeDados { get; set; }

    private readonly IProdutoServico _service;

    public IndexModel(IProdutoServico service, IConfiguration configuration)
    {
        BancoDeDados = configuration.GetConnectionString("MyConn");
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