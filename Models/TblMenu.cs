using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMenu
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public long MenuId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
