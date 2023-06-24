using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Provincia
{
    public Provincia()
    {
        this.Municipios = new HashSet<Municipio>();
    }

    [Key]
    public int Id { get; set; }

    [Required, MaxLength(128)]
    public string? Nome { get; set; }

    public virtual ICollection<Municipio> Municipios { get; set; }
}