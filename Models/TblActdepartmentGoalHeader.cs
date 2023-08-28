using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActdepartmentGoalHeader
{
    public long Id { get; set; }

    public long? BatchId { get; set; }

    public long? DepartmentId { get; set; }

    public long? EmpId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblDepartment? Department { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblActdepartmentGoalDetail> TblActdepartmentGoalDetails { get; set; } = new List<TblActdepartmentGoalDetail>();
}
