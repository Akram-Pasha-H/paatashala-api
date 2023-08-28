using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDriver
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? PresentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? LicenseNumber { get; set; }

    public DateTime? LicenseExpiry { get; set; }

    public long OrgId { get; set; }

    public long? Mode { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblDriverAttachment> TblDriverAttachments { get; set; } = new List<TblDriverAttachment>();

    public virtual ICollection<TblRouteVehicle> TblRouteVehicles { get; set; } = new List<TblRouteVehicle>();
}
