using System;
using System.Collections.Generic;

namespace Biblioteca.Data.Model;

public partial class Emprestimo
{
    public int Id { get; set; }

    public int IdPessoa { get; set; }

    public DateOnly DataSaida { get; set; }

    public DateOnly DataPrevistaEntrega { get; set; }

    public virtual Usuario IdPessoaNavigation { get; set; } = null!;

    public virtual ICollection<LivroEmprestado> LivroEmprestados { get; set; } = new List<LivroEmprestado>();
}
