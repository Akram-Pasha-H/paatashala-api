using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeAttendance
{
    public long Id { get; set; }

    public long EmpId { get; set; }

    public DateTime Date { get; set; }

    public bool IsPresent { get; set; }

    public long? LeaveType { get; set; }

    public long OrgId { get; set; }

    public long? AttendaceType { get; set; }

    public TimeSpan? CheckInTime { get; set; }

    public TimeSpan? CheckOutTime { get; set; }

    public virtual TblAttendanceConfig? AttendaceTypeNavigation { get; set; }

    public virtual TblEmployeeLeaveType? LeaveTypeNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
