using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentProgressTracker.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int IdNumber { get; set; }
        public byte[]? ProfileImage { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new();
    }
}
