using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHostelBilling
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
