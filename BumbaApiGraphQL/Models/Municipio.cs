using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Municipio
{
    public Municipio()
    {
        this.Utentes = new HashSet<Utente>();
    }

    [Key]
    public int Id { get; set; }

    [Required, MaxLength(128)]
    public string? Nome { get; set; }

    public int ProvinciaId { get; set; }
    public virtual Provincia? Provincia { get; set; }

    public virtual ICollection<Utente> Utentes { get; set; }
}
