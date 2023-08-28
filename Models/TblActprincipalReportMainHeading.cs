using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportMainHeading
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActprincipalReportMainHeadingDetail> TblActprincipalReportMainHeadingDetails { get; set; } = new List<TblActprincipalReportMainHeadingDetail>();

    public virtual ICollection<TblActprincipalReportSubCategoryHeading> TblActprincipalReportSubCategoryHeadings { get; set; } = new List<TblActprincipalReportSubCategoryHeading>();

    public virtual ICollection<TblActprincipalReportSubHeadingDetail> TblActprincipalReportSubHeadingDetails { get; set; } = new List<TblActprincipalReportSubHeadingDetail>();

    public virtual ICollection<TblActprincipalReportSubHeading> TblActprincipalReportSubHeadings { get; set; } = new List<TblActprincipalReportSubHeading>();
}
