using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorResult
{
    public long Id { get; set; }

    public long? IndicatorResultHeaderId { get; set; }

    public int? Points { get; set; }

    public long? IndicatorDetailId { get; set; }

    public long? EmpId { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblIndicatorDetail? IndicatorDetail { get; set; }

    public virtual TblIndicatorResultHeader? IndicatorResultHeader { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
