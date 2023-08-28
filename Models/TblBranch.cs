using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblBranch
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public long? InstId { get; set; }

    public long OrgId { get; set; }

    public virtual TblInstitution? Inst { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
