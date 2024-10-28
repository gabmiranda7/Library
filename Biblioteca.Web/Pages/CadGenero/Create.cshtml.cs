using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Biblioteca.Data.Model;
using Biblioteca.Data.Interfaces;

namespace Biblioteca.Web.Pages.CadGenero
{
    public class CreateModel : PageModel
    {
        private readonly IGeneroRespositoryAsync Repository;

        public CreateModel(IGeneroRespositoryAsync generoRepositoryAsync)
        {
            Repository = generoRepositoryAsync;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Genero Genero { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await Repository.IncluirAsync(Genero);

            //_context.Generos.Add(Genero);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
