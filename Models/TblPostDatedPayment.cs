using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPostDatedPayment
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public long? FeeHeaderId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public long? PaymentMode { get; set; }

    public string? PaymentDetails { get; set; }

    public long? Bank { get; set; }

    public string? Narration { get; set; }

    public long? PaidForPeriod { get; set; }

    public string? SubReceiptNumber { get; set; }

    public bool? IsCleared { get; set; }

    public long? OrgId { get; set; }

    public DateTime? PostedDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int? Status { get; set; }

    public string? Reason { get; set; }

    public virtual TblBankDetail? BankNavigation { get; set; }

    public virtual TblStudentFeePaidHeader? FeeHeader { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblFeeDescription? PaidForPeriodNavigation { get; set; }

    public virtual TblFeePaymentMode? PaymentModeNavigation { get; set; }

    public virtual TblStudent? Student { get; set; }
}
