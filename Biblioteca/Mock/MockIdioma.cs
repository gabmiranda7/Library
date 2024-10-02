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
    public class MockIdioma
    {
        public static void CarregaIdioma()
        {
            List<Idioma> oLista = new List<Idioma>();

            DataHelper.ListaIdioma = oLista;
        }
    }
}
