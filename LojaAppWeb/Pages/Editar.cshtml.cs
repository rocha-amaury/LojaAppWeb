using LojaAppWeb.Models;
using LojaAppWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace LojaAppWeb.Pages
{
    [Authorize]
    public class EditarModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        public SelectList CategoriaOptionItems { get; set; }

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

        [BindProperty]
        public IList<int> CategoriaIds { get; set; }

        public IActionResult OnGet(int id)
        {
            Mercadoria = _service.Obter(id);

            CategoriaIds = Mercadoria.Categorias.Select(item => item.CategoriaId).ToList();

            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                    nameof(Marca.MarcaId),
                                    nameof(Marca.MarcaNome));

            CategoriaOptionItems = new SelectList(_service.ObterTodasCategorias(),
                        nameof(Categoria.CategoriaId),
                        nameof(Categoria.CategoriaNome));

            if (Mercadoria == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Mercadoria.Categorias = _service.ObterTodasCategorias()
                         .Where(item => CategoriaIds.Contains(item.CategoriaId))
                         .ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Mercadoria);

            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            _service.Excluir(Mercadoria.MercadoriaId);

            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

            return RedirectToPage("/Index");
        }
    }
}

