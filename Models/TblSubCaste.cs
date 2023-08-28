using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSubCaste
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long ParentCaste { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblCaste ParentCasteNavigation { get; set; } = null!;
}
