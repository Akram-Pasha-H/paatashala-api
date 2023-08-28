using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAbsentAttendance
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public DateTime? Date { get; set; }

    public long? Batch { get; set; }

    public long? Course { get; set; }

    public bool? IsAllStudentAbset { get; set; }

    public long? OtherProgram { get; set; }

    public long? AttendanceType { get; set; }

    public virtual TblAttendanceConfig? AttendanceTypeNavigation { get; set; }

    public virtual TblBatch? BatchNavigation { get; set; }

    public virtual TblCourse? CourseNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
