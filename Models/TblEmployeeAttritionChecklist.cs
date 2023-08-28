using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeAttritionChecklist
{
    public long Id { get; set; }

    public long ChecklistId { get; set; }

    public long EmployeeAttritionId { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployeeAttrition EmployeeAttrition { get; set; } = null!;
}
