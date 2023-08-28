using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblParentMessageBox
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public string? Contents { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? OrgId { get; set; }

    public string? Type { get; set; }

    public string? Response { get; set; }

    public long? MessageId { get; set; }

    public virtual TblAppParentMessageContent? Message { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }

    public virtual ICollection<TblParentMessageOption> TblParentMessageOptions { get; set; } = new List<TblParentMessageOption>();
}
