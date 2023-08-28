using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblItemCategory
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblItem> TblItems { get; set; } = new List<TblItem>();
}
