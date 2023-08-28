using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDietPlanDetail
{
    public long Id { get; set; }

    public long DietId { get; set; }

    public long Item { get; set; }

    public decimal Weight { get; set; }

    public string? Uom { get; set; }

    public long Course { get; set; }

    public long OrgId { get; set; }

    public string? Days { get; set; }

    public TimeSpan? Time { get; set; }

    public virtual TblCourse CourseNavigation { get; set; } = null!;

    public virtual TblDietPlan Diet { get; set; } = null!;

    public virtual TblDietaryItem ItemNavigation { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
