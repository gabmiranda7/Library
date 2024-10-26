using System;
using System.Collections.Generic;

namespace Biblioteca.Data.Model;

public partial class Livro
{
    public int Id { get; set; }

    public int IdIdioma { get; set; }

    public int IdGenero { get; set; }

    public int IdEditora { get; set; }

    public string Isbn { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int Edicao { get; set; }

    public int QtdPaginas { get; set; }

    public virtual Editora IdEditoraNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual ICollection<LivroEmprestado> LivroEmprestados { get; set; } = new List<LivroEmprestado>();

    public virtual ICollection<Autor> IdAutors { get; set; } = new List<Autor>();
}
