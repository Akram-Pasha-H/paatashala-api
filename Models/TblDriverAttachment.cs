using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDriverAttachment
{
    public long Id { get; set; }

    public long DriverId { get; set; }

    public byte[]? Attachments { get; set; }

    public string? FileName { get; set; }

    public long? FileSizeInBytes { get; set; }

    public long OrgId { get; set; }

    public virtual TblDriver Driver { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
