using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGrnDirectDetail
{
    public long Id { get; set; }

    public long HeaderId { get; set; }

    public long? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public long? Quantity { get; set; }

    public decimal? PricePerUnit { get; set; }

    public decimal? DiscountAmt { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? Unit { get; set; }

    public long? OrgId { get; set; }
}
