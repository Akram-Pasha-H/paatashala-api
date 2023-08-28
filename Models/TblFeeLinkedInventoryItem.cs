using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeeLinkedInventoryItem
{
    public long Id { get; set; }

    public long? StockId { get; set; }

    public long? FeeId { get; set; }

    public long? OrgId { get; set; }

    public long? KitId { get; set; }

    public virtual TblFeeItemDetail? Fee { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStockItem? Stock { get; set; }
}
