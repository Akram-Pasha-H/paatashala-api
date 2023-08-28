using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVoucherList
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long MasterVoucherId { get; set; }

    public long OrgId { get; set; }

    public virtual TblMasterVoucherList MasterVoucher { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;
}
