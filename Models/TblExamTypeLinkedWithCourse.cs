using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamTypeLinkedWithCourse
{
    public long Id { get; set; }

    public long? ExamTypeId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public int? FrequencyDuration { get; set; }

    public int? FrequencyType { get; set; }

    public long? OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblExamType? ExamType { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblExamTypeLinkedWithSubject> TblExamTypeLinkedWithSubjects { get; set; } = new List<TblExamTypeLinkedWithSubject>();
}
