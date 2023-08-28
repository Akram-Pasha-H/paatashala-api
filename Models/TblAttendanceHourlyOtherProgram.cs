using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAttendanceHourlyOtherProgram
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public long? OtherProgramId { get; set; }

    public long? OrgId { get; set; }

    public TimeSpan? Time { get; set; }

    public bool? IsPickUp { get; set; }

    public bool? IsAttendance { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? CheckOutTime { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOtherProgram? OtherProgram { get; set; }

    public virtual TblStudent? Student { get; set; }
}
