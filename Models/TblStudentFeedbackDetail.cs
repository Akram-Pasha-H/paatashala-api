using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentFeedbackDetail
{
    public long Id { get; set; }

    public long StudentFeedbackId { get; set; }

    public long QuestionnaireId { get; set; }

    public int? Points { get; set; }

    public long? TeacherId { get; set; }

    public long? SubjectId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudentFeedbackQuestionnaire Questionnaire { get; set; } = null!;

    public virtual TblStudentFeedbackMain StudentFeedback { get; set; } = null!;

    public virtual TblSubject? Subject { get; set; }

    public virtual TblEmployee? Teacher { get; set; }
}
