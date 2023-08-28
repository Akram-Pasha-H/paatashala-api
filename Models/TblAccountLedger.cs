using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAccountLedger
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long AccountGroup { get; set; }

    public long OrgId { get; set; }

    public virtual TblAccountGroup AccountGroupNavigation { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
