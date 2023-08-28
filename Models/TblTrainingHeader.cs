using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingHeader
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public long? OrgId { get; set; }

    public virtual ICollection<TblActtrainingFeedbackHeader> TblActtrainingFeedbackHeaders { get; set; } = new List<TblActtrainingFeedbackHeader>();

    public virtual ICollection<TblTrainingAttendance> TblTrainingAttendances { get; set; } = new List<TblTrainingAttendance>();

    public virtual ICollection<TblTrainingReportReview> TblTrainingReportReviews { get; set; } = new List<TblTrainingReportReview>();

    public virtual ICollection<TblTrainingScheduleHeader> TblTrainingScheduleHeaders { get; set; } = new List<TblTrainingScheduleHeader>();

    public virtual ICollection<TblTrainingSessionHeader> TblTrainingSessionHeaders { get; set; } = new List<TblTrainingSessionHeader>();
}
