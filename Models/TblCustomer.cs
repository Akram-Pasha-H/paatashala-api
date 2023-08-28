using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCustomer
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public decimal? OpeningBalance { get; set; }

    public string? BalanceType { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public long? Phone { get; set; }

    public long? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public long? TinOrLst { get; set; }

    public long? Cstnumber { get; set; }

    public long? TradeDiscountPercent { get; set; }

    public long? CashDiscount { get; set; }

    public long? TradeDiscount { get; set; }

    public bool? CreditAllow { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
