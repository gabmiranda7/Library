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
    public class Idioma
    {
        private int _Id;

        private string _Nome;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Idioma> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = "SELECT id, Nome FROM Idioma";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Idioma oIdioma = new Idioma();
                    oIdioma.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oIdioma);
                }
                oCn.Close();
                return Retorno;
            }
        }

        public static Idioma? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaIdioma where p.Id == Codigo select p).FirstOrDefault();
        }


        public static void IncluirIdiomaStatico(Idioma oIdioma)
        {
            Idioma? oIdiomaSelecionado = Idioma.Seleciona(oIdioma.Id);
            if (oIdiomaSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo utilizado no idioma {oIdiomaSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaIdioma.Add(oIdioma);
            }

        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Idioma VALUES('{this.Nome.Replace("'", "'")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static void Alterar(Idioma oIdioma)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE  Idioma SET Nome='{oIdioma.Nome.Replace("'", "'")}' WHERE id = {oIdioma.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Idioma WHERE id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}