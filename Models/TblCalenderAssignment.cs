using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCalenderAssignment
{
    public long Id { get; set; }

    public long? CalenderId { get; set; }

    public long? EmpId { get; set; }

    public long? EmpOrgId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblCalenderHeaader? Calender { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? EmpOrg { get; set; }

    public virtual TblOrg? Org { get; set; }
}
