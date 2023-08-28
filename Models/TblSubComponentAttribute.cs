using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSubComponentAttribute
{
    public long Id { get; set; }

    public string? AttributeName { get; set; }

    public long? SubCompId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubjectSubComponent? SubComp { get; set; }

    public virtual ICollection<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; } = new List<TblExamAttributeWiseMark>();
}
