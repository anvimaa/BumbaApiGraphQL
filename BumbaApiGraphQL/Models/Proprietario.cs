using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Proprietario : Pessoa
{
    [Key]
    public int Id { get; set; }
}
