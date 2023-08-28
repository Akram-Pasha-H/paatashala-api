using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamAttributeWiseMark
{
    public long Id { get; set; }

    public long? ExamScheduleId { get; set; }

    public long? SubjectId { get; set; }

    public long? StudentId { get; set; }

    public long? ComponentId { get; set; }

    public decimal? Mark { get; set; }

    public long? OrgId { get; set; }

    public long? AttributeId { get; set; }

    public virtual TblSubComponentAttribute? Attribute { get; set; }

    public virtual TblSubjectSubComponent? Component { get; set; }

    public virtual TblExamSchedule? ExamSchedule { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual TblSubject? Subject { get; set; }
}
