using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojaAppWeb.Data;
using LojaAppWeb.Models;

namespace LojaAppWeb.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly LojaAppWeb.Data.LojaDbContext _context;

        public IndexModel(LojaAppWeb.Data.LojaDbContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categoria != null)
            {
                Categoria = await _context.Categoria.ToListAsync();
            }
        }
    }
}
