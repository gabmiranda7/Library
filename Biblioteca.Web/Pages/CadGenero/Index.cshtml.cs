using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data.Model;
using Biblioteca.Data.Repositories;
using Biblioteca.Data.Interfaces;

namespace Biblioteca.Web.Pages.CadGenero
{
    public class IndexModel : PageModel
    {
        private readonly IGeneroRespositoryAsync Repository;

        public IndexModel(IGeneroRespositoryAsync generoRepositoryAsync)
        {
            Repository = generoRepositoryAsync;
        }

        public IList<Genero> Genero { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Genero = await Repository.SelecionarTodosAsync();
        }
    }
}
