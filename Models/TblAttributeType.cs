using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAttributeType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TblAssetCategoryAttribute> TblAssetCategoryAttributes { get; set; } = new List<TblAssetCategoryAttribute>();
}
