using System;
using System.Collections.Generic;

namespace Biblioteca.Data.Model;

public partial class Configuracao
{
    public int Id { get; set; }

    public int QtsDiasEmprestimo { get; set; }

    public double ValorDiariasAtraso { get; set; }
}
