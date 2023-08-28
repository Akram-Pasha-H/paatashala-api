using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudentKitItem
{
    public long Id { get; set; }

    public long? StudentKitId { get; set; }

    public long? Item { get; set; }

    public long? Quantity { get; set; }

    public long? OrgId { get; set; }

    public virtual TblStockItem? ItemNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudentKit? StudentKit { get; set; }
}
