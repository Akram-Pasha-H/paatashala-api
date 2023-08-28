using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActyearlyGoalHeader
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public long? BatchId { get; set; }

    public long? UserOrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActyearlyGoalTarget> TblActyearlyGoalTargets { get; set; } = new List<TblActyearlyGoalTarget>();

    public virtual TblOrg? UserOrg { get; set; }
}
