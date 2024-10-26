using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Mock;
using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace Biblioteca.Helper
{
    public static class DataHelper
    {
        public static List<Genero>? ListaGenero { get; set; }
        public static List<Autor>? ListaAutor { get; set; }
        public static List<Editora>? ListaEditora { get; set; }
        public static List<Idioma>? ListaIdioma { get; set; }
        public static List<Livro>? ListaLivro { get; set; }
        public static List<Usuario>? ListaUsuario { get; set; }

        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source=GABRIEL\\SQLEXPRESS;Initial Catalog=Livraria;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }
    }
}
