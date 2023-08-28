using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCourseSubject
{
    public long Id { get; set; }

    public long SubjectId { get; set; }

    public long CourseId { get; set; }

    public DateTime? Year { get; set; }

    public long OrgId { get; set; }

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblSubject Subject { get; set; } = null!;
}
