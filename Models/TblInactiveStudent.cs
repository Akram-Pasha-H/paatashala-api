using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblInactiveStudent
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long? BatchId { get; set; }

    public long? PrevBatchId { get; set; }

    public long CourseId { get; set; }

    public string? Section { get; set; }

    public string? RollNumber { get; set; }

    public long AdmissionStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long OrgId { get; set; }

    public long? UserId { get; set; }

    public string? Narration { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent Student { get; set; } = null!;
}
