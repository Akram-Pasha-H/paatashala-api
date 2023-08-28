using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorDetail
{
    public long Id { get; set; }

    public long? IndicatorId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblIndicator? Indicator { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblIndicatorResult> TblIndicatorResults { get; set; } = new List<TblIndicatorResult>();
}
