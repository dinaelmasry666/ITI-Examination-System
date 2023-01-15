using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Course> Courses { get; set; }

        /// <summary>
        /// This function should generate an exam randomly from pre-existing questions according to choosen course id.
        /// </summary>
        /// <param name="courseId"></param>
        /// <exception cref="NotImplementedException"></exception>
        void GenerateExam(int courseId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This function should ask the instructor if he wants to add assign an exam to a single or group of students, or he wants to asign it to all students in the course,
        /// and handel both cases.
        /// HANDEL EACH CASE IN A DIFFERENT *PRIVATE* FUNCTION
        /// </summary>
        /// <param name="examId"></param>
        /// <exception cref="NotImplementedException"></exception>
        void AssignExam(int examId)
        {
            throw new NotImplementedException();
        }
    }
}
