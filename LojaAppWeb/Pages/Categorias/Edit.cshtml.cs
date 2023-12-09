using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LojaAppWeb.Data;
using LojaAppWeb.Models;
using NToastNotify;

namespace LojaAppWeb.Pages.Categorias
{
    public class EditModel : PageModel
    {
        private readonly LojaAppWeb.Data.LojaDbContext _context;
        private IToastNotification _toastNotification;

        public EditModel(LojaAppWeb.Data.LojaDbContext context,
                            IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        [BindProperty]
        public Categoria Categoria { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categoria == null)
            {
                return NotFound();
            }

            var categoria =  await _context.Categoria.FirstOrDefaultAsync(m => m.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound();
            }
            Categoria = categoria;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(Categoria.CategoriaId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");
            return RedirectToPage("./Index");
        }

        private bool CategoriaExists(int id)
        {
          return (_context.Categoria?.Any(e => e.CategoriaId == id)).GetValueOrDefault();
        }
    }
}
