using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportMainHeadingDetailsDatum
{
    public long Id { get; set; }

    public long? MainHeadingDetailId { get; set; }

    public string? Value { get; set; }

    public long? ReportId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActprincipalReportMainHeadingDetail? MainHeadingDetail { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblPrincipalMonthlyReport? Report { get; set; }
}
