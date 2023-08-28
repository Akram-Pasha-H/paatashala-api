using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTransportTripSheet
{
    public long Id { get; set; }

    public long RouteId { get; set; }

    public long StudentId { get; set; }

    public TimeSpan? PickTime { get; set; }

    public TimeSpan? DropTime { get; set; }

    public long OrgId { get; set; }

    public long? StartPoint { get; set; }

    public long? EndPoint { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblRoute Route { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
