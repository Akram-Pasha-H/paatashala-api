using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeePaymentDetail
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long FeeHeaderId { get; set; }

    public decimal? AmountPaid { get; set; }

    public long? OrgId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public long? PaymentMode { get; set; }

    public string? PaymentDetails { get; set; }

    public long? Bank { get; set; }

    public string? Narration { get; set; }

    public DateTime? DueDate { get; set; }

    public long? PaidForPeriodLinked { get; set; }

    public string? SubReceiptNumber { get; set; }

    public bool? IsCancelled { get; set; }

    public string? CancelledReason { get; set; }

    public virtual TblBankDetail? BankNavigation { get; set; }

    public virtual TblStudentFeePaidHeader FeeHeader { get; set; } = null!;

    public virtual TblOrg? Org { get; set; }

    public virtual TblFeeDescription? PaidForPeriodLinkedNavigation { get; set; }

    public virtual TblFeePaymentMode? PaymentModeNavigation { get; set; }

    public virtual TblStudent Student { get; set; } = null!;

    public virtual ICollection<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; } = new List<TblAdvanceFeeDebit>();
}
