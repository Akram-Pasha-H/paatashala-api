using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTimeTableDetail
{
    public long Id { get; set; }

    public long? WorkingDays { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public long? TimeTableId { get; set; }

    public long? FacultyId { get; set; }

    public long? SubjectId { get; set; }

    public long OrgId { get; set; }

    public bool? IsVisual { get; set; }

    public long? PhotoId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblVisualTimeTablePhotoType? Photo { get; set; }

    public virtual TblTimeTable? TimeTable { get; set; }
}
