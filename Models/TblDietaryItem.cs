using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDietaryItem
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblDietPlanDetail> TblDietPlanDetails { get; set; } = new List<TblDietPlanDetail>();

    public virtual ICollection<TblDietPlanRecording> TblDietPlanRecordings { get; set; } = new List<TblDietPlanRecording>();
}
