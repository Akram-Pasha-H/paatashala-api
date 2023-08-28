using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGrievanceRecord
{
    public long Id { get; set; }

    public long? CategoryId { get; set; }

    public string? GrievanceDescription { get; set; }

    public DateTime? Date { get; set; }

    public long? RecordedBy { get; set; }

    public string? ActionTaken { get; set; }

    public DateTime? ActionTakenDate { get; set; }

    public string? Status { get; set; }

    public long? OrgId { get; set; }

    public virtual TblGrievanceCategory? Category { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployee? RecordedByNavigation { get; set; }
}
