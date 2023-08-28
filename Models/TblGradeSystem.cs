using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblGradeSystem
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public bool? IsCoscholastic { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblGradesystemDetail> TblGradesystemDetails { get; set; } = new List<TblGradesystemDetail>();
}
