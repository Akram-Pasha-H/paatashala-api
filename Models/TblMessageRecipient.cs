using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMessageRecipient
{
    public long Id { get; set; }

    public long FromId { get; set; }

    public long ToId { get; set; }

    public bool IsRead { get; set; }

    public long OrgId { get; set; }

    public virtual TblMessageCenter From { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblEmployee To { get; set; } = null!;
}
