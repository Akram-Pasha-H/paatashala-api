using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRouteStop
{
    public long Id { get; set; }

    public long RouteId { get; set; }

    public long StopId { get; set; }

    public int? RouteOrder { get; set; }

    public TimeSpan? ArrivalTime { get; set; }

    public TimeSpan? DepartureTime { get; set; }

    public bool IsRouteStart { get; set; }

    public bool IsRouteEnd { get; set; }

    public int? DistanceFromStart { get; set; }

    public int? DistanceToEnd { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblRoute Route { get; set; } = null!;

    public virtual TblRouteStop1 Stop { get; set; } = null!;
}
