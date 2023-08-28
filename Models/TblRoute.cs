using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRoute
{
    public long Id { get; set; }

    public string? RouteCode { get; set; }

    public long? RouteStart { get; set; }

    public long? RouteEnd { get; set; }

    public TimeSpan? TotalDuration { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblGpsdatum> TblGpsdata { get; set; } = new List<TblGpsdatum>();

    public virtual ICollection<TblRouteStop> TblRouteStops { get; set; } = new List<TblRouteStop>();

    public virtual ICollection<TblRouteVehicle> TblRouteVehicles { get; set; } = new List<TblRouteVehicle>();

    public virtual ICollection<TblTransportTripSheet> TblTransportTripSheets { get; set; } = new List<TblTransportTripSheet>();
}
