using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActahreportHeader
{
    public long Id { get; set; }

    public string? Introduction { get; set; }

    public string? NextVisitSchedule { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public long? ActvisitHeaderId { get; set; }

    public long? OrgId { get; set; }

    public string? Others { get; set; }

    public string? PrincipalPoints { get; set; }

    public string? ManagementPoints { get; set; }

    public string? Observation { get; set; }

    public virtual TblActvisitHeader? ActvisitHeader { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActahreport> TblActahreports { get; set; } = new List<TblActahreport>();
}
