using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIncomeHeader
{
    public long Id { get; set; }

    public string? FromName { get; set; }

    public string? Description { get; set; }

    public decimal? RecievedOn { get; set; }

    public long? ModeOfPayment { get; set; }

    public string? PaymentDetails { get; set; }

    public long? OrgId { get; set; }

    public virtual TblFeePaymentMode? ModeOfPaymentNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }
}
