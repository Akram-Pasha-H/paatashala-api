using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblExamSchedule
{
    public long Id { get; set; }

    public long? ExamType { get; set; }

    public long? SubjectId { get; set; }

    public long? BatchId { get; set; }

    public long? CourseId { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? Duration { get; set; }

    public long? Faculty { get; set; }

    public long? ExamHall { get; set; }

    public bool? IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblBatch? Batch { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblExamHall? ExamHallNavigation { get; set; }

    public virtual TblExamType? ExamTypeNavigation { get; set; }

    public virtual TblEmployee? FacultyNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblSubject? Subject { get; set; }

    public virtual ICollection<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; } = new List<TblExamAttributeWiseMark>();

    public virtual ICollection<TblExamMark> TblExamMarks { get; set; } = new List<TblExamMark>();
}
