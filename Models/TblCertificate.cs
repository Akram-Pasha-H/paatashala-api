using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCertificate
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Content { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
