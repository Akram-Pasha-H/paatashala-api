using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeLeaveType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblEmployeeAttendance> TblEmployeeAttendances { get; set; } = new List<TblEmployeeAttendance>();
}
