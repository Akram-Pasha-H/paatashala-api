using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPayGroup
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblPayGroupDetail> TblPayGroupDetails { get; set; } = new List<TblPayGroupDetail>();
}
