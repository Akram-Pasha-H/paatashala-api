using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssignmentQuestion
{
    public long Id { get; set; }

    public long AssignmentId { get; set; }

    public string? Question { get; set; }

    public long OrgId { get; set; }

    public virtual TblAssignment Assignment { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
