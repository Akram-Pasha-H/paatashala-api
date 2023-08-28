using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFinancialYear
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblFranchiseDetail> TblFranchiseDetails { get; set; } = new List<TblFranchiseDetail>();
}
