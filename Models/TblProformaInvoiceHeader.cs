using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblProformaInvoiceHeader
{
    public long Id { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public long? Ponumber { get; set; }

    public DateTime? Podate { get; set; }

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public long? TinOrCst { get; set; }

    public long? TaxType { get; set; }

    public long? TradeDiscountPercent { get; set; }

    public long? SpecialDiscountPercent { get; set; }

    public long? TotalTax { get; set; }

    public long? Total { get; set; }
}
