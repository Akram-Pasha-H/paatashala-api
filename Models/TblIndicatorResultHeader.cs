using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblIndicatorResultHeader
{
    public long Id { get; set; }

    public long? EmpId { get; set; }

    public long? EmpOrgId { get; set; }

    public int? Month { get; set; }

    public string? Comments { get; set; }

    public long? LoggedUserId { get; set; }

    public long? RubricsHeaderId { get; set; }

    public long? CourseId { get; set; }

    public long? SubjectId { get; set; }

    public int? Year { get; set; }

    public virtual TblEmployee? Emp { get; set; }

    public virtual TblOrg? EmpOrg { get; set; }

    public virtual TblEmployee? LoggedUser { get; set; }

    public virtual TblIndicatorGroup? RubricsHeader { get; set; }

    public virtual ICollection<TblIndicatorResult> TblIndicatorResults { get; set; } = new List<TblIndicatorResult>();
}
