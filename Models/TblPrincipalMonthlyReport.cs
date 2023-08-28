using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPrincipalMonthlyReport
{
    public long Id { get; set; }

    public long? PrincipalId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployee? Principal { get; set; }

    public virtual ICollection<TblActprincipalReportMainHeadingDetailsDatum> TblActprincipalReportMainHeadingDetailsData { get; set; } = new List<TblActprincipalReportMainHeadingDetailsDatum>();

    public virtual ICollection<TblActprincipalReportSubCategoryHeadingDatum> TblActprincipalReportSubCategoryHeadingData { get; set; } = new List<TblActprincipalReportSubCategoryHeadingDatum>();

    public virtual ICollection<TblActprincipalReportSubHeadingDetailsDatum> TblActprincipalReportSubHeadingDetailsData { get; set; } = new List<TblActprincipalReportSubHeadingDetailsDatum>();
}
