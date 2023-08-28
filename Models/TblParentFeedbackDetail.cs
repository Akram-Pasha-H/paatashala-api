using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblParentFeedbackDetail
{
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public long? QuestionId { get; set; }

    public int? Answer { get; set; }

    public virtual TblParentFeedbackHeader? Header { get; set; }

    public virtual TblStudentFeedbackMobileAppQuestion? Question { get; set; }
}
