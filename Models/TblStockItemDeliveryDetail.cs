using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStockItemDeliveryDetail
{
    public long Id { get; set; }

    public long? DeliveryHeaderId { get; set; }

    public long? StockItemId { get; set; }

    public int? Quantity { get; set; }

    public virtual TblStockItemsDeliveryHeader? DeliveryHeader { get; set; }

    public virtual TblStockItem? StockItem { get; set; }
}
