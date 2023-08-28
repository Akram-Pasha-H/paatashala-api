using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCourseFeeDetail
{
    public long Id { get; set; }

    public string? TemplateName { get; set; }

    public long Course { get; set; }

    public long Batch { get; set; }

    public long FeeItem { get; set; }

    public string? Uom { get; set; }

    public decimal? RatePerUnit { get; set; }

    public long? BillingType { get; set; }

    public decimal? StandardRate { get; set; }

    public decimal Amount { get; set; }

    public long OrgId { get; set; }

    public bool? IsBilling { get; set; }

    public virtual TblBatch BatchNavigation { get; set; } = null!;

    public virtual TblCourse CourseNavigation { get; set; } = null!;

    public virtual TblFeeItemDetail FeeItemNavigation { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
