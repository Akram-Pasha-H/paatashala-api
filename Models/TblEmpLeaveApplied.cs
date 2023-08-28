using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmpLeaveApplied
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public long? LeaveType { get; set; }

    public DateTime? StartDate { get; set; }

    public int? DayCount { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Reason { get; set; }

    public int? Status { get; set; }

    public long? OrgId { get; set; }

    public long? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? RejectReason { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblLeaveType? LeaveTypeNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployee? User { get; set; }
}
