using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActssfconfigHeader
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActssfconfigDetail> TblActssfconfigDetails { get; set; } = new List<TblActssfconfigDetail>();
}
