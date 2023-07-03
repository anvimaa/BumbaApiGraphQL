using BumbaApiGraphQL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Provincia : Bases
{
    public Provincia()
    {
        this.Municipios = new HashSet<Municipio>();
    }

    [Required, MaxLength(128)]
    public string? Nome { get; set; }

    public virtual ICollection<Municipio>? Municipios { get; set; }
}
