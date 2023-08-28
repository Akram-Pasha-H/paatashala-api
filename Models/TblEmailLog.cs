using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmailLog
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public long? UserId { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailContent { get; set; }

    public string? EmailId { get; set; }

    public string? Status { get; set; }

    public DateTime? DateTime { get; set; }

    public bool? IsStaff { get; set; }

    public long? RecieverId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployee? User { get; set; }
}
