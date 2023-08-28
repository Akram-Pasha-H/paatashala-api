using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblServiceInvoiceHeader
{
    public long Id { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Ponumber { get; set; }

    public DateTime? Podate { get; set; }

    public long? CustomerId { get; set; }

    public string? Address { get; set; }

    public string? TinOrCst { get; set; }

    public long? TaxType { get; set; }

    public long? TradeDiscountPercent { get; set; }

    public long? SpecialDiscountPercent { get; set; }

    public long? TotalTax { get; set; }

    public decimal? Total { get; set; }
}
