using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActExitInterviewResultDetail
{
    public long Id { get; set; }

    public long HeaderId { get; set; }

    public long QuestionId { get; set; }

    public decimal Score { get; set; }

    public virtual TblActexitInterviewResultHeader Header { get; set; } = null!;
}
