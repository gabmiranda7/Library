using System;
using System.Collections.Generic;

namespace Biblioteca.Data.Model;

public partial class Idioma
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
