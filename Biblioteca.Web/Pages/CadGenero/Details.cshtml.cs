using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data.Model;

namespace Biblioteca.Web.Pages.CadGenero
{
    public class DetailsModel : PageModel
    {
        private readonly Biblioteca.Data.Model.DBLivrariaContext _context;

        public DetailsModel(Biblioteca.Data.Model.DBLivrariaContext context)
        {
            _context = context;
        }

        public Genero Genero { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos.FirstOrDefaultAsync(m => m.Id == id);
            if (genero == null)
            {
                return NotFound();
            }
            else
            {
                Genero = genero;
            }
            return Page();
        }
    }
}
