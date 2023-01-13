using System;
using System.Collections.Generic;

namespace ITI_Exams_API.Models;

public partial class Topic
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
