using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeeLedgerGroup
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string LedgerCode { get; set; } = null!;

    public long OrgId { get; set; }

    public bool? IsBilling { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblFeeItemDetail> TblFeeItemDetails { get; set; } = new List<TblFeeItemDetail>();
}
