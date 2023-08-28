using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportMainHeadingDetail
{
    public long Id { get; set; }

    public long? MainHeadingId { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActprincipalReportMainHeading? MainHeading { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActprincipalReportMainHeadingDetailsDatum> TblActprincipalReportMainHeadingDetailsData { get; set; } = new List<TblActprincipalReportMainHeadingDetailsDatum>();
}
