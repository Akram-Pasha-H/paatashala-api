using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGrievanceCategory
{
    public long Id { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblGrievanceRecord> TblGrievanceRecords { get; set; } = new List<TblGrievanceRecord>();
}
