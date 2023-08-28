using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblNewsLetter
{
    public long Id { get; set; }

    public long BatchId { get; set; }

    public long CourseId { get; set; }

    public DateTime? DateTime { get; set; }

    public string? FileName { get; set; }

    public long? OrgId { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public virtual TblBatch Batch { get; set; } = null!;

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg? Org { get; set; }
}
