using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSsgarchiveClientPayment
{
    public long Id { get; set; }

    public string ReceiptId { get; set; } = null!;

    public long OrgId { get; set; }

    public long ClientPaymentDetailId { get; set; }

    public decimal Paid { get; set; }

    public DateTime PaidOn { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? PaymentDetails { get; set; }

    public DateTime LastUpdatedOn { get; set; }

    public string? TransactionNumber { get; set; }

    public int? TransactionType { get; set; }

    public virtual TblSsgclientPaymentDetail ClientPaymentDetail { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
