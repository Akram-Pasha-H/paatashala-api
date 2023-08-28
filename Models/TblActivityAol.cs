using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActivityAol
{
    public long Id { get; set; }

    public long? Theme { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public bool? IsActive { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblThemeAol? ThemeNavigation { get; set; }
}
