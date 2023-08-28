using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblParentFeedbackHeader
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public DateTime? Date { get; set; }

    public string? Comments { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual ICollection<TblParentFeedbackDetail> TblParentFeedbackDetails { get; set; } = new List<TblParentFeedbackDetail>();
}
