using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data.Model;
using Biblioteca.Data.Interfaces;

namespace Biblioteca.Web.Pages.CadGenero
{
    public class EditModel : PageModel
    {
        private readonly IGeneroRespositoryAsync Repository;
        public EditModel(IGeneroRespositoryAsync generoRepositoryAsync)
        {
            Repository = generoRepositoryAsync;
        }

        [BindProperty]
        public Genero Genero { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await Repository.SelecionaPelaChaveAsync(id.Value);
            if (genero == null)
            {
                return NotFound();
            }
            Genero = genero;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(Genero).State = EntityState.Modified;

            try
            {
                await Repository.AlterarAsync(Genero);
                //await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroExists(Genero.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GeneroExists(int id)
        {
            var obj = Repository.SelecionaPelaChaveAsync(id).Result;
            return obj != null; //_context.Generos.Any(e => e.Id == id);
        }
    }
}
