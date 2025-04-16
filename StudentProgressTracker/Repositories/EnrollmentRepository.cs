using Microsoft.EntityFrameworkCore;
using StudentProgressTracker.Data;
using StudentProgressTracker.Interfaces;
using StudentProgressTracker.Models;

namespace StudentProgressTracker.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Enrollment> GetByIdAsync(int id) =>
            await _context.Enrollments.FindAsync(id);

        public async Task<IEnumerable<Enrollment>> GetAllAsync() =>
            await _context.Enrollments.ToListAsync();

        public async Task<IEnumerable<Enrollment>> GetByStudentIdAsync(int studentId) =>
            await _context.Enrollments
                .Where(sp => sp.StudentId == studentId)
                .ToListAsync();

        public async Task AddAsync(Enrollment progress)
        {
            _context.Enrollments.Add(progress);
        }

        public void UpdateAsync(Enrollment progress)
        {
            _context.Enrollments.Update(progress);
            //await _context.SaveChangesAsync();
        }

        public void DeleteAsync(Enrollment progress)
        {
            _context.Enrollments.Remove(progress);
            //await _context.SaveChangesAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
