using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGroupMember
{
    public long Id { get; set; }

    public long GroupId { get; set; }

    public string? MemberEmail { get; set; }

    public string? MemberPhoneNumber { get; set; }

    public long OrgId { get; set; }

    public string MemberName { get; set; } = null!;

    public virtual TblGroup Group { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
