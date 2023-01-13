using ITI_Exams_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_Exams_API.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> AddStudent(Student Student)
        {
            await _context.Students.AddAsync(Student);
            _context.SaveChanges();
            return await _context.Students.ToListAsync();

        }

        public async Task<List<Student>?> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<object?> GetSingleStudent(int id)
        {
            //var tmp = await _context.Students.Where((s) => s.Id == id).FirstOrDefaultAsync();
            var tmp = await (from st in _context.Students join dep in _context.Departments
                             on st.DepartmentId equals dep.Id
                             where st.Id == id
                             select new {
                                 Name =st.Fname+' '+st.Lname,
                                 st.Gender,
                                 st.GradYear,
                                 st.University,
                                 st.Address,
                                 DepartmentName = dep.Name
                             }).FirstOrDefaultAsync();
            if(tmp == null)
                return null;
            
            return tmp;
        }

        public async Task<List<Student>?> UpdateStudent(int id, Student request)
        {
            throw new NotImplementedException();
        }
    }
}
