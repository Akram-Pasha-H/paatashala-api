using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGrnPoHeader
{
    public long Id { get; set; }

    public DateTime? Grndate { get; set; }

    public long? VendorId { get; set; }

    public string? Address { get; set; }

    public string? Pono { get; set; }

    public long? TaxType { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? TotalTax { get; set; }

    public decimal? Total { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblGrnPoDetail> TblGrnPoDetails { get; set; } = new List<TblGrnPoDetail>();

    public virtual TblVendor? Vendor { get; set; }
}
