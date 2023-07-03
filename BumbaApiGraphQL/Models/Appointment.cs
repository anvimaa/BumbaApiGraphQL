using System.ComponentModel.DataAnnotations;

namespace BumbaApiGraphQL.Models;

public class Appointment
{
    [Key]
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string? Text { get; set; }
}
