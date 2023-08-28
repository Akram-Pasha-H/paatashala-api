using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeGroupHeader
{
    public long Id { get; set; }

    public string? GroupName { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblEmployeeGroupDetail> TblEmployeeGroupDetails { get; set; } = new List<TblEmployeeGroupDetail>();
}
