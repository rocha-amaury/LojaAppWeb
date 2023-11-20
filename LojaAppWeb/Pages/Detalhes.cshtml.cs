using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class DetalhesModel : PageModel
{

    private readonly IProdutoServico _service;

    public DetalhesModel(IProdutoServico service)
    {
        _service = service;
    }

    public Produto Produto { get; private set; }

    //public void OnGet(int id)
    //{
    //    var service = new ProdutoServico();
    //    Produto = service.Obter(id);

    //}

    public IActionResult OnGet(int id)
    {
        Produto = _service.Obter(id);

        if (Produto == null)
        {
            return NotFound();
        }
        return Page();
    }
}
