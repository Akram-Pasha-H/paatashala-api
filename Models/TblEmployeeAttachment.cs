using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeAttachment
{
    public long Id { get; set; }

    public long EmployeeId { get; set; }

    public byte[]? Attachment { get; set; }

    public string? FileName { get; set; }

    public long? FileSizeInBytes { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployee Employee { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
