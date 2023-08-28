using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportSubHeading
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public long? MainHeadingId { get; set; }

    public virtual TblActprincipalReportMainHeading? MainHeading { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActprincipalReportSubCategoryHeading> TblActprincipalReportSubCategoryHeadings { get; set; } = new List<TblActprincipalReportSubCategoryHeading>();

    public virtual ICollection<TblActprincipalReportSubHeadingDetail> TblActprincipalReportSubHeadingDetails { get; set; } = new List<TblActprincipalReportSubHeadingDetail>();
}
