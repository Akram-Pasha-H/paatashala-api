using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployeeLetter
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public DateTime? Date { get; set; }

    public long? TemplateId { get; set; }

    public string? FinalContent { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblEmployeeLetterTemplate? Template { get; set; }
}
