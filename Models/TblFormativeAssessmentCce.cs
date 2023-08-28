using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFormativeAssessmentCce
{
    public long Id { get; set; }

    public long TermId { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblBlockCce> TblBlockCces { get; set; } = new List<TblBlockCce>();

    public virtual TblTermCce Term { get; set; } = null!;
}
