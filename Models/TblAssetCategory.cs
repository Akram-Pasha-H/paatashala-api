using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssetCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblAssetCategoryAttribute> TblAssetCategoryAttributes { get; set; } = new List<TblAssetCategoryAttribute>();

    public virtual ICollection<TblAsset> TblAssets { get; set; } = new List<TblAsset>();
}
