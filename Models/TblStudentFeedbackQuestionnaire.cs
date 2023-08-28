using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentFeedbackQuestionnaire
{
    public long Id { get; set; }

    public string? Question { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblStudentFeedbackDetail> TblStudentFeedbackDetails { get; set; } = new List<TblStudentFeedbackDetail>();
}
