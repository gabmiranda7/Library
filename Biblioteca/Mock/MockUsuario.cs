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
    public class MockUsuario
    {
        public static void CarregaUsuario()
        {
            List<Usuario> oLista = new List<Usuario>();

            DataHelper.ListaUsuario = oLista;
        }
    }
}
