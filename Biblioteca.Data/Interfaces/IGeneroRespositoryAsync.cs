using Biblioteca.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data.Interfaces
{
    public interface IGeneroRespositoryAsync
    {
        Task IncluirAsync(Genero oGenero);
        Task AlterarAsync(Genero oGenero);
        Task ExcluirAsync(Genero oGenero);
        Task<Genero?> SelecionaPelaChaveAsync(int id);
        Task<List<Genero>> SelecionarTodosAsync();
    }
}
