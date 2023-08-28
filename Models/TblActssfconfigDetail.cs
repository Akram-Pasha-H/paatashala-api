using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActssfconfigDetail
{
    public long Id { get; set; }

    public long? ActssfconfigHeaderId { get; set; }

    public long? AssignedOrgId { get; set; }

    public virtual TblActssfconfigHeader? ActssfconfigHeader { get; set; }

    public virtual TblOrg? AssignedOrg { get; set; }
}
