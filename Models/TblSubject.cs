using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblSubject
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public long OrgId { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsSubComponent { get; set; }

    public bool? IsCoScholastic { get; set; }

    public bool? IsSubComponentAttributes { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblActRemedialPlanSubjectWise> TblActRemedialPlanSubjectWises { get; set; } = new List<TblActRemedialPlanSubjectWise>();

    public virtual ICollection<TblActdailyPlanHeader> TblActdailyPlanHeaders { get; set; } = new List<TblActdailyPlanHeader>();

    public virtual ICollection<TblActremedialPlanSessionwise> TblActremedialPlanSessionwises { get; set; } = new List<TblActremedialPlanSessionwise>();

    public virtual ICollection<TblActremedialStudentsSubject> TblActremedialStudentsSubjects { get; set; } = new List<TblActremedialStudentsSubject>();

    public virtual ICollection<TblActsubstituionRecord> TblActsubstituionRecords { get; set; } = new List<TblActsubstituionRecord>();

    public virtual ICollection<TblActyearPlanHeader> TblActyearPlanHeaders { get; set; } = new List<TblActyearPlanHeader>();

    public virtual ICollection<TblAssignment> TblAssignments { get; set; } = new List<TblAssignment>();

    public virtual ICollection<TblCourseSubject> TblCourseSubjects { get; set; } = new List<TblCourseSubject>();

    public virtual ICollection<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; } = new List<TblExamAttributeWiseMark>();

    public virtual ICollection<TblExamMark> TblExamMarks { get; set; } = new List<TblExamMark>();

    public virtual ICollection<TblExamSchedule> TblExamSchedules { get; set; } = new List<TblExamSchedule>();

    public virtual ICollection<TblExamTypeLinkedWithSubject> TblExamTypeLinkedWithSubjects { get; set; } = new List<TblExamTypeLinkedWithSubject>();

    public virtual ICollection<TblStudentFeedbackDetail> TblStudentFeedbackDetails { get; set; } = new List<TblStudentFeedbackDetail>();

    public virtual ICollection<TblSubjectSubComponent> TblSubjectSubComponents { get; set; } = new List<TblSubjectSubComponent>();

    public virtual ICollection<TblTopic> TblTopics { get; set; } = new List<TblTopic>();
}
