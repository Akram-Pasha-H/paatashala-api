using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeSalaryComponent
{
    public long Id { get; set; }

    public string ComponentName { get; set; } = null!;

    public bool IsDeduction { get; set; }

    public bool IsEarning { get; set; }

    public long Percentage { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblPayGroupDetail> TblPayGroupDetails { get; set; } = new List<TblPayGroupDetail>();

    public virtual ICollection<TblPayrollDetail> TblPayrollDetails { get; set; } = new List<TblPayrollDetail>();
}
