using API_practice_2.Models;
using System.ComponentModel.DataAnnotations;

public class Faculty
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Speciality> Specialities { get; set; } = new List<Speciality>();
}
