using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRoleWidget
{
    public long Id { get; set; }

    public long? RoleId { get; set; }

    public long? WidgetId { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblRole? Role { get; set; }

    public virtual TblWidget? Widget { get; set; }
}
