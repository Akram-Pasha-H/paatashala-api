using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentResultsCce
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long? TermId { get; set; }

    public long? Faid { get; set; }

    public long? BlockId { get; set; }

    public long? SubBlockId { get; set; }

    public long? LearnoMeterId { get; set; }

    public long? Said { get; set; }

    public long? CourseId { get; set; }

    public long? BatchId { get; set; }

    public long? ExamId { get; set; }

    public long? SubjectId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
