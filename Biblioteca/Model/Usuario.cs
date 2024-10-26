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
    public class Usuario
    {
        private int _Id;

        private string _Nome;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Usuario> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Usuario> Retorno = new List<Usuario>();
                string SQL = "SELECT id, Nome FROM Usuario";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oUsuario);
                }
                oCn.Close();
                return Retorno;
            }
        }

        public static Usuario? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaUsuario where p.Id == Codigo select p).FirstOrDefault();
        }


        public static void IncluirUsuarioStatico(Usuario oUsuario)
        {
            Usuario? oUsuarioSelecionado = Usuario.Seleciona(oUsuario.Id);
            if (oUsuarioSelecionado != null)
            {
                throw new Exception($"O Código informado está sendo utilizado no usuário {oUsuarioSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaUsuario.Add(oUsuario);
            }

        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Usuario VALUES('{this.Nome.Replace("'", "'")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static void Alterar(Usuario oUsuario)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Usuario SET Nome='{oUsuario.Nome.Replace("'", "'")}' WHERE id = {oUsuario.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Usuario WHERE id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}