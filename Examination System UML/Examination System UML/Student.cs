using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    // call Helpers.Hold(); at the end of every function to hold the state
    public class Student : Person
    {
        public string Phone { get; set; }

        public string Address { get; set; }

        public Department Department { get; set; }

        public List<Course> Courses { get; set; }

        public List<StudentExam> Exams { get; set; }

        private void TakeExam()
        {
            throw new NotImplementedException();
        }

        private List<Tuple<string, double>> GetGrades()
        {
            throw new NotImplementedException();
        }

        private Tuple<string, double> GetGrade()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Student ID: {Id}\nStudent Name: {FirstName + " " + LastName}\nDepartment Name: {Department.Name}";
        }

        public override void PresentMenu()
        {
            string welcome = "******************************************************************************\n" +
                            $"****Welcome {FirstName + " " + LastName} to ITI Examination System\n" +
                             "******************************************************************************\n\n";

            Console.WriteLine(welcome + "\nPlease choose an option:");
            Console.WriteLine(
                "1- Take exam\n" +
                "2- Get all exams grades\n" +
                "3- Get exam grade\n" +
                "4- ESC to logout");


            while (true)
            {
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1: { Console.Clear(); TakeExam(); break; }
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2: { Console.Clear(); GetGrades(); break; }
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3: { Console.Clear(); GetGrade(); break; }
                    case ConsoleKey.Escape: { Program.CurrentUser = null; Program.Type = ""; return; }
                }
            }
        }
    }
}
