using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssetCategoryAttribute
{
    public long Id { get; set; }

    public long CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public long AttributeType { get; set; }

    public long OrgId { get; set; }

    public virtual TblAttributeType AttributeTypeNavigation { get; set; } = null!;

    public virtual TblAssetCategory Category { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblAssetAttribute> TblAssetAttributes { get; set; } = new List<TblAssetAttribute>();
}
