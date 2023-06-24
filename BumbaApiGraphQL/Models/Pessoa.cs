using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Pessoa
{
    [Required, MaxLength(100)]
    public string? NomeCompleto { get; set; }

    [Required, MaxLength(100)]
    public string? TipoIdentidade { get; set; }

    [Required, MaxLength(14)]
    public string? NumeroIdentidade { get; set; }

    [Required, MaxLength(20)]
    public string? Genero { get; set; }

    [Required, MaxLength(250)]
    public string? Endereco { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }
    
    public DateTime DataCadastramento { get; set; }

}
