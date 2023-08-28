using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingSessionHeader
{
    public long Id { get; set; }

    public int? SessionId { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public int? Day { get; set; }

    public long? TrainingId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblTrainingSessionDetail> TblTrainingSessionDetails { get; set; } = new List<TblTrainingSessionDetail>();

    public virtual TblTrainingHeader? Training { get; set; }
}
