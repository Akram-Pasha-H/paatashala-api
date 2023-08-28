using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStockItem
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? UnitOfMeasure { get; set; }

    public long StockGroup { get; set; }

    public decimal? OpeningStock { get; set; }

    public long OrgId { get; set; }

    public long? MinStock { get; set; }

    public long? MaxStock { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStockGroup StockGroupNavigation { get; set; } = null!;

    public virtual ICollection<TblFeeLinkedInventoryItem> TblFeeLinkedInventoryItems { get; set; } = new List<TblFeeLinkedInventoryItem>();

    public virtual ICollection<TblGrnPoDetail> TblGrnPoDetails { get; set; } = new List<TblGrnPoDetail>();

    public virtual ICollection<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; } = new List<TblPurchaseOrderDetail>();

    public virtual ICollection<TblStockItemDeliveryDetail> TblStockItemDeliveryDetails { get; set; } = new List<TblStockItemDeliveryDetail>();

    public virtual ICollection<TblStudentKitItem> TblStudentKitItems { get; set; } = new List<TblStudentKitItem>();

    public virtual TblUnitOfMeasure? UnitOfMeasureNavigation { get; set; }
}
