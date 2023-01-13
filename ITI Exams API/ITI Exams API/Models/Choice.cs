using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Choice
{
    public int QuestionId { get; set; }

    public string? A { get; set; }

    public string? B { get; set; }

    public string? C { get; set; }

    public string? D { get; set; }

    public virtual Question Question { get; set; } = null!;
}
