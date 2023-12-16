using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class IndexModel : PageModel
{
    public string BancoDeDados { get; set; }

    private readonly IMercadoriaServico _service;

    public IndexModel(IMercadoriaServico service, IConfiguration configuration)
    {
        BancoDeDados = configuration.GetConnectionString("MyConn");
        _service = service;
    }

    public IList<Mercadoria> ListaMercadorias { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";
    
        ListaMercadorias = _service.ObterTodos();                
    }    

}