using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Question
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Statement { get; set; } = null!;

    public int CourseId { get; set; }

    public string? Answer { get; set; }

    public virtual Choice? Choice { get; set; }

    public virtual ICollection<StudentExamQuestionSolution> StudentExamQuestionSolutions { get; } = new List<StudentExamQuestionSolution>();

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();
}
