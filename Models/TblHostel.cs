using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblHostel
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? ContactNumber { get; set; }

    public long? HostelType { get; set; }

    public string? WardenName { get; set; }

    public long OrgId { get; set; }

    public virtual TblHostelType? HostelTypeNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblHostelRoom> TblHostelRooms { get; set; } = new List<TblHostelRoom>();
}
