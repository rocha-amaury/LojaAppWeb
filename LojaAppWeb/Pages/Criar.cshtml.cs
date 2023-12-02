using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace LojaAppWeb.Pages;

public class CriarModel : PageModel
{

    public SelectList MarcaOptionItems { get; set; }

    private readonly IMercadoriaServico _service;
    private IToastNotification _toastNotification;

    public CriarModel(IMercadoriaServico service,
                        IToastNotification toastNotification)
    {
        _service = service;
        _toastNotification = toastNotification;
    }

    public void OnGet()
    {
        MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                            nameof(Marca.MarcaId),
                                            nameof(Marca.MarcaNome));
    }

    [BindProperty]
    public Mercadoria Mercadoria { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Incluir(Mercadoria);

        //TempData["TempMensagemSucesso"] = true;
        _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

        return RedirectToPage("/Index");
    }
}
