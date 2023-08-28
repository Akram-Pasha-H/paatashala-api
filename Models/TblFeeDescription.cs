using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeeDescription
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblFeePaymentDetail> TblFeePaymentDetails { get; set; } = new List<TblFeePaymentDetail>();

    public virtual ICollection<TblPostDatedPayment> TblPostDatedPayments { get; set; } = new List<TblPostDatedPayment>();

    public virtual ICollection<TblStudentFeePaidHeader> TblStudentFeePaidHeaders { get; set; } = new List<TblStudentFeePaidHeader>();
}
