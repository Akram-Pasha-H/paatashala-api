using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLearnoMeterCce
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long TermId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblTermCce Term { get; set; } = null!;
}
