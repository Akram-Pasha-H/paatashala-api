using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRouteStop1
{
    public long Id { get; set; }

    public string? StopName { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblRouteStop> TblRouteStops { get; set; } = new List<TblRouteStop>();
}
