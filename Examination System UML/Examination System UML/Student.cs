using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            Console.WriteLine("choose the targeted exam ID...");

            for(int i = 0;i < Exams.Count; i++)
               {
                Console.WriteLine(Exams[i]); 
               }
            int examId=int.Parse(Console.ReadLine());

           
            StudentExam ex = Exams.Where((e) => e.Exam.Id == examId).FirstOrDefault();
            if(ex == null)
            {
                Console.WriteLine("No Exam with the given ID");
                return;
            }
            Console.WriteLine(ex);

            for (int i = 0; i < ex.Exam.Questions.Count; i++)
            { 
              ex.Answers += $"{Console.ReadLine()}";
              ex.Answers += ",";
            }

            CorrectExam(ex);

            Helpers.Hold();
        }



        private List  < Tuple <int  , double> > GetGrades()
        {
            //Tuple<CourseName, Grade> MyCustomTuple = new Tuple<CourseName, Grade>();

            var tupleList = new List<Tuple<int, double>>();

            for (int i = 0; i<Exams.Count; i++)
			{  
                tupleList.Add( new Tuple<int, double>(Exams[i].Exam.CourseId, Exams[i].Grade));
            }
            Helpers.Hold();
            return tupleList;
        }

        private Tuple<int, double> GetGrade()
        {
            Tuple <int, double> T;
            int courseId = int.Parse(Console.ReadLine());
            Course crs = Program.Courses.Where((c) => c.Id == courseId).FirstOrDefault();

            if (crs == null)
            {
                Console.WriteLine("No course with the given ID");
                return new Tuple<int, double>(-1,-1);
            }

            for (int i = 0; i < Exams.Count; i++)
            { 
                if(Exams[i].Exam.CourseId== courseId)
                {
                T = new Tuple<int, double>(Exams[i].Exam.CourseId, Exams[i].Grade);
                return T;
                }

            }
           

            Helpers.Hold();
            return new Tuple<int, double>(-1, -1);
        }


        private void CorrectExam(StudentExam studentEx)
        {
            int numberOfCorrecrAnswers = 0;
            int generalExamId= studentEx.Exam.Id;
            Exam generalExam = Program.Exams.Where((c) => c.Id == generalExamId).FirstOrDefault();
           
            // converting student answers from string to char array
            string[] studentAnswers = studentEx.Answers.Split(',');


          
            //checking the student answer with model answer
            for(int i = 0;i < generalExam.Questions.Count; i++)
            {
                
                if (generalExam.Questions[i].Answer == studentAnswers[i][0])
                {
                    numberOfCorrecrAnswers += 1;
                }
            }
            studentEx.Grade = numberOfCorrecrAnswers / generalExam.Questions.Count;

            Helpers.Hold();
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
