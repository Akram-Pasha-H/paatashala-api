using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActmentoringUnPlanned
{
    public long Id { get; set; }

    public long? TeacherId { get; set; }

    public long? StudentId { get; set; }

    public DateTime? Date { get; set; }

    public string? Interaction { get; set; }

    public string? Remarks { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblEmployee? Teacher { get; set; }
}
