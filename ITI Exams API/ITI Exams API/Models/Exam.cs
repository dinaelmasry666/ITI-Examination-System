using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Exam
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int? CourseId { get; set; }

    public int? AuthorId { get; set; }

    public virtual Instructor? Author { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<StudentExamQuestionSolution> StudentExamQuestionSolutions { get; } = new List<StudentExamQuestionSolution>();

    public virtual ICollection<StudentExam> StudentExams { get; } = new List<StudentExam>();

    public virtual ICollection<Question> Questions { get; } = new List<Question>();
}
