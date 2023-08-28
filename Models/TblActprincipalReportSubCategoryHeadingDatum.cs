using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportSubCategoryHeadingDatum
{
    public long Id { get; set; }

    public long? SubCategoryHeadingId { get; set; }

    public string? Value { get; set; }

    public long? ReportId { get; set; }

    public long? OrgId { get; set; }

    public long? RowId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblPrincipalMonthlyReport? Report { get; set; }

    public virtual TblActprincipalReportSubCategoryHeading? SubCategoryHeading { get; set; }
}
