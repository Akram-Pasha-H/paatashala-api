using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSmstemplate
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Smscontent { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }
}
