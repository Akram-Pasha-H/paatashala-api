using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblAppMenuDefinition
{
    public long Id { get; set; }

    public long? MenuNameId { get; set; }

    public int Sequence { get; set; }

    public long? LoginType { get; set; }

    public long? OrgId { get; set; }

    public virtual TblAppMenuName? MenuName { get; set; }

    public virtual TblOrg? Org { get; set; }
}
