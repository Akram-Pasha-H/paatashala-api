using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAttendanceConfig
{
    public long Id { get; set; }

    public string AttendanceName { get; set; } = null!;

    public long OrgId { get; set; }

    public bool IsStudent { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblAbsentAttendance> TblAbsentAttendances { get; set; } = new List<TblAbsentAttendance>();

    public virtual ICollection<TblAttendanceHourly> TblAttendanceHourlies { get; set; } = new List<TblAttendanceHourly>();

    public virtual ICollection<TblEmployeeAttendance> TblEmployeeAttendances { get; set; } = new List<TblEmployeeAttendance>();
}
