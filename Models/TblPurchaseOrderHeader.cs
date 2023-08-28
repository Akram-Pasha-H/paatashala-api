using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPurchaseOrderHeader
{
    public long Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public long? TaxTypeId { get; set; }

    public long VendorId { get; set; }

    public string? VendorAddress { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Ponumber { get; set; }

    public decimal? TotalAmount { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; } = new List<TblPurchaseOrderDetail>();

    public virtual TblVendor Vendor { get; set; } = null!;
}
