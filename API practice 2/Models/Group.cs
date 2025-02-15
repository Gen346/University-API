namespace API_practice_2.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Course { get; set; }
        public required ICollection<Student> Students { get; set; }
    }
}