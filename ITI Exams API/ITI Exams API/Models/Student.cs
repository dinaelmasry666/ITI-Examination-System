using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? University { get; set; }

    public string? Faculty { get; set; }

    public int? GradYear { get; set; }

    public string? Grade { get; set; }

    public int DepartmentId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Department? Department { get; set; } = null!;

    public virtual ICollection<StudentExamQuestionSolution> StudentExamQuestionSolutions { get; } = new List<StudentExamQuestionSolution>();

    public virtual ICollection<StudentExam> StudentExams { get; } = new List<StudentExam>();

    public virtual ICollection<Course> Courses { get; } = new List<Course>();
}
