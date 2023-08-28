using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblQuestionBank
{
    public long QbankId { get; set; }

    public long TopicId { get; set; }

    public string QuestionHtml { get; set; } = null!;

    public string AnswerHtml { get; set; } = null!;

    public long OrgId { get; set; }

    public double MarksForQuestion { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblTopic Topic { get; set; } = null!;
}
