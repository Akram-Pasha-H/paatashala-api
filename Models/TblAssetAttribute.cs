using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssetAttribute
{
    public long Id { get; set; }

    public long AssetId { get; set; }

    public string? String { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Decimal { get; set; }

    public long? Integer { get; set; }

    public long OrgId { get; set; }

    public long AssetCategoryAttributeId { get; set; }

    public virtual TblAsset Asset { get; set; } = null!;

    public virtual TblAssetCategoryAttribute AssetCategoryAttribute { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
