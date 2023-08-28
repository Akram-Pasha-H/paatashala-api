using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamTypeLinkedWithSubject
{
    public long Id { get; set; }

    public long? ExamTypeId { get; set; }

    public long? CourseLinkedExamTypeId { get; set; }

    public long? SubjectId { get; set; }

    public int? MinMarks { get; set; }

    public int? MaxMarks { get; set; }

    public long? OrgId { get; set; }

    public virtual TblExamTypeLinkedWithCourse? CourseLinkedExamType { get; set; }

    public virtual TblExamType? ExamType { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubject? Subject { get; set; }
}
