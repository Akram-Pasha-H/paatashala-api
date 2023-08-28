using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActRemedialPlanSubjectWise
{
    public long Id { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? SubjectId { get; set; }

    public long? TeacherId { get; set; }

    public int? Month { get; set; }

    public long? StudentId { get; set; }

    public string? ClassesAttended { get; set; }

    public string? AreaOfImprove { get; set; }

    public string? Remarks { get; set; }

    public long? OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblSubject? Subject { get; set; }

    public virtual TblEmployee? Teacher { get; set; }
}
