using System.ComponentModel.DataAnnotations;
using BumbaApiGraphQL.Models.Base;

namespace BumbaApiGraphQL.Models;

public class Transladacao : Bases
{
    [Required]
    public int Idade { get; set; }
    [Required, MaxLength(150)]
    public string? Nome { get; set; }
    public string? Responsavel { get; set; }
    public string? Genero { get; set; }
    public DateTime DataFalecimento { get; set; }
    public DateTime DataEnterro { get; set; }
    public decimal ValorPago { get; set; }
    public bool IsTransladacao { get; set; }
    public int CemiterioId { get; set; }
    public virtual Cemiterio? Cemiterio { get; set; }
}
