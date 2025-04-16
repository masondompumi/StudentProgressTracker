using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentProgressTracker.Models;

namespace StudentProgressTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Seed();

            // Configure the relationship (one-to-one)
            //builder.Entity<ApplicationUser>()
            //       .HasOne(u => u.Person) // Navigation property
            //       .WithOne(p => p.User)  // Navigation property
            //       .HasForeignKey<ApplicationUser>(u => u.PersonId); //Foreign key

            // Add other configuration as needed
        }
    }
}
