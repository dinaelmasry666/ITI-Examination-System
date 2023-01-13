using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? IsAdmin { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<Department> Departments { get; } = new List<Department>();
}
