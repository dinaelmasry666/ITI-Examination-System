using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Instructor> InstructorsNavigation { get; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
