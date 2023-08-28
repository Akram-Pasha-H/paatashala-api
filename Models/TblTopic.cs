using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTopic
{
    public long TopicId { get; set; }

    public long SubjectId { get; set; }

    public string TopicName { get; set; } = null!;

    public long OrgId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblSubject Subject { get; set; } = null!;

    public virtual ICollection<TblQuestionBank> TblQuestionBanks { get; set; } = new List<TblQuestionBank>();
}
