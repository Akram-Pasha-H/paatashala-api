using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSubBlockCce
{
    public long Id { get; set; }

    public long BlockId { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblBlockCce Block { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
