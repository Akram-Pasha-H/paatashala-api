using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExpenditureDoc
{
    public long Id { get; set; }

    public string? Guid { get; set; }

    public byte[]? ExpenditureFiles { get; set; }

    public long? OrgId { get; set; }

    public string? ExpenditureFileName { get; set; }

    public virtual TblOrg? Org { get; set; }
}
