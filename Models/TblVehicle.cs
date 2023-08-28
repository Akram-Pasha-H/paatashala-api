using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVehicle
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long TypeId { get; set; }

    public string? Description { get; set; }

    public string ChassisNumber { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public long SeartingCapacity { get; set; }

    public string ContactPerson { get; set; } = null!;

    public string InsuranceNo { get; set; } = null!;

    public DateTime InsuranceRenewalDate { get; set; }

    public string Rcnumber { get; set; } = null!;

    public long OrgId { get; set; }

    public long? DeviceId { get; set; }

    public bool? IsVehicleActive { get; set; }

    public virtual TblVehicleDevice? Device { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblRouteVehicle> TblRouteVehicles { get; set; } = new List<TblRouteVehicle>();

    public virtual ICollection<TblVehicleAttachment> TblVehicleAttachments { get; set; } = new List<TblVehicleAttachment>();

    public virtual TblVehicleType Type { get; set; } = null!;
}
