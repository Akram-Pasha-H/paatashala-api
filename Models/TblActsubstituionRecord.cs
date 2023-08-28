using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblActsubstituionRecord
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public long? AbsentTeacherId { get; set; }

    public long? SubstituteTeacherId { get; set; }

    public string? Task { get; set; }

    public long? CourseId { get; set; }

    public long? SubjectId { get; set; }

    public long? OrgId { get; set; }

    public virtual TblEmployee? AbsentTeacher { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual TblSubject? Subject { get; set; }

    public virtual TblEmployee? SubstituteTeacher { get; set; }
}
