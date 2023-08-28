using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExpenseDetail
{
    public long Id { get; set; }

    public long? VendorId { get; set; }

    public string? ExpenseName { get; set; }

    public long? Category { get; set; }

    public decimal? Value { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Rate { get; set; }

    public long? Quantity { get; set; }

    public string? Guid { get; set; }

    public long? OrgId { get; set; }

    public long? PaymentMode { get; set; }

    public long? Bank { get; set; }

    public string? PaymentDetails { get; set; }

    public decimal? GrandTotal { get; set; }

    public virtual TblBankDetail? BankNavigation { get; set; }

    public virtual TblExpenseCategory? CategoryNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblFeePaymentMode? PaymentModeNavigation { get; set; }

    public virtual TblVendor? Vendor { get; set; }
}
