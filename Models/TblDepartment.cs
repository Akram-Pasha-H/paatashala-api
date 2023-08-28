using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblDepartment
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public bool IsTeaching { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblActdepartmentGoalHeader> TblActdepartmentGoalHeaders { get; set; } = new List<TblActdepartmentGoalHeader>();

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();
}
