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
    public class MockGenero
    {
        public static void CarregaGenero()
        {
            List<Genero> oLista = new List<Genero>();

            DataHelper.ListaGenero = oLista;
        }
    }
}
