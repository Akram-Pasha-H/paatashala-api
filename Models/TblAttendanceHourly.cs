using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAttendanceHourly
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public TimeSpan Time { get; set; }

    public DateTime Date { get; set; }

    public bool? IsPickUp { get; set; }

    public bool? IsAttendance { get; set; }

    public long OrgId { get; set; }

    public long? AttendanceType { get; set; }

    public TimeSpan? CheckOutTime { get; set; }

    public virtual TblAttendanceConfig? AttendanceTypeNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
