using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMessageAttachment
{
    public long Id { get; set; }

    public long FromId { get; set; }

    public byte[]? Attachments { get; set; }

    public long OrgId { get; set; }

    public virtual TblMessageCenter From { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
