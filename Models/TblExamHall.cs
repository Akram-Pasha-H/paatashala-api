using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamHall
{
    public long Id { get; set; }

    public string? HallNumber { get; set; }

    public long? SeatingCapacity { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblExamSchedule> TblExamSchedules { get; set; } = new List<TblExamSchedule>();
}
