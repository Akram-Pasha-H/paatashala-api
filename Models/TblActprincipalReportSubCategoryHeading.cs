using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActprincipalReportSubCategoryHeading
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? MainHeadingId { get; set; }

    public long? SubHeadingId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActprincipalReportMainHeading? MainHeading { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblActprincipalReportSubHeading? SubHeading { get; set; }

    public virtual ICollection<TblActprincipalReportSubCategoryHeadingDatum> TblActprincipalReportSubCategoryHeadingData { get; set; } = new List<TblActprincipalReportSubCategoryHeadingDatum>();
}
