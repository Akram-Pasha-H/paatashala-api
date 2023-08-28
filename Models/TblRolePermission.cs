using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblRolePermission
{
    public long Id { get; set; }

    public long MasterPermissionValue { get; set; }

    public long RoleId { get; set; }

    public long OrgId { get; set; }

    public virtual TblMasterPermissionSet MasterPermissionValueNavigation { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblRole Role { get; set; } = null!;
}
