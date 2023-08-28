using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeePaymentMode
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public bool? IsBilling { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblAdvancedFeePayment> TblAdvancedFeePayments { get; set; } = new List<TblAdvancedFeePayment>();

    public virtual ICollection<TblExpenseDetail> TblExpenseDetails { get; set; } = new List<TblExpenseDetail>();

    public virtual ICollection<TblFeePaymentDetail> TblFeePaymentDetails { get; set; } = new List<TblFeePaymentDetail>();

    public virtual ICollection<TblIncomeHeader> TblIncomeHeaders { get; set; } = new List<TblIncomeHeader>();

    public virtual ICollection<TblPostDatedPayment> TblPostDatedPayments { get; set; } = new List<TblPostDatedPayment>();

    public virtual ICollection<TblStudentFeePaidHeader> TblStudentFeePaidHeaders { get; set; } = new List<TblStudentFeePaidHeader>();
}
