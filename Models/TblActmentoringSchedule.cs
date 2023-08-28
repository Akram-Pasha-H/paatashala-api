using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActmentoringSchedule
{
    public long Id { get; set; }

    public long? MentoringPlanId { get; set; }

    public long? TeacherId { get; set; }

    public long? StudentId { get; set; }

    public int? Month { get; set; }

    public string? Day { get; set; }

    public string? Objective { get; set; }

    public string? ActivitiesPlanned { get; set; }

    public bool? IsHomeVisit { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActmentoringPlan? MentoringPlan { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual ICollection<TblActmentorReflection> TblActmentorReflections { get; set; } = new List<TblActmentorReflection>();

    public virtual TblEmployee? Teacher { get; set; }
}
