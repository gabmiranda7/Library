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
    public class MockEditora
    {
        public static void CarregaEditora()
        {
            List<Editora> oLista = new List<Editora>();

            DataHelper.ListaEditora = oLista;
        }
    }
}
