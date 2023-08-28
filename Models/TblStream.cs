using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStream
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblBatchAdmissionArchive> TblBatchAdmissionArchives { get; set; } = new List<TblBatchAdmissionArchive>();

    public virtual ICollection<TblBatchAdmissionPast> TblBatchAdmissionPasts { get; set; } = new List<TblBatchAdmissionPast>();

    public virtual ICollection<TblBatchAdmission> TblBatchAdmissions { get; set; } = new List<TblBatchAdmission>();

    public virtual ICollection<TblCourse> TblCourses { get; set; } = new List<TblCourse>();
}
