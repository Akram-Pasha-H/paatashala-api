using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Details { get; set; }

    public long? OrgId { get; set; }

    public bool? IsGrade { get; set; }

    public long? GradeSystem { get; set; }

    public long? CoscholasticGrade { get; set; }

    public virtual TblOrg? Org { get; set; }

    public virtual ICollection<TblExamSchedule> TblExamSchedules { get; set; } = new List<TblExamSchedule>();

    public virtual ICollection<TblExamTypeLinkedWithCourse> TblExamTypeLinkedWithCourses { get; set; } = new List<TblExamTypeLinkedWithCourse>();

    public virtual ICollection<TblExamTypeLinkedWithSubject> TblExamTypeLinkedWithSubjects { get; set; } = new List<TblExamTypeLinkedWithSubject>();

    public virtual ICollection<TblMarksCardDetail> TblMarksCardDetails { get; set; } = new List<TblMarksCardDetail>();
}
