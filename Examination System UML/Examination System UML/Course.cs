using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public List<Exam> Exams { get; set; }

        public List<Topic> Topics { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
