using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportSubHeadingDetailsDatum
{
    public long Id { get; set; }

    public long? SubHeadingDetailsId { get; set; }

    public string? Value { get; set; }

    public long? OrgId { get; set; }

    public long? ReportId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblPrincipalMonthlyReport? Report { get; set; }

    public virtual TblActprincipalReportSubHeadingDetail? SubHeadingDetails { get; set; }
}
