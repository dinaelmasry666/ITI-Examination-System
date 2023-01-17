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
            if (!Program.Students.Contains(student))
            {
                Program.Students.Add(student);
            }
            else
            {
                Console.WriteLine("This student is already exists");
            }
        }

        public void AddDepartment(Department department)
        {
            if (!Program.Departments.Contains(department))
            {
                Program.Departments.Add(department);
            }
            else
            {
                Console.WriteLine("This Department is already exists");
            }
        }

        public void AddQuestion(Question question)
        {
            if (!Program.Questions.Contains(question))
            {
                Program.Questions.Add(question);
            }
            else
            {
                Console.WriteLine("This question is already exists");
            }
        }

        public void AddInstructor(Instructor instructor)
        {
            if (!Program.Instructors.Contains(instructor))
            {
                Program.Instructors.Add(instructor);
            }
            else
            {
                Console.WriteLine("This instructor is already exists");
            }
        }

        public void AddCourse(Course course)
        {
            if (!Program.Courses.Contains(course))
            {
                Program.Courses.Add(course);
            }
            else
            {
                Console.WriteLine("This course is already exists");
            }
        }

        public void AddTopic(Topic topic)
        {
            if (!Program.Topics.Contains(topic))
            {
                Program.Topics.Add(topic);
            }
            else
            {
                Console.WriteLine("This topic is already exists");
            }
        }


        public void UpdateStudent(int id, Student student)
        {
            Student st = Program.Students.Where((s) => s.Id == id).SingleOrDefault();
            st.Phone = student.Phone;
            st.Courses = student.Courses;
            st.Address = student.Address;
            st.Department = student.Department;
            st.FirstName = student.FirstName;
            st.LastName = student.LastName;
            st.Exams = student.Exams;
            //st.userName = student.userName;
            //st.password = student.password;
        }

        public void UpdateDepartment(int id, Department department)
        {
            Department dt = Program.Departments.Where((d) => d.Id == id).SingleOrDefault();
            dt.Manager = department.Manager;
            dt.Name = department.Name;

        }

        public void UpdateQuestion(int id, Question question)
        {
            Question qs = Program.Questions.Where((q) => q.Id == id).SingleOrDefault();
            qs.Statement = question.Statement;
            qs.Answer = question.Answer;
            qs.Choices = question.Choices;
            qs.Type = question.Type;
        }

        public void UpdateInstructor(int id, Instructor instructor)
        {
            Instructor ins = Program.Instructors.Where((i) => i.Id == id).SingleOrDefault();
            ins.Courses = instructor.Courses;
            ins.Department = instructor.Department;
            ins.LastName = instructor.LastName;
            ins.FirstName = instructor.FirstName;
            //ins.userName = instructor.userName;
            //ins.password = instructor.password;
        }

        public void UpdateCourse(int id, Course course)
        {
            Course crs = Program.Courses.Where((c) => c.Id == id).SingleOrDefault();
            crs.Topics = course.Topics;
            crs.Name = course.Name;
            crs.Exams = course.Exams;
        }

        public void UpdateTopic(int id, Topic topic)
        {
            Topic tp = Program.Topics.Where((t) => t.Id == id).SingleOrDefault();
            tp.Name = topic.Name;
        }


        public void DeleteStudent(int id)
        {
            Program.Students.RemoveAt(id);
        }

        public void DeleteDepartment(int id)
        {
            Program.Departments.RemoveAt(id);
        }

        public void DeleteQuestion(int id)
        {
            Program.Questions.RemoveAt(id);
        }

        public void DeleteInstructor(int id)
        {
            Program.Instructors.RemoveAt(id);
        }


        public void DeleteCourse(int id)
        {
            Program.Courses.RemoveAt(id);
        }


        public void DeleteTopic(int id)
        {
            Program.Topics.RemoveAt(id);
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
            var instructor = Program.Instructors.Where((i) => i.Id == instructorId).SingleOrDefault();

            if(instructor != null)
                instructor.Courses.ForEach(delegate (Course course) { Console.WriteLine(course.ToString()); });

            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportCourseInstructors(int courseId)
        {
            var course = Program.Courses.Where((i) => i.Id == courseId).SingleOrDefault();

            if (course != null)
            {
                var result = Program.Instructors.Where((i) => i.Courses.Contains(course)).ToList();
                
                if(result != null)
                    result.ForEach(delegate (Instructor instructor) { Console.WriteLine(instructor.ToString()); });
                else
                    Console.WriteLine("No Program.Instructors for this course");
            }

            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportStudentCourses(int studentId)
        {
            var student = Program.Students.Where((s)=>s.Id == studentId).SingleOrDefault();

            if(student != null)
                student.Courses.ForEach(delegate (Course course) { Console.WriteLine(course.ToString()); });
            
            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportCourseStudents(int courseId)
        {
            var course = Program.Courses.Where((i) => i.Id == courseId).SingleOrDefault();

            if(course != null)
            {
                var result = Program.Students.Where((i) => i.Courses.Contains(course)).ToList();

                if (result != null)
                    result.ForEach(delegate (Student student) { Console.WriteLine(student.ToString()); });
                else
                    Console.WriteLine("No Program.Students for this course");
            }

            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportCourseTopics(int courseId)
        {
            var course = Program.Courses.Where((c)=>c.Id == courseId).SingleOrDefault();

            if(course != null) 
                course.Topics.ForEach(delegate (Topic topic) { Console.WriteLine(topic.ToString()); });
            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportStudentExamsGrades(int studentId)
        {
            var student = Program.Students.Where((s) => s.Id == studentId).SingleOrDefault();

            if (student != null)
            {
                student.Exams.ForEach(delegate (StudentExam studentExam) { Console.WriteLine(studentExam.ToString()); });
            }

            else
                Console.WriteLine("ID doesn't exist");
        }
        #endregion
    }
}
