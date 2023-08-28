using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblCircular
{
    public long Id { get; set; }

    public DateTime? Dated { get; set; }

    public string? Notice { get; set; }

    public long OrgId { get; set; }

    public bool? OnNoticeBoard { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg Org { get; set; } = null!;
}
