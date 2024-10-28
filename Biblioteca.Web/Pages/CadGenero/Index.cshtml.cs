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
    public class IndexModel : PageModel
    {
        private readonly Biblioteca.Data.Model.DBLivrariaContext _context;

        public IndexModel(Biblioteca.Data.Model.DBLivrariaContext context)
        {
            _context = context;
        }

        public IList<Genero> Genero { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Genero = await _context.Generos.ToListAsync();
        }
    }
}
