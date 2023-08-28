using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentFeePaidHeader
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public DateTime DatePaid { get; set; }

    public string? PaidForPeriod { get; set; }

    public long Course { get; set; }

    public long Batch { get; set; }

    public decimal GrandTotal { get; set; }

    public long? PaymentMode { get; set; }

    public string? PaymentDetails { get; set; }

    public long? Bank { get; set; }

    public long OrgId { get; set; }

    public string? ReceiptNumber { get; set; }

    public bool? IsBilling { get; set; }

    public long? BillingTemplateId { get; set; }

    public string? Narration { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? Discount { get; set; }

    public bool? IsDiscountPercent { get; set; }

    public decimal? Balance { get; set; }

    public bool? IsPaid { get; set; }

    public long? PaidForPeriodLinked { get; set; }

    public long? OtherProgram { get; set; }

    public long? InstallmentPlan { get; set; }

    public bool? IsDiscountShow { get; set; }

    public virtual TblBankDetail? BankNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblFeeDescription? PaidForPeriodLinkedNavigation { get; set; }

    public virtual TblFeePaymentMode? PaymentModeNavigation { get; set; }

    public virtual TblStudent Student { get; set; } = null!;

    public virtual ICollection<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; } = new List<TblAdvanceFeeDebit>();

    public virtual ICollection<TblFeePaidDetail> TblFeePaidDetails { get; set; } = new List<TblFeePaidDetail>();

    public virtual ICollection<TblFeePaymentDetail> TblFeePaymentDetails { get; set; } = new List<TblFeePaymentDetail>();

    public virtual ICollection<TblPostDatedPayment> TblPostDatedPayments { get; set; } = new List<TblPostDatedPayment>();
}
