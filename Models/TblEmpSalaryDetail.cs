using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmpSalaryDetail
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public long? DeptId { get; set; }

    public long? Designation { get; set; }

    public DateTime? DateOfAppointment { get; set; }

    public long? CategoryCode { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankLedgerNo { get; set; }

    public DateTime? DateOfConfirmation { get; set; }

    public bool? IsEligibleForPf { get; set; }

    public decimal? BasicSalary { get; set; }

    public string? Pfno { get; set; }

    public decimal? IncrementAmt { get; set; }

    public long OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
