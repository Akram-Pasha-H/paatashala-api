using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPaatashalaBilling
{
    public long Id { get; set; }

    public int Month { get; set; }

    public DateTime Year { get; set; }

    public int? ActiveStudentCount { get; set; }

    public int? InActiveStudentCount { get; set; }

    public int? OtherProgramStudentCount { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }
}
