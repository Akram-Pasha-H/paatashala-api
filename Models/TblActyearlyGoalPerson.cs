using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActyearlyGoalPerson
{
    public long Id { get; set; }

    public long? GoalId { get; set; }

    public long? EmpId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblActyearlyGoalTarget? Goal { get; set; }

    public virtual TblOrg? Org { get; set; }
}
