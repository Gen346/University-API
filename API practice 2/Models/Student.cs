namespace API_practice_2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public int YearOfBegin {  get; set; }
        public int YearOfEnd { get; set; }
        public string? FormOfFinancing {  get; set; }
        public List<int> Grades { get; set; } = new();
    }
}