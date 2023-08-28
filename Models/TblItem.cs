using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblItem
{
    public long Id { get; set; }

    public long? CategoryId { get; set; }

    public string? ItemName { get; set; }

    public long? ItemCode { get; set; }

    public decimal? CostPrice { get; set; }

    public long? Quantity { get; set; }

    public long? RebatePercentCp { get; set; }

    public long? RebateOnCp { get; set; }

    public decimal? SpperUnit { get; set; }

    public bool? IsVatIncluded { get; set; }

    public decimal? MrpperUnit { get; set; }

    public long? DiscountPercent { get; set; }

    public decimal? Cstpercent { get; set; }

    public long? ItemStatus { get; set; }

    public bool? IsActive { get; set; }

    public long? MinQuantity { get; set; }

    public long? MaxQuantity { get; set; }

    public DateTime? DateOfPurchase { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Shape { get; set; }

    public string? Currency { get; set; }

    public byte[]? Picture { get; set; }

    public long OrgId { get; set; }

    public virtual TblItemCategory? Category { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblItemVendor> TblItemVendors { get; set; } = new List<TblItemVendor>();
}
