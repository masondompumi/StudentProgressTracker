namespace StudentProgressTracker.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
