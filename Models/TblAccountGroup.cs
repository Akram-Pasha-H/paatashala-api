using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAccountGroup
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblAccountLedger> TblAccountLedgers { get; set; } = new List<TblAccountLedger>();
}
