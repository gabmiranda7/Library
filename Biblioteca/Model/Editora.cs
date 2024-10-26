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
    public class Editora
    {
        private int _Id;

        private string _Nome;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Editora> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = "SELECT id, Nome FROM Editora";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Editora oEditora = new Editora();
                    oEditora.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEditora.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oEditora);
                }
                oCn.Close();
                return Retorno;
            }
        }

        public static Editora? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaEditora where p.Id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirEditoraStatica(Editora oEditora)
        {
            Editora? aEditoraSelecionada = Editora.Seleciona(oEditora.Id);
            if (aEditoraSelecionada != null)
            {
                throw new Exception($"O Código informado está sendo utilizado na Editora {aEditoraSelecionada.Nome}");
            }
            else
            {
                DataHelper.ListaEditora.Add(oEditora);
            }

        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Editora VALUES('{this.Nome.Replace("'", "'")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static void Alterar(Editora oEditora)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Editora SET Nome='{oEditora.Nome.Replace("'", "'")}' WHERE id = {oEditora.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Editora WHERE id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}