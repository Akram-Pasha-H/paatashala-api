using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAssignment
{
    public long Id { get; set; }

    public long CourseId { get; set; }

    public long BatchId { get; set; }

    public long SubjectId { get; set; }

    public string? AssignmentName { get; set; }

    public DateTime DateOfAssignment { get; set; }

    public long OrgId { get; set; }

    public virtual TblBatch Batch { get; set; } = null!;

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblSubject Subject { get; set; } = null!;

    public virtual ICollection<TblAssignmentQuestion> TblAssignmentQuestions { get; set; } = new List<TblAssignmentQuestion>();
}
