using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActexitInterviewResultHeader
{
    public long Id { get; set; }

    public long EmpId { get; set; }

    public string? Comments { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployee Emp { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblActExitInterviewResultDetail> TblActExitInterviewResultDetails { get; set; } = new List<TblActExitInterviewResultDetail>();
}
