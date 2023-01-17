using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    // call Helpers.Hold(); at the end of every function to hold the state
    public class Instructor : Person
    {
        public Department Department { get; set; }
        public List<Course> Courses { get; set; }

        /// <summary>
        /// This function should generate an exam randomly from pre-existing questions according to choosen course id.
        /// </summary>
        /// <param name="courseId"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void GenerateExam()
        {
            int courseId = Convert.ToInt32(Console.ReadLine());
            Course course = Program.Courses.Where((c) => c.Id == courseId).FirstOrDefault();
            
            if(course == null)
            {
                Console.WriteLine("No course with the given ID");
                return;
            }

            Random rnd = new Random();

            course.Questions.Where((q) => q.Type == "MCQ").OrderBy(x => rnd.Next()).Take(5);
            course.Questions.Where((q) => q.Type == "TF").OrderBy(x => rnd.Next()).Take(5);

        }

        /// <summary>
        /// This function should ask the instructor if he wants to add assign an exam to a single or group of students, or he wants to asign it to all students in the course,
        /// and handel both cases.
        /// HANDEL EACH CASE IN A DIFFERENT *PRIVATE* FUNCTION
        /// </summary>
        /// <param name="examId"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void AssignExam()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Instructor ID: {Id}\nInstructor Name: {FirstName + " " + LastName}\nDepartment Name: {Department.Name}";
        }


        public override void PresentMenu()
        {
            string welcome = "******************************************************************************\n" +
                            $"****Welcome {FirstName + " " + LastName} to ITI Examination System\n" +
                             "******************************************************************************\n\n";

            Console.WriteLine(welcome + "\nPlease choose an option:");
            Console.WriteLine(
                "1- Generate an exam\n" +
                "2- Assign exam\n" +
                "3- ESC to logout");


            while (true)
            {
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1: { Console.Clear(); GenerateExam(); break; }
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2: { Console.Clear(); AssignExam(); break; }
                    case ConsoleKey.Escape: { Program.CurrentUser = null; Program.Type = ""; return; }
                }
            }
        }
    }
}
