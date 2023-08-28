using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentFeedbackMobileAppQuestion
{
    public long Id { get; set; }

    public string? Question { get; set; }

    public long? RoleId { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual ICollection<TblParentFeedbackDetail> TblParentFeedbackDetails { get; set; } = new List<TblParentFeedbackDetail>();
}
