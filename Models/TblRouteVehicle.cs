using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRouteVehicle
{
    public long Id { get; set; }

    public long? RouteId { get; set; }

    public long? VehicleId { get; set; }

    public long? DriverId { get; set; }

    public long? OrgId { get; set; }

    public long? AttendarId { get; set; }

    public virtual TblDriver? Driver { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRoute? Route { get; set; }

    public virtual ICollection<TblTripSheet> TblTripSheets { get; set; } = new List<TblTripSheet>();

    public virtual TblVehicle? Vehicle { get; set; }
}
