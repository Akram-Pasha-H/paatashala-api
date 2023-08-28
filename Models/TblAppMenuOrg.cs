using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAppMenuOrg
{
    public long Id { get; set; }

    public long MenuId { get; set; }

    public long OrgId { get; set; }

    public virtual TblAppMenuName Menu { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
