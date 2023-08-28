using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCounsellor
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public long OrgId { get; set; }

    public virtual ICollection<CounsellorNote> CounsellorNotes { get; set; } = new List<CounsellorNote>();

    public virtual TblOrg Org { get; set; } = null!;
}
