using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmailTemplate
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? EmailContent { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
