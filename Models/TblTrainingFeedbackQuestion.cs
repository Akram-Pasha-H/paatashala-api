using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingFeedbackQuestion
{
    public long Id { get; set; }

    public string? Question { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActtrainingFeedbackDetail> TblActtrainingFeedbackDetails { get; set; } = new List<TblActtrainingFeedbackDetail>();
}
