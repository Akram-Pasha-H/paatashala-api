using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeAdditionalInfo
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public string? Col1 { get; set; }

    public string? Col1Details { get; set; }

    public string? Col2 { get; set; }

    public string? Col2Details { get; set; }

    public string? Col3 { get; set; }

    public string? Col3Details { get; set; }

    public string? Col4 { get; set; }

    public string? Col4Details { get; set; }

    public string? Col5 { get; set; }

    public string? Col5Details { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }
}
