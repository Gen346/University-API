using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_practice_2.Models
{
    [Table("specialities")]
    public class Speciality
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public required ICollection<Group> Groups { get; set; }
    }
}
