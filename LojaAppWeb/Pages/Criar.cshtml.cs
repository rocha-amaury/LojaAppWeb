using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojaAppWeb.Pages;

public class CriarModel : PageModel
{

    private readonly IProdutoServico _service;

    public CriarModel(IProdutoServico service)
    {
        _service = service;
    }
    
    [BindProperty]
    public Produto Produto { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Incluir(Produto);

        TempData["TempMensagemSucesso"] = true;

        return RedirectToPage("/Index");
    }
}
