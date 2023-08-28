using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAolcomment
{
    public long Id { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? StudentId { get; set; }

    public long? TermId { get; set; }

    public long? AreaOfLearningId { get; set; }

    public string? Comments { get; set; }

    public long? EmpId { get; set; }

    public long? OrgId { get; set; }

    public bool? IsFinalComments { get; set; }

    public int? TotalWorkingDays { get; set; }

    public int? TotalPresentDays { get; set; }

    public virtual TblAreaOfLearning? AreaOfLearning { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblTerm? Term { get; set; }
}
