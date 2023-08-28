using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDietPlan
{
    public long Id { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblDietPlanDetail> TblDietPlanDetails { get; set; } = new List<TblDietPlanDetail>();

    public virtual ICollection<TblDietPlanLinkedStudent> TblDietPlanLinkedStudents { get; set; } = new List<TblDietPlanLinkedStudent>();
}
