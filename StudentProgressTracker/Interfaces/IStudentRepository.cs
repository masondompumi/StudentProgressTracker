using StudentProgressTracker.Models;

namespace StudentProgressTracker.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> GetByIdAsync(int id);
        Task<IEnumerable<Student>> GetAllAsync();

        Task AddAsync(Student student);
        void UpdateAsync(Student student);
        void DeleteAsync(Student student);
        Task<bool> SaveChangesAsync();
    }
}
