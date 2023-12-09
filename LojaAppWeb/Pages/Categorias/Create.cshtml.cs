using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LojaAppWeb.Data;
using LojaAppWeb.Models;
using NToastNotify;

namespace LojaAppWeb.Pages.Categorias
{
    public class CreateModel : PageModel
    {
        private readonly LojaAppWeb.Data.LojaDbContext _context;
        private IToastNotification _toastNotification;

        public CreateModel(LojaAppWeb.Data.LojaDbContext context,
                        IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Categoria Categoria { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Categoria == null || Categoria == null)
            {
                return Page();
            }

            _context.Categoria.Add(Categoria);
            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");
            return RedirectToPage("./Index");
        }
    }
}
