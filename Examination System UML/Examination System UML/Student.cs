using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Student : Person
    {
        public string Phone { get; set; }

        public string Address { get; set; }

        public Department Department { get; set; }

        public List<Course> Courses { get; set; }

        public List<StudentExam> Exams { get; set; }

        public int TakeExam(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tuple<string, double>> GetGrades()
        {
            throw new NotImplementedException();
        }

        public Tuple<string, double> GetGrade(int id)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
