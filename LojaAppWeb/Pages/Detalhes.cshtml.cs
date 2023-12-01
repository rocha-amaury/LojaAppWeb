using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class DetalhesModel : PageModel
{

    private readonly IMercadoriaServico _service;

    public string MarcaNome { get; set; }   

    public DetalhesModel(IMercadoriaServico service)
    {
        _service = service;
    }

    public Mercadoria Mercadoria { get; private set; }

    //public void OnGet(int id)
    //{
    //    var service = new MercadoriaServico();
    //    Mercadoria = service.Obter(id);

    //}

    public IActionResult OnGet(int id)
    {
        Mercadoria = _service.Obter(id);
        if (Mercadoria.MarcaId is not null)
        { 
            MarcaNome = _service.ObterMarca(Mercadoria.MarcaId.Value).MarcaNome;
        }

        if (Mercadoria == null)
        {
            return NotFound();
        }
        return Page();
    }
}
