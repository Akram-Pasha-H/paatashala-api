using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGpsdatum
{
    public long Id { get; set; }

    public long? RouteCode { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime? Time { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRoute? RouteCodeNavigation { get; set; }
}
