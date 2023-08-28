using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTrainingSessionDetail
{
    public long Id { get; set; }

    public long? SessionHeaderId { get; set; }

    public string? Content { get; set; }

    public virtual TblTrainingSessionHeader? SessionHeader { get; set; }
}
