using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblPayrollDetail
{
    public long Id { get; set; }

    public long PayrollId { get; set; }

    public long ComponentId { get; set; }

    public decimal Value { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployeeSalaryComponent Component { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblPayroll Payroll { get; set; } = null!;
}
