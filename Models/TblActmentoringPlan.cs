using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActmentoringPlan
{
    public long Id { get; set; }

    public long? TeacherId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? StudentId { get; set; }

    public long? OrgId { get; set; }

    public string? Section { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual ICollection<TblActmentoringSchedule> TblActmentoringSchedules { get; set; } = new List<TblActmentoringSchedule>();

    public virtual TblEmployee? Teacher { get; set; }
}
