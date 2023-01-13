using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class StudentExamQuestionSolution
{
    public int StudentId { get; set; }

    public int ExamId { get; set; }

    public int QuestionId { get; set; }

    public int? Answer { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
