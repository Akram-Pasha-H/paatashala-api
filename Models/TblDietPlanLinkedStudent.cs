using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDietPlanLinkedStudent
{
    public long Id { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? StudentId { get; set; }

    public long? DietPlanId { get; set; }

    public long? OrgId { get; set; }

    public bool? IsRegularCourse { get; set; }

    public long? OtherCourseId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblDietPlan? DietPlan { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }
}
