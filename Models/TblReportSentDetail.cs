using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblReportSentDetail
{
    public long Id { get; set; }

    public long? ReportCategoryId { get; set; }

    public string? Type { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? StudentId { get; set; }

    public long? OrgId { get; set; }

    public long? EmployeeId { get; set; }

    public virtual TblEmployee? Employee { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblReportCategory? ReportCategory { get; set; }

    public virtual TblStudent? Student { get; set; }
}
