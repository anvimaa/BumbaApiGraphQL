using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models.Base;

public class Bases
{
    [Key]
    public int Id { get; set; }
    public DateTime DataCadastramento { get; set; } = DateTime.Now;
}
