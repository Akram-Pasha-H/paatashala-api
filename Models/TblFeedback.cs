using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeedback
{
    public long Id { get; set; }

    public string? FeedbackText { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public long? EmployeeId { get; set; }

    public long? StudentId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Employee { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }
}
