using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSsgbillingDetail
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public decimal? NormalCourseBillingRate { get; set; }

    public decimal? OtherCourseBillingRate { get; set; }

    public string? TermsAndConditions { get; set; }

    public bool? IsDiscountEligible { get; set; }

    public bool? IsPromotionalOrg { get; set; }

    public bool? ApplyToChildOrg { get; set; }

    public bool? IsTaxExemption { get; set; }

    public decimal? Cgst { get; set; }

    public decimal? Sgst { get; set; }

    public decimal? DiscountAmount { get; set; }

    public bool? IsFlateRate { get; set; }

    public decimal? FlateRateAmount { get; set; }

    public int? DiscountFor { get; set; }

    public decimal? EmployeeLoginAmount { get; set; }

    public decimal? ParentLoginAmount { get; set; }

    public virtual TblOrg? Org { get; set; }
}
