using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Data.Model;

namespace Biblioteca.Data.Interfaces
{
    public interface IGeneroRepository
    {
        void Incluir(Genero oGenero);
        void Alterar(Genero oGenero);
        void Excluir(Genero oGenero);
        Genero? SelecionaPelaChave(int id);
        List<Genero> SelecionarTodos();
    }
}
