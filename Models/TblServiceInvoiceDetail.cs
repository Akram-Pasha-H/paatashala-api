using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblServiceInvoiceDetail
{
    public long Id { get; set; }

    public long? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public long? Quantity { get; set; }

    public long? Unit { get; set; }

    public decimal? RatePerUnit { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? Amount { get; set; }

    public long OrgId { get; set; }
}
