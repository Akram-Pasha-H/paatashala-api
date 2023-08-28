using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVisitorMaterial
{
    public long Id { get; set; }

    public string? MaterialName { get; set; }

    public long? VisitorId { get; set; }

    public bool? IsRetuned { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblVisitor? Visitor { get; set; }
}
