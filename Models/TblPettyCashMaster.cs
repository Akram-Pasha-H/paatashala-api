using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPettyCashMaster
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal? CashSpent { get; set; }

    public decimal? ClosingBalance { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
