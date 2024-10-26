using System;
using System.Collections.Generic;

namespace Biblioteca.Data.Model;

public partial class LivroEmprestado
{
    public int IdLivro { get; set; }

    public int IdEmprestimo { get; set; }

    public DateOnly? DataEntrega { get; set; }

    public int? DiasAtraso { get; set; }

    public double? ValorMulta { get; set; }

    public double? ValorPago { get; set; }

    public virtual Emprestimo IdEmprestimoNavigation { get; set; } = null!;

    public virtual Livro IdLivroNavigation { get; set; } = null!;
}
