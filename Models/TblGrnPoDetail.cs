using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGrnPoDetail
{
    public long Id { get; set; }

    public long HeaderId { get; set; }

    public long? ItemCode { get; set; }

    public long? Item { get; set; }

    public long? Quantity { get; set; }

    public decimal? PricePerUnit { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? TaxPercent { get; set; }

    public string? Unit { get; set; }

    public long OrgId { get; set; }

    public virtual TblGrnPoHeader Header { get; set; } = null!;

    public virtual TblStockGroup? ItemCodeNavigation { get; set; }

    public virtual TblStockItem? ItemNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
