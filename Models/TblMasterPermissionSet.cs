using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblMasterPermissionSet
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long Value { get; set; }

    public long? ParentValue { get; set; }

    public bool? IsKinderGarden { get; set; }

    public bool? IsErp { get; set; }

    public bool? IsTmf { get; set; }

    public bool? IsAddon { get; set; }

    public virtual ICollection<TblRolePermission> TblRolePermissions { get; set; } = new List<TblRolePermission>();
}
