using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace LojaAppWeb.Pages;

[Authorize]
public class CriarModel : PageModel
{

    public SelectList MarcaOptionItems { get; set; }
    public SelectList CategoriaOptionItems { get; set; }

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

        CategoriaOptionItems = new SelectList(_service.ObterTodasCategorias(),
                        nameof(Categoria.CategoriaId),
                        nameof(Categoria.CategoriaNome));
    }

    [BindProperty]
    public Mercadoria Mercadoria { get; set; }

    [BindProperty]
    public IList<int> CategoriaIds { get; set; }

    public IActionResult OnPost()
    {
        Mercadoria.Categorias = _service.ObterTodasCategorias()
                                .Where(item => CategoriaIds.Contains(item.CategoriaId))
                                .ToList();

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
