using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActahreport
{
    public long Id { get; set; }

    public long? ReportHeaderId { get; set; }

    public long? VisitAgendaId { get; set; }

    public string? Report { get; set; }

    public string? Action { get; set; }

    public string? ByWhom { get; set; }

    public DateTime? ByWhen { get; set; }

    public string? Status { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblActahreportHeader? ReportHeader { get; set; }

    public virtual TblActvisitDetail? VisitAgenda { get; set; }
}
