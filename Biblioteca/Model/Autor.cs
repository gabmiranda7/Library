using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Helper;
using Biblioteca.Model;
using Biblioteca.Mock;
using Microsoft.Data.SqlClient;

namespace Biblioteca.Model
{
    public class Autor
    {
        private int _Id;

        private string _Nome;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Autor> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Autor> Retorno = new List<Autor>();
                string SQL = "SELECT id, Nome FROM Autor";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Autor oAutor = new Autor();
                    oAutor.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oAutor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oAutor);
                }
                oCn.Close();
                return Retorno;
            }
        }

        public static Autor? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaAutor where p.Id == Codigo select p).FirstOrDefault();
        }


        public static void IncluirAutorStatico(Autor oAutor)
        {
            Autor? oAutorSelecionado = Autor.Seleciona(oAutor.Id);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo utilizado no Autor {oAutorSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaAutor.Add(oAutor);
            }

        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Autor VALUES('{this.Nome.Replace("'", "'")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static void Alterar(Autor oAutor)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Autor SET Nome='{oAutor.Nome.Replace("'", "'")}' WHERE id = {oAutor.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Autor WHERE id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}