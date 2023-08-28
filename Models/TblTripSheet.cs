using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTripSheet
{
    public long Id { get; set; }

    public long? RouteVehicleId { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public bool IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblRouteVehicle? RouteVehicle { get; set; }

    public virtual ICollection<TblTripParticipant> TblTripParticipants { get; set; } = new List<TblTripParticipant>();
}
