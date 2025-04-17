using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentProgressTracker.Models;

namespace StudentProgressTracker.Data
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder builder)
        {
            var pwd = "Test@123";
            var passwordHarsher = new PasswordHasher<IdentityUser>();
            // Seed Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole { Id = "3", Name = "Viewer", NormalizedName = "VIEWER" }
                
            );

            // Seed People
            builder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Alice", LastName = "Admin", StudentId = 1 },
                new Person { Id = 2, FirstName = "Bob", LastName = "Brown", StudentId = 2 },
                new Person { Id = 3, FirstName = "Charlie", LastName = "Clark", StudentId = 3 },
                new Person { Id = 4, FirstName = "Diana", LastName = "Doe", StudentId = 4 },
                new Person { Id = 5, FirstName = "Evan", LastName = "Evans", StudentId = 5 },
                new Person { Id = 6, FirstName = "Viewer", LastName = "Evans",  }
            );

            // Seed Students
            builder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Alice", LastName= "A", Email = "alice@domain.com", IdNumber = 101 },
                new Student { Id = 2, FirstName = "Bob", LastName= " B", Email = "bob@domain.com", IdNumber = 102 },
                new Student { Id = 3, FirstName = "Charlie", LastName= "C", Email = "bob@domain.com", IdNumber = 103 },
                new Student { Id = 4, FirstName = "Diana", LastName= "D", Email = "charlie@domain.com", IdNumber = 104 },
                new Student { Id = 5, FirstName = "Evan", LastName = "E", Email = "diana@domain.com", IdNumber = 105 }
            );

            // Seed Users
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "user-1",
                    UserName = "alice@domain.com",
                    NormalizedUserName = "ALICE@DOMAIN.COM",
                    Email = "alice@domain.com",
                    NormalizedEmail = "ALICE@DOMAIN.COM",
                    EmailConfirmed = true,
                    IsAdmin = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAIAAYagAAAAEBlyyP/QKMTOX+rdR2NFODOTEAmtSheGfGn+PS+ZMqeksHcGdFW02yY2iCh5ELBHrQ=="
                },
                new ApplicationUser
                {
                    Id = "user-6",
                    UserName = "alice1@domain.com",
                    NormalizedUserName = "ALICE1@DOMAIN.COM",
                    Email = "alice1@domain.com",
                    NormalizedEmail = "ALICE1@DOMAIN.COM",
                    EmailConfirmed = true,
                    PersonId = 6,
                    IsAdmin = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAIAAYagAAAAEBlyyP/QKMTOX+rdR2NFODOTEAmtSheGfGn+PS+ZMqeksHcGdFW02yY2iCh5ELBHrQ=="
                },
                new ApplicationUser
                {
                    Id = "user-2",
                    UserName = "bob@domain.com",
                    NormalizedUserName = "BOB@DOMAIN.COM",
                    Email = "bob@domain.com",
                    NormalizedEmail = "BOB@DOMAIN.COM",
                    EmailConfirmed = true,
                    PersonId = 2,
                    IsAdmin = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAIAAYagAAAAEBlyyP/QKMTOX+rdR2NFODOTEAmtSheGfGn+PS+ZMqeksHcGdFW02yY2iCh5ELBHrQ=="
                },
                new ApplicationUser
                {
                    Id = "user-3",
                    UserName = "charlie@domain.com",
                    NormalizedUserName = "CHARLIE@DOMAIN.COM",
                    Email = "charlie@domain.com",
                    NormalizedEmail = "CHARLIE@DOMAIN.COM",
                    EmailConfirmed = true,
                    PersonId = 3,
                    IsAdmin = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAIAAYagAAAAEBlyyP/QKMTOX+rdR2NFODOTEAmtSheGfGn+PS+ZMqeksHcGdFW02yY2iCh5ELBHrQ=="
                },
                new ApplicationUser
                {
                    Id = "user-4",
                    UserName = "diana@domain.com",
                    NormalizedUserName = "DIANA@DOMAIN.COM",
                    Email = "diana@domain.com",
                    NormalizedEmail = "DIANA@DOMAIN.COM",
                    EmailConfirmed = true,
                    PersonId = 4,
                    IsAdmin = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAIAAYagAAAAEBlyyP/QKMTOX+rdR2NFODOTEAmtSheGfGn+PS+ZMqeksHcGdFW02yY2iCh5ELBHrQ=="
                },
                new ApplicationUser
                {
                    Id = "user-5",
                    UserName = "evan@domain.com",
                    NormalizedUserName = "EVAN@DOMAIN.COM",
                    Email = "evan@domain.com",
                    NormalizedEmail = "EVAN@DOMAIN.COM",
                    EmailConfirmed = true,
                    PersonId = 5,
                    IsAdmin = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAIAAYagAAAAEBlyyP/QKMTOX+rdR2NFODOTEAmtSheGfGn+PS+ZMqeksHcGdFW02yY2iCh5ELBHrQ=="
                }
            );

            // User Roles
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "user-1", RoleId = "1" }, // Admin
                new IdentityUserRole<string> { UserId = "user-2", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "user-3", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "user-4", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "user-5", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "user-6", RoleId = "3" }
            );

            // Seed Enrollments: 2 per student
            int enrollmentId = 1;
            for (int studentId = 1; studentId <= 5; studentId++)
            {
                builder.Entity<Enrollment>().HasData(
                    new Enrollment
                    {
                        Id = enrollmentId++,
                        Institution = $"University {studentId}A",
                        Qualification = $"Degree A{studentId}",
                        QualificationType = "PostGraduation",
                        EnrolmentDate = new DateTime(2022, 9, 1),
                        AverageToDate = 72.5f,
                        StudentId = studentId
                    },
                    new Enrollment
                    {
                        Id = enrollmentId++,
                        Institution = $"University {studentId}B",
                        Qualification = $"Degree B{studentId}",
                        QualificationType = "Honors",
                        EnrolmentDate = new DateTime(2023, 1, 15),
                        AverageToDate = 81.3f,
                        StudentId = studentId
                    }
                );
            }
        }

    }
}
