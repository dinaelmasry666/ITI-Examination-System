using ITI_Exams_API.Models;

namespace ITI_Exams_API.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();
        Task<object?> GetSingleStudent(int id);
        Task<List<Student>> AddStudent(Student Student);
        Task<List<Student>?> UpdateStudent(int id, Student request);
        Task<List<Student>?> DeleteStudent(int id);
    }
}
