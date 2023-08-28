using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVendor
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

    public string? ContactPerson { get; set; }

    public string? ZipCode { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblExpenseDetail> TblExpenseDetails { get; set; } = new List<TblExpenseDetail>();

    public virtual ICollection<TblGrnPoHeader> TblGrnPoHeaders { get; set; } = new List<TblGrnPoHeader>();

    public virtual ICollection<TblItemVendor> TblItemVendors { get; set; } = new List<TblItemVendor>();

    public virtual ICollection<TblPettyCashDetail> TblPettyCashDetails { get; set; } = new List<TblPettyCashDetail>();

    public virtual ICollection<TblPurchaseOrderHeader> TblPurchaseOrderHeaders { get; set; } = new List<TblPurchaseOrderHeader>();
}
