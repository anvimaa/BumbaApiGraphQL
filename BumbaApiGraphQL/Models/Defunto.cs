using BumbaApiGraphQL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Defunto : Pessoa
{
    [Required, MaxLength(150)]
    public string? NomeParente { get; set; }

    [MaxLength(150)]
    public string? TerminalParente { get; set; }

    public DateTime DataFalecimento { get; set; }
    public DateTime DataEnterro { get; set; }
    public int CemiterioId { get; set; }
    public virtual Cemiterio? Cemiterio { get; set; }
}
