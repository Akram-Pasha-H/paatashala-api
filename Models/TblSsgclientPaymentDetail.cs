using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSsgclientPaymentDetail
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public int? Month { get; set; }

    public DateTime? Year { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? AmountReceived { get; set; }

    public decimal? Balance { get; set; }

    public string? InvoiceId { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? InvoiceData { get; set; }

    public DateTime? InvoiceGeneratedOn { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblSsgarchiveClientPayment> TblSsgarchiveClientPayments { get; set; } = new List<TblSsgarchiveClientPayment>();
}
