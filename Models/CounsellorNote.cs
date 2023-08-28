using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class CounsellorNote
{
    public long Id { get; set; }

    public long CounsellorId { get; set; }

    public long StudentId { get; set; }

    public DateTime DateOfCounselling { get; set; }

    public string? Notes { get; set; }

    public long OrgId { get; set; }

    public virtual TblCounsellor Counsellor { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
