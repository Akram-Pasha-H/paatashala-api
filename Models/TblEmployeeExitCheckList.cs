using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeExitCheckList
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
