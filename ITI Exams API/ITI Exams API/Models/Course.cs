using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

    public virtual ICollection<Topic> Topics { get; } = new List<Topic>();

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
