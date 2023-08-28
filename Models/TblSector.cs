using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSector
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblOrg> TblOrgs { get; set; } = new List<TblOrg>();
}
