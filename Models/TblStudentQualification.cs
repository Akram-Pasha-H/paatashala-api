using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentQualification
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public string? SchoolName { get; set; }

    public string? ClassOrCourse { get; set; }

    public DateTime? YearPassed { get; set; }

    public long? Percentage { get; set; }

    public long ReasonForExit { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudentPrevQualificationReason ReasonForExitNavigation { get; set; } = null!;

    public virtual TblStudent? Student { get; set; }
}
