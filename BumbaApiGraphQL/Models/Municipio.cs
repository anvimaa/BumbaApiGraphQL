using BumbaApiGraphQL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Municipio : Bases
{
    public Municipio()
    {
        this.Utentes = new HashSet<Utente>();
        this.Cemiterios = new HashSet<Cemiterio>();
    }

    [Required, MaxLength(128)]
    public string? Nome { get; set; }

    public int ProvinciaId { get; set; }
    public virtual Provincia? Provincia { get; set; }

    public virtual ICollection<Utente> Utentes { get; set; }
    public virtual ICollection<Cemiterio> Cemiterios { get; set; }
}
