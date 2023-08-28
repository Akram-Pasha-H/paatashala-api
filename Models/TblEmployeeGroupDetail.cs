using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeGroupDetail
{
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public long? RoleId { get; set; }

    public long? EmpId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblEmployeeGroupHeader? Header { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblRole? Role { get; set; }
}
