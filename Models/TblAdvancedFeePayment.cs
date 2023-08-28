using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAdvancedFeePayment
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public bool? IsRegularCourse { get; set; }

    public long? CourseId { get; set; }

    public long? OtherCourseId { get; set; }

    public long? BatchId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime PaidDate { get; set; }

    public string? Narration { get; set; }

    public long? PaymentMode { get; set; }

    public long? Bank { get; set; }

    public string? PaymentDetails { get; set; }

    public long? OrgId { get; set; }

    public bool? IsBilling { get; set; }

    public long? BillingTemplateId { get; set; }

    public string? Status { get; set; }

    public decimal? Balance { get; set; }

    public string? AdvReceiptNumber { get; set; }

    public virtual TblBankDetail? BankNavigation { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOtherProgram? OtherCourse { get; set; }

    public virtual TblFeePaymentMode? PaymentModeNavigation { get; set; }

    public virtual TblStudent Student { get; set; } = null!;
}
