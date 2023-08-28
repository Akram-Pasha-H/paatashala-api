using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentDiary
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long BatchId { get; set; }

    public long CourseId { get; set; }

    public DateTime? DateWritten { get; set; }

    public string? Comments { get; set; }

    public bool? ResponseRequired { get; set; }

    public long OrgId { get; set; }

    public string? Title { get; set; }

    public virtual TblBatch Batch { get; set; } = null!;

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
