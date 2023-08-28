using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHostelType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblHostel> TblHostels { get; set; } = new List<TblHostel>();
}
