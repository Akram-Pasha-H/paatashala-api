using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorPoint
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? MaxPoints { get; set; }

    public int? MinPoints { get; set; }

    public long? IndicatorId { get; set; }

    public long OrgId { get; set; }

    public virtual TblIndicator? Indicator { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
