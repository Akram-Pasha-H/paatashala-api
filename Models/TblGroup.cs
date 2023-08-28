using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGroup
{
    public long Id { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblGroupMember> TblGroupMembers { get; set; } = new List<TblGroupMember>();
}
