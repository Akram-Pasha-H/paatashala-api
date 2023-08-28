using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGradesystemDetail
{
    public long Id { get; set; }

    public string? Grade { get; set; }

    public long? MinMarks { get; set; }

    public long? MaxMarks { get; set; }

    public long? GradeSystemId { get; set; }

    public long OrgId { get; set; }

    public string? Remarks { get; set; }

    public virtual TblGradeSystem? GradeSystem { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
