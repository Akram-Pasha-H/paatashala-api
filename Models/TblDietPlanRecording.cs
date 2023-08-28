using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDietPlanRecording
{
    public long Id { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? StudentId { get; set; }

    public long? DietItemId { get; set; }

    public string? Uom { get; set; }

    public int? Quantity { get; set; }

    public DateTime? DateTime { get; set; }

    public long? OrgId { get; set; }

    public bool? IsRegularCourse { get; set; }

    public long? OtherCourseId { get; set; }

    public bool? HasConsumed { get; set; }

    public int? ConsumedQuantity { get; set; }

    public string? Day { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblDietaryItem? DietItem { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }
}
