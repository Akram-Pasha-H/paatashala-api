using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblFeePaidDetail
{
    public long Id { get; set; }

    public long FeePaidHeader { get; set; }

    public long FeeItemId { get; set; }

    public decimal Amount { get; set; }

    public long OrgId { get; set; }

    public bool? IsBilling { get; set; }

    public virtual TblFeeItemDetail FeeItem { get; set; } = null!;

    public virtual TblStudentFeePaidHeader FeePaidHeaderNavigation { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
