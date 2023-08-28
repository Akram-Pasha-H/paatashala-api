using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMessageCenter
{
    public long Id { get; set; }

    public long EmpId { get; set; }

    public string? MessageBody { get; set; }

    public string? MessageTitle { get; set; }

    public DateTime SentDate { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployee Emp { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblMessageAttachment> TblMessageAttachments { get; set; } = new List<TblMessageAttachment>();

    public virtual ICollection<TblMessageRecipient> TblMessageRecipients { get; set; } = new List<TblMessageRecipient>();
}
