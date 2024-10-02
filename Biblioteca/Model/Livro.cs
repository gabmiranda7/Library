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
    public class Livro
    {
        private int _id;
        private string _Nome;
        private int _idEditora;
        private int _idGenero;
        private int _idIdioma;
        private string _ISBN;
        private string _Descricao;
        private int _Edicao;
        private int _QtdPaginas;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get => _Nome;
            set => _Nome = value.Replace("'", " ");
        }

        public int IdEditora
        {
            get { return _idEditora; }
            set { _idEditora = value; }
        }

        public int IdGenero
        {
            get { return _idGenero; }
            set { _idGenero = value; }
        }

        public int IdIdioma
        {
            get { return _idIdioma; }
            set { _idIdioma = value; }
        }

        public string ISBN
        {
            get => _ISBN;
            set => _ISBN = value.Replace("'", " ");
        }

        public string Descricao
        {
            get => _Descricao;
            set => _Descricao = value.Replace("'", " ");
        }

        public int Edicao
        {
            get => _Edicao;
            set => _Edicao = value;
        }

        public int QtdPaginas
        {
            get => _QtdPaginas;
            set => _QtdPaginas = value;
        }
        public static List<Livro> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = "SELECT Id, Nome, IdEditora, IdGenero, IdIdioma, ISBN, Descricao, Edicao, QtdPaginas FROM Livro";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Livro oLivro = new Livro();
                    oLivro.Id = oDr.GetInt32(oDr.GetOrdinal("Id"));
                    oLivro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oLivro.IdEditora = oDr.GetInt32(oDr.GetOrdinal("IdEditora"));
                    oLivro.IdGenero = oDr.GetInt32(oDr.GetOrdinal("IdGenero"));
                    oLivro.IdIdioma = oDr.GetInt32(oDr.GetOrdinal("IdIdioma"));
                    oLivro.ISBN = oDr.GetString(oDr.GetOrdinal("ISBN"));
                    oLivro.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    oLivro.Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao"));
                    oLivro.QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas"));
                    Retorno.Add(oLivro);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Livro? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT Id, Nome, IdEditora, IdGenero, IdIdioma, ISBN, Descricao, Edicao, QtdPaginas FROM Livro WHERE Id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    Livro oLivro = new Livro();
                    oLivro.Id = oDr.GetInt32(oDr.GetOrdinal("Id"));
                    oLivro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    oLivro.IdEditora = oDr.GetInt32(oDr.GetOrdinal("IdEditora"));
                    oLivro.IdGenero = oDr.GetInt32(oDr.GetOrdinal("IdGenero"));
                    oLivro.IdIdioma = oDr.GetInt32(oDr.GetOrdinal("IdIdioma"));
                    oLivro.ISBN = oDr.GetString(oDr.GetOrdinal("ISBN"));
                    oLivro.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    oLivro.Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao"));
                    oLivro.QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas"));
                    return oLivro;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                if (string.IsNullOrEmpty(this.Nome))
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

                string SQL = $"INSERT INTO Livro (Nome, IdEditora, IdGenero, IdIdioma, ISBN, Descricao, Edicao, QtdPaginas) " +
                             $"VALUES ('{this.Nome.Replace("'", "")}', {this.IdEditora}, {this.IdGenero}, {this.IdIdioma}, " +
                             $"'{this.ISBN.Replace("'", "")}', '{this.Descricao.Replace("'", "")}', {this.Edicao}, " +
                             $"{this.QtdPaginas})";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Livro oLivro)
        {
            using (var oCn = DataHelper.Conexao())
            {
                if (string.IsNullOrEmpty(oLivro.Nome))
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

                string SQL = $"UPDATE Livro SET Nome = '{oLivro.Nome.Replace("'", "")}', " +
                             $"IdEditora = {oLivro.IdEditora}, IdGenero = {oLivro.IdGenero}, IdIdioma = {oLivro.IdIdioma}, " +
                             $"ISBN = '{oLivro.ISBN.Replace("'", "")}', Descricao = '{oLivro.Descricao.Replace("'", "")}', " +
                             $"Edicao = {oLivro.Edicao}, QtdPaginas = {oLivro.QtdPaginas} " +
                             $"WHERE Id = {oLivro.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Livro WHERE Id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
