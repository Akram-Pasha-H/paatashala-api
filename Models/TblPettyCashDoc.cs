using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPettyCashDoc
{
    public long Id { get; set; }

    public string? Guid { get; set; }

    public byte[]? PettyCashFiles { get; set; }

    public string? PettyCashFileName { get; set; }

    public long OrgId { get; set; }

    public long? FileSize { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
