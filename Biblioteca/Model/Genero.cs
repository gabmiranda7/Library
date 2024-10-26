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
    public class Genero
    {
        private int _Id;

        private string _Nome;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Genero> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Genero> Retorno = new List<Genero>();
                string SQL = "SELECT id, Nome FROM Genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Genero oGenero = new Genero();
                    oGenero.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oGenero);
                }
                oCn.Close();
                return Retorno;
            }
        }

        public static Genero? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.Id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirGeneroStatico(Genero oGenero)
        {
            Genero? oGeneroSelecionado = Genero.Seleciona(oGenero.Id);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo utilizado no Gênero {oGeneroSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaGenero.Add(oGenero);
            }

        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Genero VALUES('{this.Nome.Replace("'", "'")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static void Alterar(Genero oGenero)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE  Genero SET Nome='{oGenero.Nome.Replace("'", "'")}' WHERE id = {oGenero.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Genero WHERE id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}