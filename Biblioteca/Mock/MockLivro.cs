using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Mock;
using Biblioteca.Model;
using Biblioteca.Helper;

namespace Biblioteca.Mock
{
    public class MockLivro
    {
        public static void CarregaLivro()
        {
            List<Livro> oLista = new List<Livro>();

            DataHelper.ListaLivro = oLista;
        }
    }
}
