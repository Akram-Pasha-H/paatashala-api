using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSmscredential
{
    public long Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? SenderId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }
}
