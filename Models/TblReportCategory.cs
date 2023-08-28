using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblReportCategory
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TblReportSentDetail> TblReportSentDetails { get; set; } = new List<TblReportSentDetail>();
}
