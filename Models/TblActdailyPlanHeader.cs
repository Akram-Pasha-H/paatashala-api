using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActdailyPlanHeader
{
    public long Id { get; set; }

    public long? TeacherId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? SubjectId { get; set; }

    public int? Month { get; set; }

    public long? OrgId { get; set; }

    public string? Section { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubject? Subject { get; set; }

    public virtual ICollection<TblActdailyPlanDetail> TblActdailyPlanDetails { get; set; } = new List<TblActdailyPlanDetail>();

    public virtual TblEmployee? Teacher { get; set; }
}
