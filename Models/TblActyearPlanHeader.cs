using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActyearPlanHeader
{
    public long Id { get; set; }

    public long? TeacherId { get; set; }

    public long? CourseId { get; set; }

    public long? BatchId { get; set; }

    public long? SubjectId { get; set; }

    public long? OrgId { get; set; }

    public string? Section { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubject? Subject { get; set; }

    public virtual ICollection<TblActyearPlanDetail> TblActyearPlanDetails { get; set; } = new List<TblActyearPlanDetail>();

    public virtual TblEmployee? Teacher { get; set; }
}
