using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActptmrecord
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public DateTime? Ptmdate { get; set; }

    public long? CourseId { get; set; }

    public long? BatchId { get; set; }

    public long? ClassTeacherId { get; set; }

    public string? Academics { get; set; }

    public string? Punctuality { get; set; }

    public string? Behaviour { get; set; }

    public string? ParentPoint { get; set; }

    public string? Action { get; set; }

    public long? OrgId { get; set; }

    public long? CreatedBy { get; set; }

    public string? ReferTo { get; set; }

    public string? Section { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblEmployee? ClassTeacher { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblEmployee? CreatedByNavigation { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblStudent? Student { get; set; }
}
