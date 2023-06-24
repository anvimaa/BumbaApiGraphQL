using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Utente : Pessoa
{
    [Key]
    public int Id { get; set; }
    public int MunicipioId { get; set; }
    public virtual Municipio? Municipio { get; set; }
}
