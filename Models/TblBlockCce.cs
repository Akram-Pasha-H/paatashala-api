using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblBlockCce
{
    public long Id { get; set; }

    public long FormativeAssessmentId { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblFormativeAssessmentCce FormativeAssessment { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblSubBlockCce> TblSubBlockCces { get; set; } = new List<TblSubBlockCce>();
}
