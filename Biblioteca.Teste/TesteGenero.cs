using Biblioteca.Data;
using Biblioteca.Data.Repositories;
using Biblioteca.Data.Model;
using Microsoft.Identity.Client;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Teste
{
    public class TesteGenero
    {
        DBLivrariaContext? DB;
        GeneroRepository _Repository;

        [SetUp]
        public void Setup()
        {
            DB = new DBLivrariaContext();
            _Repository = new GeneroRepository(DB);
        }

        [Test]
        //Inclus�o de um g�nero, com o nome Teste
        public void IncluirGenero()
        {
            Genero oGenero = new Genero();
            oGenero.Nome = "Genero";
            _Repository.Incluir(oGenero);
            Assert.Pass("G�nero inclu�do com sucesso!");
        }

        [Test]
        public async Task IncluirGeneroAsync()
        {
            Genero oGenero = new Genero();
            oGenero.Nome = $"Async {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
            await _Repository.IncluirAsync(oGenero);
            Assert.Pass("G�nero inclu�do com sucesso!");
        }

        [Test]
        //Incluir m�ltiplos g�neros, adicionando um nome padr�o a eles
        public void IncluirMultiplos()
        {
            List<Genero> Lista = new List<Genero>();
            for (int i = 1; i <= 100; i++)
            {
                Genero oGenero = new Genero();
                oGenero.Nome = $"G�nero {i}";
                Lista.Add(oGenero);
            }
            _Repository.IncluirMultiplos(Lista);
            Assert.Pass("G�neros inclu�dos com sucesso!");
        }

        [Test]
        //Alterar G�nero, incluindo a data e a hora que o teste foi feito
        public void AlterarGenero()
        {
            var obj = _Repository.SelecionarPelaChave(1);
            string data = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            if (obj != null)
            {
                obj.Nome = $"Teste de Altera��o {data}";
                _Repository.Alterar(obj);
                Assert.Pass("G�nero alterado com sucesso!");
            }
            else
            {
                Assert.Fail("G�nero n�o encontrado.");
            }

            //public void AlterarGenero()
            //{
            //    var obj = _Repository.SelecionaPelaChave(2);
            //    if (obj != null)
            //    {
            //        obj.Nome = obj.Nome + "1";
            //        _Repository.Alterar(obj);
            //        Assert.Pass("G�nero alterado com sucesso!");
            //    }
            //    else
            //    {
            //        Assert.Fail("G�nero n�o encontrado.");
            //    }
            //}
        }

        [Test]
        //Exclui o �ltimo g�nero, usando OrderBy
        public void ExcluirGenero()
        {
            Genero oGenero = DB.Generos.OrderBy(p => p.Id).Last();
            _Repository.Excluir(oGenero);
            Assert.Pass("G�nero exclu�do com suceso!");
        }

        [Test]
        //Selecionar um g�nero pelo seu ID, mostrando-o junto ao nome
        public void SelecionarChaveGenero()
        {
            var obj = _Repository.SelecionarPelaChave(1);
            Assert.Pass($"ID: {obj.Id} Nome: {obj.Nome}");
        }

        [Test]
        //Realiza a contagem de quantos g�neros existem no Database
        public void SelecionarTodosGenero()
        {
            var Lista = _Repository.SelecionarTodos();
            Assert.Pass($"Total de Registros: {Lista.Count}");
        }

        //public void SelecionarTodosGenero()
        //{
        //    var Lista = _Repository.SelecionarTodos();
        //    Assert.Pass($"Total de Registros: {Lista.Count}");
        //}

        //[Test]
        //public void ExcluirGenero()
        //{
        //    Genero oGenero = DB.Generos.OrderBy(p => p.Id).Last();
        //    _Repository.Excluir(oGenero);
        //    Assert.Pass();
        //}

        [Test]
        //Limpa todos os arquivos do Banco de Dados
        public void LimparBancoCompleto()
        {
            DB.Generos.RemoveRange(DB.Generos);
            DB.SaveChanges();
            Assert.Pass("Base de dados limpa com sucesso!");
        }

        [Test]
        // Resetando o campo Idnetity da tabela G�nero
        public void ResetIdentity()
        {
            DB.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('Genero', RESEED, 0);");
            Assert.Pass("Campo ID (Identity) resetado com suceso!");
        }
    }
}