using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data.Model;
using Biblioteca.Data.Interfaces;

namespace Biblioteca.Web.Pages.CadGenero
{
    public class DetailsModel : PageModel
    {
        private readonly IGeneroRespositoryAsync Repository;

        public DetailsModel(IGeneroRespositoryAsync generoRepositoryAsync)
        {
            Repository = generoRepositoryAsync;
        }

        public Genero Genero { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await Repository.SelecionaPelaChaveAsync(id.Value); //_context.Generos.FirstOrDefaultAsync(m => m.Id == id);
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
