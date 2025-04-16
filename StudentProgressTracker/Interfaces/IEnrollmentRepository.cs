using StudentProgressTracker.Models;

namespace StudentProgressTracker.Interfaces
{
    public interface IEnrollmentRepository
    {
        //Task<Enrollment> GetByStudentIdAsync(int id);
        Task<IEnumerable<Enrollment>> GetAllAsync();

        Task<IEnumerable<Enrollment>> GetByStudentIdAsync(int id);
        Task AddAsync(Enrollment student);
        void UpdateAsync(Enrollment student);
        void DeleteAsync(Enrollment student);
        Task<bool> SaveChangesAsync();
    }
}
