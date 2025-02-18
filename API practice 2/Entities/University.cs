using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_practice_2.Models
{
    [Table("universities")]
    public class University
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public required ICollection<Faculty> Faculties { get; set; } 
    }
}
