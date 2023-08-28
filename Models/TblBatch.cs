﻿using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblBatch
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? BatchCounter { get; set; }

    public bool? IsActive { get; set; }

    public long OrgId { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblAbsentAttendance> TblAbsentAttendances { get; set; } = new List<TblAbsentAttendance>();

    public virtual ICollection<TblActRemedialPlanSubjectWise> TblActRemedialPlanSubjectWises { get; set; } = new List<TblActRemedialPlanSubjectWise>();

    public virtual ICollection<TblActdailyPlanHeader> TblActdailyPlanHeaders { get; set; } = new List<TblActdailyPlanHeader>();

    public virtual ICollection<TblActdepartmentGoalHeader> TblActdepartmentGoalHeaders { get; set; } = new List<TblActdepartmentGoalHeader>();

    public virtual ICollection<TblActmentoringPlan> TblActmentoringPlans { get; set; } = new List<TblActmentoringPlan>();

    public virtual ICollection<TblActptmrecord> TblActptmrecords { get; set; } = new List<TblActptmrecord>();

    public virtual ICollection<TblActremedialPlanSessionwise> TblActremedialPlanSessionwises { get; set; } = new List<TblActremedialPlanSessionwise>();

    public virtual ICollection<TblActremedialStudent> TblActremedialStudents { get; set; } = new List<TblActremedialStudent>();

    public virtual ICollection<TblActyearPlanHeader> TblActyearPlanHeaders { get; set; } = new List<TblActyearPlanHeader>();

    public virtual ICollection<TblActyearlyGoalHeader> TblActyearlyGoalHeaders { get; set; } = new List<TblActyearlyGoalHeader>();

    public virtual ICollection<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; } = new List<TblAdvanceFeeDebit>();

    public virtual ICollection<TblAdvancedFeePayment> TblAdvancedFeePayments { get; set; } = new List<TblAdvancedFeePayment>();

    public virtual ICollection<TblAolcomment> TblAolcomments { get; set; } = new List<TblAolcomment>();

    public virtual ICollection<TblAolstudentEntry> TblAolstudentEntries { get; set; } = new List<TblAolstudentEntry>();

    public virtual ICollection<TblAreaOfLearning> TblAreaOfLearnings { get; set; } = new List<TblAreaOfLearning>();

    public virtual ICollection<TblAssignment> TblAssignments { get; set; } = new List<TblAssignment>();

    public virtual ICollection<TblBatchAdmissionArchive> TblBatchAdmissionArchiveBatches { get; set; } = new List<TblBatchAdmissionArchive>();

    public virtual ICollection<TblBatchAdmissionArchive> TblBatchAdmissionArchivePrevBatches { get; set; } = new List<TblBatchAdmissionArchive>();

    public virtual ICollection<TblBatchAdmission> TblBatchAdmissionBatches { get; set; } = new List<TblBatchAdmission>();

    public virtual ICollection<TblBatchAdmissionPast> TblBatchAdmissionPasts { get; set; } = new List<TblBatchAdmissionPast>();

    public virtual ICollection<TblBatchAdmission> TblBatchAdmissionPrevBatches { get; set; } = new List<TblBatchAdmission>();

    public virtual ICollection<TblCircular> TblCirculars { get; set; } = new List<TblCircular>();

    public virtual ICollection<TblCourseFeeDetail> TblCourseFeeDetails { get; set; } = new List<TblCourseFeeDetail>();

    public virtual ICollection<TblDietPlanLinkedStudent> TblDietPlanLinkedStudents { get; set; } = new List<TblDietPlanLinkedStudent>();

    public virtual ICollection<TblDietPlanRecording> TblDietPlanRecordings { get; set; } = new List<TblDietPlanRecording>();

    public virtual ICollection<TblExamSchedule> TblExamSchedules { get; set; } = new List<TblExamSchedule>();

    public virtual ICollection<TblExamTypeLinkedWithCourse> TblExamTypeLinkedWithCourses { get; set; } = new List<TblExamTypeLinkedWithCourse>();

    public virtual ICollection<TblGallery> TblGalleries { get; set; } = new List<TblGallery>();

    public virtual ICollection<TblImageGallery> TblImageGalleries { get; set; } = new List<TblImageGallery>();

    public virtual ICollection<TblInactiveStudentLog> TblInactiveStudentLogs { get; set; } = new List<TblInactiveStudentLog>();

    public virtual ICollection<TblInactiveStudent> TblInactiveStudents { get; set; } = new List<TblInactiveStudent>();

    public virtual ICollection<TblInstallmentTemplateHeader> TblInstallmentTemplateHeaders { get; set; } = new List<TblInstallmentTemplateHeader>();

    public virtual ICollection<TblLibraryBookLedger> TblLibraryBookLedgers { get; set; } = new List<TblLibraryBookLedger>();

    public virtual ICollection<TblMarksCardDetail> TblMarksCardDetails { get; set; } = new List<TblMarksCardDetail>();

    public virtual ICollection<TblMonthlyBillingDetail> TblMonthlyBillingDetails { get; set; } = new List<TblMonthlyBillingDetail>();

    public virtual ICollection<TblMonthlyBillingOtherCourseDetail> TblMonthlyBillingOtherCourseDetails { get; set; } = new List<TblMonthlyBillingOtherCourseDetail>();

    public virtual ICollection<TblNewsLetter> TblNewsLetters { get; set; } = new List<TblNewsLetter>();

    public virtual ICollection<TblQuestionBank> TblQuestionBanks { get; set; } = new List<TblQuestionBank>();

    public virtual ICollection<TblStockItemsDeliveryHeader> TblStockItemsDeliveryHeaders { get; set; } = new List<TblStockItemsDeliveryHeader>();

    public virtual ICollection<TblStudentActivity> TblStudentActivities { get; set; } = new List<TblStudentActivity>();

    public virtual ICollection<TblStudentFeedbackMain> TblStudentFeedbackMains { get; set; } = new List<TblStudentFeedbackMain>();

    public virtual ICollection<TblTopic> TblTopics { get; set; } = new List<TblTopic>();

    public virtual ICollection<TblVideoGallery> TblVideoGalleries { get; set; } = new List<TblVideoGallery>();

    public virtual ICollection<TblVisualTimeTablePhotoType> TblVisualTimeTablePhotoTypes { get; set; } = new List<TblVisualTimeTablePhotoType>();
}
