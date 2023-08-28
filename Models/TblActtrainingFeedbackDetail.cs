using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActtrainingFeedbackDetail
{
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public long? QuestionId { get; set; }

    public int? Score { get; set; }

    public virtual TblActtrainingFeedbackHeader? Header { get; set; }

    public virtual TblTrainingFeedbackQuestion? Question { get; set; }
}
