using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentProgressTracker.Data;
using StudentProgressTracker.Interfaces;
using StudentProgressTracker.Models;

namespace StudentProgressTracker.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Student> GetByIdAsync(int id) {
            
           return await _context.Students.FindAsync(id);
        }


        //public async Task<Student>> GetByStudentIdAsync(int studentId) =>
        //    await _context.Students
        //        .Where(sp => sp.Id == studentId)
        //        .ToListAsync();

        public async Task<IEnumerable<Student>> GetAllAsync() =>
            await _context.Students.ToListAsync();

        public async Task AddAsync(Student progress)
        {
            _context.Students.Add(progress);
        }

        public void UpdateAsync(Student progress)
        {
            _context.Students.Update(progress);
            //await _context.SaveChangesAsync();
        }

        public void DeleteAsync(Student progress)
        {
            _context.Students.Remove(progress);
            //await _context.SaveChangesAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
