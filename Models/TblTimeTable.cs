using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblTimeTable
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Course { get; set; }

    public long Batch { get; set; }

    public bool? IsActive { get; set; }

    public long OrgId { get; set; }

    public bool? IsVisual { get; set; }

    public long? ClassTeacherId { get; set; }

    public string? Section { get; set; }

    public virtual TblEmployee? ClassTeacher { get; set; }

    public virtual ICollection<TblTimeTableDetail> TblTimeTableDetails { get; set; } = new List<TblTimeTableDetail>();
}
