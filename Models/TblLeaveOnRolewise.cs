using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLeaveOnRolewise
{
    public long Id { get; set; }

    public long? LeaveTypeId { get; set; }

    public long? RoleId { get; set; }

    public int? MaxAllotted { get; set; }

    public bool? CarryNextMonth { get; set; }

    public bool? CarryNextYear { get; set; }

    public long? OrgId { get; set; }

    public virtual TblLeaveType? LeaveType { get; set; }
}
