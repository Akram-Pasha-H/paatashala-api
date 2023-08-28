using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRoyaltyFeeCollection
{
    public long Id { get; set; }

    public long OrgId { get; set; }

    public long FranchiseDetailsId { get; set; }

    public string Week { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TblFranchiseDetail FranchiseDetails { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
