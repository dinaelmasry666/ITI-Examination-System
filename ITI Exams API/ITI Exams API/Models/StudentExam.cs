using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class StudentExam
{
    public int StudentId { get; set; }

    public int ExamId { get; set; }

    public double? Grade { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
