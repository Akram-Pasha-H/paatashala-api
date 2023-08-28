using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblVisualTimeTablePhotoType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long? OtherProgramId { get; set; }

    public byte[]? Photo { get; set; }

    public long? OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblOtherProgram? OtherProgram { get; set; }

    public virtual ICollection<TblTimeTableDetail> TblTimeTableDetails { get; set; } = new List<TblTimeTableDetail>();
}
