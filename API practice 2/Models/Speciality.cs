namespace API_practice_2.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public required ICollection<Group> Groups { get; set; }
    }
}
