using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblInactiveStudentLog
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public bool? SetActive { get; set; }

    public long? OrgId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? OtherProgramId { get; set; }

    public long? UserId { get; set; }

    public string? Narration { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOtherProgram? OtherProgram { get; set; }

    public virtual TblStudent? Student { get; set; }
}
