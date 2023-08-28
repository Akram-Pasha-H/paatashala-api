using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAppParentMessageContent
{
    public long Id { get; set; }

    public string? Contents { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Type { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblParentMessageBox> TblParentMessageBoxes { get; set; } = new List<TblParentMessageBox>();

    public virtual ICollection<TblParentMessageOption1> TblParentMessageOption1s { get; set; } = new List<TblParentMessageOption1>();
}
