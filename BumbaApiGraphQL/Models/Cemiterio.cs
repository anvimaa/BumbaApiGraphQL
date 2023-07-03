using BumbaApiGraphQL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Cemiterio : Bases
{
    public Cemiterio()
    {
        this.Defuntos = new HashSet<Defunto>();
        this.Transladacaos = new HashSet<Transladacao>();
    }

    [Required, MaxLength(150)]
    public string? Nome { get; set; }

    [Required, MaxLength(150)]
    public string? Responsavel { get; set; }

    public int MunicipioId { get; set; }
    public virtual Municipio? Municipio { get; set; }
    public virtual ICollection<Defunto>? Defuntos { get; set; }
    public virtual ICollection<Transladacao>? Transladacaos { get; set; }
}
