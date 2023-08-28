using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActremedialStudent
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public int? Month { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public long OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblStudent? Student { get; set; }
}
