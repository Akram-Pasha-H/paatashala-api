using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMonthlyBillingDatum
{
    public long Id { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public long ForOrg { get; set; }

    public virtual TblOrg ForOrgNavigation { get; set; } = null!;

    public virtual ICollection<TblMonthlyBillingDetail> TblMonthlyBillingDetails { get; set; } = new List<TblMonthlyBillingDetail>();

    public virtual ICollection<TblMonthlyBillingOtherCourseDetail> TblMonthlyBillingOtherCourseDetails { get; set; } = new List<TblMonthlyBillingOtherCourseDetail>();
}
