using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblItemVendor
{
    public long Id { get; set; }

    public long? VendorId { get; set; }

    public long? ItemId { get; set; }

    public long OrgId { get; set; }

    public virtual TblItem? Item { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblVendor? Vendor { get; set; }
}
