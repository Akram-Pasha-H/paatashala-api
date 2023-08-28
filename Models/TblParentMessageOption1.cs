using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblParentMessageOption1
{
    public long Id { get; set; }

    public string? OptionValue { get; set; }

    public long? OrgId { get; set; }

    public long? MessageId { get; set; }

    public virtual TblAppParentMessageContent? Message { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblParentMessageOption> TblParentMessageOptions { get; set; } = new List<TblParentMessageOption>();
}
