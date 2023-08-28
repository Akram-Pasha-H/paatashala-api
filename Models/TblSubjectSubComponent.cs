using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSubjectSubComponent
{
    public long Id { get; set; }

    public string? SubComponentName { get; set; }

    public long? SubjectId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubject? Subject { get; set; }

    public virtual ICollection<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; } = new List<TblExamAttributeWiseMark>();

    public virtual ICollection<TblExamMark> TblExamMarks { get; set; } = new List<TblExamMark>();

    public virtual ICollection<TblSubComponentAttribute> TblSubComponentAttributes { get; set; } = new List<TblSubComponentAttribute>();
}
