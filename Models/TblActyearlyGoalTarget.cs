using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActyearlyGoalTarget
{
    public long Id { get; set; }

    public string? Goal { get; set; }

    public string? PlanOfAction { get; set; }

    public long? HeaderId { get; set; }

    public virtual TblActyearlyGoalHeader? Header { get; set; }

    public virtual ICollection<TblActyearlyGoalPerson> TblActyearlyGoalPeople { get; set; } = new List<TblActyearlyGoalPerson>();
}
