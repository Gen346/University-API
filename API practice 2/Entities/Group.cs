using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_practice_2.Models
{
    [Table("groups")]
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Course { get; set; }
        public required ICollection<Student> Students { get; set; }
    }
}