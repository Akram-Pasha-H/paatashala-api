using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTaxInvoiceHeader
{
    public long Id { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Ponumber { get; set; }

    public DateTime? Podate { get; set; }

    public long? Customer { get; set; }

    public string? Address { get; set; }

    public long? TinOrCst { get; set; }

    public long? TaxType { get; set; }

    public long? TradeDiscountPercent { get; set; }

    public long? SpecialDiscountPercent { get; set; }

    public long? TotalTax { get; set; }
}
