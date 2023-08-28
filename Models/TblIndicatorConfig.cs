using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorConfig
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public long? IndicatorHeaderId { get; set; }

    public long? IndicatorId { get; set; }

    public long? LoggedUserOrgId { get; set; }

    public virtual TblIndicator? Indicator { get; set; }

    public virtual TblIndicatorGroup? IndicatorHeader { get; set; }

    public virtual TblOrg? LoggedUserOrg { get; set; }

    public virtual TblOrg? Org { get; set; }
}
