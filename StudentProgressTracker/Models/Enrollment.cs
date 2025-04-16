using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentProgressTracker.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Qualification { get; set; }
        public string QualificationType { get; set; }
        public DateTime EnrolmentDate { get; set; }
        public float AverageToDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
