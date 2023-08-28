using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActvisitDetail
{
    public long Id { get; set; }

    public long? ActVisitHeaderId { get; set; }

    public int? Day { get; set; }

    public string? AgendaDetails { get; set; }

    public long? OrgId { get; set; }

    public virtual TblActvisitHeader? ActVisitHeader { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActahreport> TblActahreports { get; set; } = new List<TblActahreport>();
}
