using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIssueList
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public DateTime? Date { get; set; }

    public long? LoggedBy { get; set; }

    public long? Status { get; set; }

    public long? OrgId { get; set; }

    public virtual TblLogin? LoggedByNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }
}
