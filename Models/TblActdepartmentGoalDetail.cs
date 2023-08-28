using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActdepartmentGoalDetail
{
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public string? Goal { get; set; }

    public long? CourseId { get; set; }

    public string? Stpes { get; set; }

    public DateTime? DateofInitiation { get; set; }

    public string? StatusUpdate { get; set; }

    public string? ResponsiblePerson { get; set; }

    public virtual TblActdepartmentGoalHeader? Header { get; set; }
}
