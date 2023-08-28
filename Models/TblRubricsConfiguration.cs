using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRubricsConfiguration
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public long? RubricsId { get; set; }

    public long? ActorgId { get; set; }

    public virtual TblOrg? Actorg { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblIndicatorGroup? Rubrics { get; set; }
}
