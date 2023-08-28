using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActdailyPlanDetail
{
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public DateTime? Date { get; set; }

    public string? Day { get; set; }

    public string? Concept { get; set; }

    public string? Objective { get; set; }

    public string? Task { get; set; }

    public string? Resources { get; set; }

    public string? Assessment { get; set; }

    public string? ReInforcement { get; set; }

    public int? Status { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActdailyPlanHeader? Header { get; set; }

    public virtual TblOrg? Org { get; set; }
}
