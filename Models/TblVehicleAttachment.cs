using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVehicleAttachment
{
    public long Id { get; set; }

    public long VehicleId { get; set; }

    public byte[]? Attachment { get; set; }

    public string? FileName { get; set; }

    public long? FileSizeInBytes { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblVehicle Vehicle { get; set; } = null!;
}
