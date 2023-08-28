using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblNationality
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
