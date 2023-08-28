using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblBlockAttributesCce
{
    public long Id { get; set; }

    public long AttributeValue { get; set; }

    public string AttributeName { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
