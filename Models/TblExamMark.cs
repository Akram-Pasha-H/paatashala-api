using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamMark
{
    public long Id { get; set; }

    public long ExamSchdeduleId { get; set; }

    public long SubjectId { get; set; }

    public long StudentId { get; set; }

    public decimal Marks { get; set; }

    public long OrgId { get; set; }

    public long? SubjectComponenetId { get; set; }

    public virtual TblExamSchedule ExamSchdedule { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;

    public virtual TblSubject Subject { get; set; } = null!;

    public virtual TblSubjectSubComponent? SubjectComponenet { get; set; }
}
