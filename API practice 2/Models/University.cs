using System.ComponentModel.DataAnnotations;

namespace API_practice_2.Models
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public required ICollection<Faculty> Faculties { get; set; } 
    }
}
