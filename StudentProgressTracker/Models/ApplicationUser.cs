using Microsoft.AspNetCore.Identity;

namespace StudentProgressTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsAdmin { get; set; }
        public int? PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
