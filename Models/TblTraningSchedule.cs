using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTraningSchedule
{
    public long Id { get; set; }

    public long? TraningScheduleHeaderId { get; set; }

    public long? EmpOrgId { get; set; }

    public long? EmpId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? EmpOrg { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblTrainingScheduleHeader? TraningScheduleHeader { get; set; }
}
