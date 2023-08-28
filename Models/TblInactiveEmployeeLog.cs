using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblInactiveEmployeeLog
{
    public long Id { get; set; }

    public long? EmployeeId { get; set; }

    public long? RoleId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public bool? SetActive { get; set; }

    public long? UserId { get; set; }

    public long? OrgId { get; set; }

    public string? Narration { get; set; }

    public virtual TblEmployee? Employee { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual TblEmployee? User { get; set; }
}
