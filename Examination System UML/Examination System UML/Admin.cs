using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Admin : Instructor
    {
        #region CUD operations
        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void AddQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public void AddInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void AddTopic(Topic topic)
        {
            throw new NotImplementedException();
        }


        public void UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(int id, Department department)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuestion(int id, Question question)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(int id, Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(int id, Course course)
        {
            throw new NotImplementedException();
        }

        public void UpdateTopic(int id, Topic topic)
        {
            throw new NotImplementedException();
        }


        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteInstructor(int id)
        {
            throw new NotImplementedException();
        }


        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }


        public void DeleteTopic(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Assign
        public void AssignAdmin(int instructorId) 
        {
            throw new NotImplementedException(); 
        }

        public void AssignInstrucor(int instructorId, int courseId)
        {
            throw new NotImplementedException();
        }

        public void AssignStudent(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Reports
        public void GenerateReportInstructorCourses(int instructorId)
        {
            throw new NotImplementedException();
        }

        public void GenerateReportCourseInstructors(int courseId)
        {
            throw new NotImplementedException();
        }

        public void GenerateReportStudentCourses(int studentId)
        {
            throw new NotImplementedException();
        }

        public void GenerateReportCourseStudents(int instructorId)
        {
            throw new NotImplementedException();
        }

        public void GenerateReportCourseTopics(int courseId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
