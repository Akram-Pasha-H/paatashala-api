using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblStudent
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? StudentId { get; set; }

    public string? FatherName { get; set; }

    public string? FatherEmail { get; set; }

    public DateTime? FatherDob { get; set; }

    public string? MotherName { get; set; }

    public string? MotherEmail { get; set; }

    public DateTime? MotherDob { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? ParentsAnniversary { get; set; }

    public string? Sex { get; set; }

    public bool? MaritalStatus { get; set; }

    public long? Religion { get; set; }

    public long? Category { get; set; }

    public long? Natiionality { get; set; }

    public long? State { get; set; }

    public string? CurrentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? ContactNo { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public bool? IsPhysicallyChallenged { get; set; }

    public long? MediumOfInstruction { get; set; }

    public decimal? FatherIncome { get; set; }

    public string? PassportNo { get; set; }

    public long? NationalId { get; set; }

    public bool? IsTransportRequired { get; set; }

    public bool? IsHostelRequired { get; set; }

    public long? BloodGroup { get; set; }

    public long? FinancialSupport { get; set; }

    public bool? IsConvicted { get; set; }

    public string? IsConvictedReason { get; set; }

    public bool? IsPriorExpelled { get; set; }

    public string? IsPriorExpelledReason { get; set; }

    public string? EmergencyContactPerson { get; set; }

    public long? EmergencyContactNo { get; set; }

    public string? EmergencyContactRelation { get; set; }

    public byte[]? Photo { get; set; }

    public string? FatherQualification { get; set; }

    public string? MotherQualification { get; set; }

    public bool? Tcissued { get; set; }

    public decimal? Discount { get; set; }

    public long? DiscountType { get; set; }

    public long? CreatedBy { get; set; }

    public bool? IsLead { get; set; }

    public long OrgId { get; set; }

    public string? FatherTitle { get; set; }

    public string? MotherTitle { get; set; }

    public string? FatherOccupation { get; set; }

    public string? MotherOccupation { get; set; }

    public string? FatherContactNo { get; set; }

    public string? MotherContactNo { get; set; }

    public DateTime? LeadCreationDate { get; set; }

    public string? LeadRejectReason { get; set; }

    public string? Age { get; set; }

    public byte[]? FatherPhoto { get; set; }

    public byte[]? MotherPhoto { get; set; }

    public bool? BaseSourceIsLead { get; set; }

    public string? Stsnumber { get; set; }

    public string? AadharNumber { get; set; }

    public virtual TblStudentCategory? CategoryNavigation { get; set; }

    public virtual ICollection<CounsellorNote> CounsellorNotes { get; set; } = new List<CounsellorNote>();

    public virtual TblDiscountType? DiscountTypeNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual ICollection<TblActRemedialPlanSubjectWise> TblActRemedialPlanSubjectWises { get; set; } = new List<TblActRemedialPlanSubjectWise>();

    public virtual ICollection<TblActmentorReflection> TblActmentorReflections { get; set; } = new List<TblActmentorReflection>();

    public virtual ICollection<TblActmentoringHomeVisit> TblActmentoringHomeVisits { get; set; } = new List<TblActmentoringHomeVisit>();

    public virtual ICollection<TblActmentoringPlan> TblActmentoringPlans { get; set; } = new List<TblActmentoringPlan>();

    public virtual ICollection<TblActmentoringSchedule> TblActmentoringSchedules { get; set; } = new List<TblActmentoringSchedule>();

    public virtual ICollection<TblActmentoringUnPlanned> TblActmentoringUnPlanneds { get; set; } = new List<TblActmentoringUnPlanned>();

    public virtual ICollection<TblActptmrecord> TblActptmrecords { get; set; } = new List<TblActptmrecord>();

    public virtual ICollection<TblActremedialPlanSessionwise> TblActremedialPlanSessionwises { get; set; } = new List<TblActremedialPlanSessionwise>();

    public virtual ICollection<TblActremedialStudent> TblActremedialStudents { get; set; } = new List<TblActremedialStudent>();

    public virtual ICollection<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; } = new List<TblAdvanceFeeDebit>();

    public virtual ICollection<TblAdvancedFeePayment> TblAdvancedFeePayments { get; set; } = new List<TblAdvancedFeePayment>();

    public virtual ICollection<TblAolcomment> TblAolcomments { get; set; } = new List<TblAolcomment>();

    public virtual ICollection<TblAolstudentEntry> TblAolstudentEntries { get; set; } = new List<TblAolstudentEntry>();

    public virtual ICollection<TblAttendanceHourly> TblAttendanceHourlies { get; set; } = new List<TblAttendanceHourly>();

    public virtual ICollection<TblAttendanceHourlyOtherProgram> TblAttendanceHourlyOtherPrograms { get; set; } = new List<TblAttendanceHourlyOtherProgram>();

    public virtual ICollection<TblAttendance> TblAttendances { get; set; } = new List<TblAttendance>();

    public virtual ICollection<TblBatchAdmissionArchive> TblBatchAdmissionArchives { get; set; } = new List<TblBatchAdmissionArchive>();

    public virtual ICollection<TblBatchAdmissionPast> TblBatchAdmissionPasts { get; set; } = new List<TblBatchAdmissionPast>();

    public virtual ICollection<TblBatchAdmission> TblBatchAdmissions { get; set; } = new List<TblBatchAdmission>();

    public virtual ICollection<TblDietPlanLinkedStudent> TblDietPlanLinkedStudents { get; set; } = new List<TblDietPlanLinkedStudent>();

    public virtual ICollection<TblDietPlanRecording> TblDietPlanRecordings { get; set; } = new List<TblDietPlanRecording>();

    public virtual ICollection<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; } = new List<TblExamAttributeWiseMark>();

    public virtual ICollection<TblExamMark> TblExamMarks { get; set; } = new List<TblExamMark>();

    public virtual ICollection<TblFeePaymentDetail> TblFeePaymentDetails { get; set; } = new List<TblFeePaymentDetail>();

    public virtual ICollection<TblFeedback> TblFeedbacks { get; set; } = new List<TblFeedback>();

    public virtual ICollection<TblInactiveStudentLog> TblInactiveStudentLogs { get; set; } = new List<TblInactiveStudentLog>();

    public virtual ICollection<TblInactiveStudent> TblInactiveStudents { get; set; } = new List<TblInactiveStudent>();

    public virtual ICollection<TblLeadFollowUp> TblLeadFollowUps { get; set; } = new List<TblLeadFollowUp>();

    public virtual ICollection<TblLibraryBookLedger> TblLibraryBookLedgers { get; set; } = new List<TblLibraryBookLedger>();

    public virtual ICollection<TblMarksCardDetail> TblMarksCardDetails { get; set; } = new List<TblMarksCardDetail>();

    public virtual ICollection<TblMonthlyBillingDetail> TblMonthlyBillingDetails { get; set; } = new List<TblMonthlyBillingDetail>();

    public virtual ICollection<TblMonthlyBillingOtherCourseDetail> TblMonthlyBillingOtherCourseDetails { get; set; } = new List<TblMonthlyBillingOtherCourseDetail>();

    public virtual ICollection<TblOtherProgramsStudent> TblOtherProgramsStudents { get; set; } = new List<TblOtherProgramsStudent>();

    public virtual ICollection<TblPaatashalaBillingDetail> TblPaatashalaBillingDetailActiveStudents { get; set; } = new List<TblPaatashalaBillingDetail>();

    public virtual ICollection<TblPaatashalaBillingDetail> TblPaatashalaBillingDetailInActiveStudents { get; set; } = new List<TblPaatashalaBillingDetail>();

    public virtual ICollection<TblPaatashalaBillingDetail> TblPaatashalaBillingDetailOtherProgramStudents { get; set; } = new List<TblPaatashalaBillingDetail>();

    public virtual ICollection<TblParentCommunication> TblParentCommunications { get; set; } = new List<TblParentCommunication>();

    public virtual ICollection<TblParentFeedbackHeader> TblParentFeedbackHeaders { get; set; } = new List<TblParentFeedbackHeader>();

    public virtual ICollection<TblParentMessageBox> TblParentMessageBoxes { get; set; } = new List<TblParentMessageBox>();

    public virtual ICollection<TblPostDatedPayment> TblPostDatedPayments { get; set; } = new List<TblPostDatedPayment>();

    public virtual ICollection<TblReportSentDetail> TblReportSentDetails { get; set; } = new List<TblReportSentDetail>();

    public virtual ICollection<TblStockItemsDeliveryHeader> TblStockItemsDeliveryHeaders { get; set; } = new List<TblStockItemsDeliveryHeader>();

    public virtual ICollection<TblStudentActivity> TblStudentActivities { get; set; } = new List<TblStudentActivity>();

    public virtual ICollection<TblStudentAttachment> TblStudentAttachments { get; set; } = new List<TblStudentAttachment>();

    public virtual ICollection<TblStudentFeePaidHeader> TblStudentFeePaidHeaders { get; set; } = new List<TblStudentFeePaidHeader>();

    public virtual ICollection<TblStudentFeedbackMain> TblStudentFeedbackMains { get; set; } = new List<TblStudentFeedbackMain>();

    public virtual ICollection<TblStudentQualification> TblStudentQualifications { get; set; } = new List<TblStudentQualification>();

    public virtual ICollection<TblStudentRegistration> TblStudentRegistrations { get; set; } = new List<TblStudentRegistration>();

    public virtual ICollection<TblStudentValue> TblStudentValues { get; set; } = new List<TblStudentValue>();

    public virtual ICollection<TblTransportTripSheet> TblTransportTripSheets { get; set; } = new List<TblTransportTripSheet>();
}
