using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Data.Interfaces;
using Biblioteca.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data.Repositories
{
    public class GeneroRepository : IGeneroRepository, IGeneroRespositoryAsync
    {
        private DBLivrariaContext DB;
        public GeneroRepository(DBLivrariaContext context)
        {
            DB = context;
        }
        public void Alterar(Genero oGenero)
        {
            DB.Entry(oGenero).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DB.SaveChanges();
        }

        public async Task AlterarAsync(Genero oGenero)
        {
            DB.Entry(oGenero).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await DB.SaveChangesAsync();
        }

        public void Excluir(Genero oGenero)
        {
            DB.Entry(oGenero).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            DB.SaveChanges();
        }

        public async Task ExcluirAsync(Genero oGenero)
        {
            DB.Entry(oGenero).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            await DB.SaveChangesAsync();
        }

        public void Incluir(Genero oGenero)
        {
            DB.Generos.Add(oGenero);
            DB.SaveChanges();
        }

        public async Task IncluirAsync(Genero oGenero)
        {
            DB.Generos.Add(oGenero);
            await DB.SaveChangesAsync();
        }

        public Genero? SelecionarPelaChave(int id)
        {
            //Forma Nº1
            return DB.Generos.Find(id);

            //Forma Nº2
            //return (from p in DB.Generos where p.Id == id select p).FirstOrDefault();

            //Forma Nº3
            //return (DB.Generos.Where(p=> p.Id == id)).FirstOrDefault();
        }

        public async Task<Genero?> SelecionaPelaChaveAsync(int id)
        {
            //Forma Nº1
            return await DB.Generos.FindAsync(id);

            //Forma Nº2
            //return await (from p in DB.Generos where p.Id == id select p).FirstOrDefaultAsync();

            //Forma Nº3
            //return await DB.Generos.Where(p=> p.Id == id).FirstOrDefaultAsync();
        }

        public List<Genero> SelecionarTodos()
        {
            //Forma Nº1
            return DB.Generos.OrderBy(p => p.Nome).ToList();

            //Forma Nº2
            //return (from p in DB.Generos orderby p.Nome select p).ToList();
        }

        public async Task<List<Genero>> SelecionarTodosAsync()
        {
            //Forma Nº1
            return await DB.Generos.OrderBy(p => p.Nome).ToListAsync();

            //Forma Nº2
            //return await (from p in DB.Generos orderby p.Nome select p).ToListAsync();
        }

        public void IncluirMultiplos(List<Genero> Lista)
        {
            DB.Generos.AddRange(Lista);
            DB.SaveChanges();
        }
    }
}