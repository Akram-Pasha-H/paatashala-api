using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicator
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? IndicatorGroupId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblIndicatorConfig> TblIndicatorConfigs { get; set; } = new List<TblIndicatorConfig>();

    public virtual ICollection<TblIndicatorDetail> TblIndicatorDetails { get; set; } = new List<TblIndicatorDetail>();

    public virtual ICollection<TblIndicatorPoint> TblIndicatorPoints { get; set; } = new List<TblIndicatorPoint>();
}
