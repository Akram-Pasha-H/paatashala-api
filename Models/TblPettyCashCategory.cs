using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPettyCashCategory
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblPettyCashDetail> TblPettyCashDetails { get; set; } = new List<TblPettyCashDetail>();
}
