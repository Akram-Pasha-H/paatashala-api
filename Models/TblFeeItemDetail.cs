using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeeItemDetail
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? LedgerGroup { get; set; }

    public string? Uom { get; set; }

    public decimal? RatePerUnit { get; set; }

    public long? BillingType { get; set; }

    public decimal? StandardRate { get; set; }

    public long OrgId { get; set; }

    public bool? IsBilling { get; set; }

    public virtual TblFeeLedgerGroup? LedgerGroupNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblCourseFeeDetail> TblCourseFeeDetails { get; set; } = new List<TblCourseFeeDetail>();

    public virtual ICollection<TblFeeLinkedInventoryItem> TblFeeLinkedInventoryItems { get; set; } = new List<TblFeeLinkedInventoryItem>();

    public virtual ICollection<TblFeePaidDetail> TblFeePaidDetails { get; set; } = new List<TblFeePaidDetail>();
}
