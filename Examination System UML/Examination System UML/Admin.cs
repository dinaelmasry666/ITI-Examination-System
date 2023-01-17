using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    // call Helpers.Hold(); at the end of every function to hold the state
    public class Admin : Instructor
    {
        #region CUD operations
        private void AddStudent()
        {
            Student student = new Student();
            student.GetHashCode();
            Console.WriteLine("Enter ID: ");
            int id = 1;

            //Program.Students.Where()
            //check for null 
            //contains works by ref not value, so check for duplicates by id

            if (!Program.Students.Contains(student))
            {
                Program.Students.Add(student);
            }
            else
            {
                Console.WriteLine("This student is already exists");
            }
        }

        private void AddDepartment()
        {
            Department department = new Department();
            if (!Program.Departments.Contains(department))
            {
                Program.Departments.Add(department);
            }
            else
            {
                Console.WriteLine("This Department is already exists");
            }
        }

        private void AddQuestion()
        {
            Question question = new Question();
            if (!Program.Questions.Contains(question))
            {
                Program.Questions.Add(question);
            }
            else
            {
                Console.WriteLine("This question is already exists");
            }
        }

        private void AddInstructor()
        {
            Instructor instructor = new Instructor();
            if (!Program.Instructors.Contains(instructor))
            {
                Program.Instructors.Add(instructor);
            }
            else
            {
                Console.WriteLine("This instructor is already exists");
            }
        }

        private void AddCourse()
        {
            Course course = new Course();
            if (!Program.Courses.Contains(course))
            {
                Program.Courses.Add(course);
            }
            else
            {
                Console.WriteLine("This course is already exists");
            }
        }

        private void AddTopic()
        {
            Topic topic = new Topic();
            if (!Program.Topics.Contains(topic))
            {
                Program.Topics.Add(topic);
            }
            else
            {
                Console.WriteLine("This topic is already exists");
            }
        }


        private void UpdateStudent()
        {
            Student student = new Student();
            Student st = Program.Students.Where((s) => s.Id == student.Id).SingleOrDefault();
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

        private void UpdateDepartment()
        {
            Department department = new Department();
            Department dt = Program.Departments.Where((d) => d.Id == department.Id).SingleOrDefault();
            dt.Manager = department.Manager;
            dt.Name = department.Name;

        }

        private void UpdateQuestion()
        {
            Question question = new Question();
            Question qs = Program.Questions.Where((q) => q.Id == question.Id).SingleOrDefault();
            qs.Statement = question.Statement;
            qs.Answer = question.Answer;
            qs.Choices = question.Choices;
            qs.Type = question.Type;
        }

        private void UpdateInstructor()
        {
            Instructor instructor  = new Instructor();
            Instructor ins = Program.Instructors.Where((i) => i.Id == instructor.Id).SingleOrDefault();
            ins.Courses = instructor.Courses;
            ins.Department = instructor.Department;
            ins.LastName = instructor.LastName;
            ins.FirstName = instructor.FirstName;
            //ins.userName = instructor.userName;
            //ins.password = instructor.password;
        }

        private void UpdateCourse()
        {
            Course course = new Course();
            Course crs = Program.Courses.Where((c) => c.Id == course.Id).SingleOrDefault();
            crs.Topics = course.Topics;
            crs.Name = course.Name;
            crs.Exams = course.Exams;
        }

        private void UpdateTopic()
        {
            Topic topic = new Topic();
            Topic tp = Program.Topics.Where((t) => t.Id == topic.Id).SingleOrDefault();
            tp.Name = topic.Name;
        }


        private void DeleteStudent()
        {
            var s = Program.Students.Where((s)=>s.Id == 1).FirstOrDefault();
            if(s != null) Program.Students.Remove(s);

        }

        private void DeleteDepartment()
        {
            Program.Departments.RemoveAt(1);
        }

        private void DeleteQuestion()
        {
            Program.Questions.RemoveAt(1);
        }

        private void DeleteInstructor()
        {
            Program.Instructors.RemoveAt(1);
        }


        private void DeleteCourse()
        {
            Program.Courses.RemoveAt(1);
        }


        private void DeleteTopic()
        {
            Program.Topics.RemoveAt(1);
        }

        #endregion

        #region Assign
        private void AssignAdmin() 
        {
            int instructorId = 0;

            Admin instructor = (Admin)Program.Instructors.Where((i) => i.Id == instructorId).SingleOrDefault();
            if (instructor != null)
            {
                Program.Instructors.RemoveAt(instructorId);
                Program.Instructors.Add(instructor);
            }
            else
                Console.WriteLine("ID doesn't exist");
        }

        private void AssignInstrucor()
        {
            int instructorId = 0, courseId = 0;

            Instructor instructor = Program.Instructors.Where((i) => i.Id == instructorId).SingleOrDefault();
            Course course = Program.Courses.Where((c) => c.Id == courseId).SingleOrDefault();

            if (instructor != null && course != null)
                instructor.Courses.Add(course);
            else if (course != null)
                Console.WriteLine("Instructor ID doesn't exist");
            else
                Console.WriteLine("Course ID doesn't exist");
        }

        private void AssignStudent()
        {
            int studentId = 0, courseId = 0;
            Student student = Program.Students.Where((s) => s.Id == studentId).SingleOrDefault();
            Course course = Program.Courses.Where((c) => c.Id == courseId).SingleOrDefault();

            if (student != null && course != null)
                student.Courses.Add(course);
            else if (course != null)
                Console.WriteLine("Student ID doesn't exist");
            else
                Console.WriteLine("Course ID doesn't exist");
        }
        #endregion

        #region Reports
        private void GenerateReportInstructorCourses()
        {
            Console.Write("Enter instructor ID: ");
            int instructorId = Convert.ToInt32(Console.ReadLine());

            var instructor = Program.Instructors.Where((i) => i.Id == instructorId).SingleOrDefault();

            if(instructor != null)
                instructor.Courses.ForEach(delegate (Course course) { Console.WriteLine(course.ToString()); });

            else
                Console.WriteLine("ID doesn't exist");

            Helpers.Hold();
        }

        private void GenerateReportCourseInstructors()
        {
            Console.Write("Enter course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            var course = Program.Courses.Where((i) => i.Id == courseId).SingleOrDefault();

            if (course != null)
            {
                var result = Program.Instructors.Where((i) => i.Courses.Contains(course)).ToList();
                
                if(result != null)
                    result.ForEach(delegate (Instructor instructor) { Console.WriteLine(instructor.ToString()); Console.WriteLine("************************"); });
                else
                    Console.WriteLine("No Program.Instructors for this course");
            }

            else
                Console.WriteLine("ID doesn't exist");

            Helpers.Hold();
        }

        private void GenerateReportStudentCourses()
        {

            Console.Write("Enter student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            var student = Program.Students.Where((s)=>s.Id == studentId).SingleOrDefault();

            if(student != null)
                student.Courses.ForEach(delegate (Course course) { Console.WriteLine(course.ToString()); });
            
            else
                Console.WriteLine("ID doesn't exist");

            Helpers.Hold();
        }

        private void GenerateReportCourseStudents()
        {

            Console.Write("Enter course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

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

            Helpers.Hold();
        }

        private void GenerateReportCourseTopics()
        {

            Console.Write("Enter course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            var course = Program.Courses.Where((c)=>c.Id == courseId).SingleOrDefault();

            if(course != null) 
                course.Topics.ForEach(delegate (Topic topic) { Console.WriteLine(topic.ToString()); });
            else
                Console.WriteLine("ID doesn't exist");

            Helpers.Hold();
        }

        private void GenerateReportStudentExamsGrades()
        {

            Console.Write("Enter student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            var student = Program.Students.Where((s) => s.Id == studentId).SingleOrDefault();

            if (student != null)
            {
                student.Exams.ForEach(delegate (StudentExam studentExam) { Console.WriteLine(studentExam.ToString()); });
            }

            else
                Console.WriteLine("ID doesn't exist");

            Helpers.Hold();
        }
        #endregion


        public override void PresentMenu()
        {
            while (true)
            {
                Console.Clear();
                string welcome = "******************************************************************************\n" +
                                $"****Welcome {FirstName + " " + LastName} to ITI Examination System\n" +
                                 "******************************************************************************\n\n";

                Console.WriteLine(welcome + "\nPlease choose an option:");
                Console.WriteLine(
                    "1- Create, Update, or Delete a user\n" +
                    "2- Grant or Revoke authorization\n" +
                    "3- Generate a Report\n" +
                    "4- ESC to logout");


                var choice = Console.ReadKey();
                Console.Clear();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1: { CUDMenu(); break; }
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2: { AssignMenu(); break; }
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3: { ReportMenu(); break; }
                    case ConsoleKey.Escape: { Program.CurrentUser = null; Program.Type = ""; return; }
                }
            }
        }

        private void CUDMenu()
        {
            Console.WriteLine(
                "1- Add Student                                 2- Add Department\n" +
                "3- Add Question                                4- Add Instructor\n" +
                "5- Add Course                                  6- Add Topic\n" +
                "7- Update Student                              8- Update Department\n" +
                "9- Update Question                             10- Update Instructor\n" +
                "11- Update Course                              12- Update Topic\n" +
                "13- Delete Student                             14- Delete Department\n" +
                "15- Delete Question                            16- Delete Instructor\n" +
                "17- Delete Course                              18- Delete Topic\n" +
                "19- Assign Admin                               21- Assign Instrucor\n" +
                "22- Assign Student                             23- Generate ReportInstructorCourses\n" +
                "24- Generate ReportCourseInstructors           25- Generate ReportStudentCourses\n" +
                "26- Generate ReportCourseStudents              27- Generate ReportCourseTopics\n" +
                "28- Generate ReportStudentExamsGrades");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: AddDepartment(); break;
                case 3: AddQuestion(); break;
                case 4: AddInstructor(); break;
                case 5: AddCourse(); break;
                case 6: AddTopic(); break;
                case 7: UpdateStudent(); break;
                case 8: UpdateDepartment(); break;
                case 9: UpdateQuestion(); break;
                case 10: UpdateInstructor(); break;
                case 11: UpdateCourse(); break;
                case 12: UpdateTopic(); break;
                case 13: DeleteStudent(); break;
                case 14: DeleteDepartment(); break;
                case 15: DeleteQuestion(); break;
                case 16: DeleteInstructor(); break;
                case 17: DeleteCourse(); break;
                case 18: DeleteTopic(); break;
                case 19: AssignAdmin(); break;
                case 21: AssignInstrucor(); break;
                case 22: AssignStudent(); break;
                case 23: GenerateReportInstructorCourses(); break;
                case 24: GenerateReportCourseInstructors(); break;
                case 25: GenerateReportStudentCourses(); break;
                case 26: GenerateReportCourseStudents(); break;
                case 27: GenerateReportCourseTopics(); break;
                case 28: GenerateReportStudentExamsGrades(); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }

        private void AssignMenu()
        {
            Console.WriteLine(
                "1- AssignAdmin\n" +
                "2- AssignInstrucor\n" +
                "3- AssignStudent\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AssignAdmin(); break;
                case 2: AssignInstrucor(); break;
                case 3: AssignStudent(); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }

        private void ReportMenu()
        {
            Console.WriteLine(
                "1- GenerateReportInstructorCourses\n" +
                "2- GenerateReportCourseInstructors\n" +
                "3- GenerateReportStudentCourses\n" +
                "4- GenerateReportCourseStudents\n" +
                "5- GenerateReportCourseTopics\n" +
                "6- GenerateReportStudentExamsGrades\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: GenerateReportInstructorCourses(); break;
                case 2: GenerateReportCourseInstructors(); break;
                case 3: GenerateReportStudentCourses(); break;
                case 4: GenerateReportCourseStudents(); break;
                case 5: GenerateReportCourseTopics(); break;
                case 6: GenerateReportStudentExamsGrades(); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }
    }
}
