using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActvisitHeader
{
    public long Id { get; set; }

    public string? NameOfOrgVisiting { get; set; }

    public long? VisitingOrgId { get; set; }

    public DateTime? DateOfVisit { get; set; }

    public string? FacultyMembers { get; set; }

    public string? FocusAreas { get; set; }

    public long? OrgId { get; set; }

    public long? UserId { get; set; }

    public string? ExpectedDocument { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActahreportHeader> TblActahreportHeaders { get; set; } = new List<TblActahreportHeader>();

    public virtual ICollection<TblActvisitDetail> TblActvisitDetails { get; set; } = new List<TblActvisitDetail>();

    public virtual TblEmployee? User { get; set; }

    public virtual TblOrg? VisitingOrg { get; set; }
}
