using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace LojaAppWeb.Pages
{
    public class EditarModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }

        private readonly IMercadoriaServico _service;
        private IToastNotification _toastNotification;

        public EditarModel(IMercadoriaServico service,
                            IToastNotification toastNotification)
        {
            _service = service;
            _toastNotification = toastNotification;
        }

        [BindProperty]
        public Mercadoria Mercadoria { get; set; }

        public IActionResult OnGet(int id)
        {
            Mercadoria = _service.Obter(id);

            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                    nameof(Marca.MarcaId),
                                    nameof(Marca.MarcaNome));

            if (Mercadoria == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Mercadoria);

            //TempData["TempMensagemSucesso"] = true;
            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            _service.Excluir(Mercadoria.MercadoriaId);

            //TempData["TempMensagemSucesso"] = true;
            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

            return RedirectToPage("/Index");
        }
    }
}

