using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStockGroup
{
    public long Id { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblGrnPoDetail> TblGrnPoDetails { get; set; } = new List<TblGrnPoDetail>();

    public virtual ICollection<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; } = new List<TblPurchaseOrderDetail>();

    public virtual ICollection<TblStockItem> TblStockItems { get; set; } = new List<TblStockItem>();
}
