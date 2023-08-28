using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblLeaveType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? Description { get; set; }

    public long? OrgId { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblEmpLeaveApplied> TblEmpLeaveApplieds { get; set; } = new List<TblEmpLeaveApplied>();

    public virtual ICollection<TblLeaveOnRolewise> TblLeaveOnRolewises { get; set; } = new List<TblLeaveOnRolewise>();
}
