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
    public class MockAutor
    {
        public static void CarregaAutor()
        {
            List<Autor> oLista = new List<Autor>();

            DataHelper.ListaAutor = oLista;
        }
    }
}
