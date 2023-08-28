using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingScheduleHeader
{
    public long Id { get; set; }

    public long? TrainingNameId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Location { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblTraningSchedule> TblTraningSchedules { get; set; } = new List<TblTraningSchedule>();

    public virtual TblTrainingHeader? TrainingName { get; set; }
}
