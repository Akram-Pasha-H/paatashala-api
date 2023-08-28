using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExitInterviewQuestionnaire
{
    public long Id { get; set; }

    public string Question { get; set; } = null!;

    public long DepartmentId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
