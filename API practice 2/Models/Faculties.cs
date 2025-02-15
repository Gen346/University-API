namespace API_practice_2.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public required ICollection<Speciality> Specialities { get; set; }
    }
}
