using System.ComponentModel.DataAnnotations;
using BumbaApiGraphQL.Models.Base;

namespace BumbaApiGraphQL.Models;

public class Utente : Pessoa
{
    public int MunicipioId { get; set; }
    public virtual Municipio? Municipio { get; set; }
}
