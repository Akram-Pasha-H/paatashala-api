using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPayroll
{
    public long Id { get; set; }

    public long EmpId { get; set; }

    public long Month { get; set; }

    public long Year { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployee Emp { get; set; } = null!;

    public virtual ICollection<TblPayrollDetail> TblPayrollDetails { get; set; } = new List<TblPayrollDetail>();
}
