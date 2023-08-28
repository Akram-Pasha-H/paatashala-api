using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblBatchAdmissionPast
{
    public long Id { get; set; }

    public long StudentId { get; set; }

    public long? BatchId { get; set; }

    public long CourseId { get; set; }

    public string? Section { get; set; }

    public string? RollNumber { get; set; }

    public long AdmissionStatus { get; set; }

    public long OrgId { get; set; }

    public long? UserId { get; set; }

    public string? Reason { get; set; }

    public long? StreamId { get; set; }

    public DateTime? TcisuueDate { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse Course { get; set; } = null!;

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStream? Stream { get; set; }

    public virtual TblStudent Student { get; set; } = null!;

    public virtual TblEmployee? User { get; set; }
}
