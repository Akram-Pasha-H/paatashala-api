using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblEmployee
{
    public long Id { get; set; }

    public long? DepartmentId { get; set; }

    public long? RoleId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public long? EmpId { get; set; }

    public long? Sex { get; set; }

    public string? GuardianRelation { get; set; }

    public string? GuardianName { get; set; }

    public long? MaritalStatus { get; set; }

    public DateTime? DateOfJoining { get; set; }

    public long? Designation { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public long? Age { get; set; }

    public string? PlaceOfBirth { get; set; }

    public long? Religion { get; set; }

    public long? Nationality { get; set; }

    public string? SpouseName { get; set; }

    public long? SpouseNationalId { get; set; }

    public string? StateOfDomicile { get; set; }

    public long? EmpStatus { get; set; }

    public long? Experience { get; set; }

    public long? NoOfDepedents { get; set; }

    public long? Height { get; set; }

    public long? Weight { get; set; }

    public long? BloodGroup { get; set; }

    public string? RhType { get; set; }

    public long? Phone { get; set; }

    public string? Email { get; set; }

    public string? PassportNo { get; set; }

    public long? PanNo { get; set; }

    public string? NomineeName { get; set; }

    public string? NomineeRelation { get; set; }

    public byte[]? Photo { get; set; }

    public string? MotherTongue { get; set; }

    public string? LanguagesKnown { get; set; }

    public string? IdentificationMarks { get; set; }

    public string? PresentAddressLine1 { get; set; }

    public string? PresentAddressLine2 { get; set; }

    public string? PresentCountry { get; set; }

    public string? PresentState { get; set; }

    public string? PresentCity { get; set; }

    public string? PresentArea { get; set; }

    public string? PermanentAddresLine1 { get; set; }

    public string? PermanentAddressLine2 { get; set; }

    public string? PermanentCountry { get; set; }

    public string? PermanentState { get; set; }

    public string? PermanentCity { get; set; }

    public string? PermanentArea { get; set; }

    public bool? HasLoginAccess { get; set; }

    public long OrgId { get; set; }

    public byte[]? EmployeeSignature { get; set; }

    public bool? IsDelete { get; set; }

    public string? FavouriteDashboardId { get; set; }

    public long? ExperienceMonths { get; set; }

    public long? HeightInches { get; set; }

    public virtual TblDepartment? Department { get; set; }

    public virtual TblDesignation? DesignationNavigation { get; set; }

    public virtual TblOrg Org { get; set; } = null!;

    public virtual TblRole? Role { get; set; }

    public virtual ICollection<TblActRemedialPlanSubjectWise> TblActRemedialPlanSubjectWises { get; set; } = new List<TblActRemedialPlanSubjectWise>();

    public virtual ICollection<TblActacademicHandholdingChecklist> TblActacademicHandholdingChecklistChairmanNavigations { get; set; } = new List<TblActacademicHandholdingChecklist>();

    public virtual ICollection<TblActacademicHandholdingChecklist> TblActacademicHandholdingChecklistPrincipalNavigations { get; set; } = new List<TblActacademicHandholdingChecklist>();

    public virtual ICollection<TblActacademicHandholdingChecklist> TblActacademicHandholdingChecklistSsfNavigations { get; set; } = new List<TblActacademicHandholdingChecklist>();

    public virtual ICollection<TblActappraisalHeader> TblActappraisalHeaders { get; set; } = new List<TblActappraisalHeader>();

    public virtual ICollection<TblActdailyPlanHeader> TblActdailyPlanHeaders { get; set; } = new List<TblActdailyPlanHeader>();

    public virtual ICollection<TblActdepartmentGoalHeader> TblActdepartmentGoalHeaders { get; set; } = new List<TblActdepartmentGoalHeader>();

    public virtual ICollection<TblActexitInterviewResultHeader> TblActexitInterviewResultHeaders { get; set; } = new List<TblActexitInterviewResultHeader>();

    public virtual ICollection<TblActmentorReflection> TblActmentorReflections { get; set; } = new List<TblActmentorReflection>();

    public virtual ICollection<TblActmentoringHomeVisit> TblActmentoringHomeVisits { get; set; } = new List<TblActmentoringHomeVisit>();

    public virtual ICollection<TblActmentoringPlan> TblActmentoringPlans { get; set; } = new List<TblActmentoringPlan>();

    public virtual ICollection<TblActmentoringSchedule> TblActmentoringSchedules { get; set; } = new List<TblActmentoringSchedule>();

    public virtual ICollection<TblActmentoringUnPlanned> TblActmentoringUnPlanneds { get; set; } = new List<TblActmentoringUnPlanned>();

    public virtual ICollection<TblActptmrecord> TblActptmrecordClassTeachers { get; set; } = new List<TblActptmrecord>();

    public virtual ICollection<TblActptmrecord> TblActptmrecordCreatedByNavigations { get; set; } = new List<TblActptmrecord>();

    public virtual ICollection<TblActremedialPlanSessionwise> TblActremedialPlanSessionwises { get; set; } = new List<TblActremedialPlanSessionwise>();

    public virtual ICollection<TblActssfconfigHeader> TblActssfconfigHeaders { get; set; } = new List<TblActssfconfigHeader>();

    public virtual ICollection<TblActssfinteraction> TblActssfinteractions { get; set; } = new List<TblActssfinteraction>();

    public virtual ICollection<TblActsubstituionRecord> TblActsubstituionRecordAbsentTeachers { get; set; } = new List<TblActsubstituionRecord>();

    public virtual ICollection<TblActsubstituionRecord> TblActsubstituionRecordSubstituteTeachers { get; set; } = new List<TblActsubstituionRecord>();

    public virtual ICollection<TblActtrainingFeedbackHeader> TblActtrainingFeedbackHeaders { get; set; } = new List<TblActtrainingFeedbackHeader>();

    public virtual ICollection<TblActvisitHeader> TblActvisitHeaders { get; set; } = new List<TblActvisitHeader>();

    public virtual ICollection<TblActyearPlanHeader> TblActyearPlanHeaders { get; set; } = new List<TblActyearPlanHeader>();

    public virtual ICollection<TblActyearlyGoalPerson> TblActyearlyGoalPeople { get; set; } = new List<TblActyearlyGoalPerson>();

    public virtual ICollection<TblAolcomment> TblAolcomments { get; set; } = new List<TblAolcomment>();

    public virtual ICollection<TblBatchAdmissionArchive> TblBatchAdmissionArchives { get; set; } = new List<TblBatchAdmissionArchive>();

    public virtual ICollection<TblBatchAdmissionPast> TblBatchAdmissionPasts { get; set; } = new List<TblBatchAdmissionPast>();

    public virtual ICollection<TblCalenderAssignment> TblCalenderAssignments { get; set; } = new List<TblCalenderAssignment>();

    public virtual ICollection<TblDmsrootUser> TblDmsrootUsers { get; set; } = new List<TblDmsrootUser>();

    public virtual ICollection<TblDocfolderAccess> TblDocfolderAccesses { get; set; } = new List<TblDocfolderAccess>();

    public virtual ICollection<TblDocumentAccess> TblDocumentAccesses { get; set; } = new List<TblDocumentAccess>();

    public virtual ICollection<TblDocumentTag> TblDocumentTags { get; set; } = new List<TblDocumentTag>();

    public virtual ICollection<TblEmailLog> TblEmailLogs { get; set; } = new List<TblEmailLog>();

    public virtual ICollection<TblEmpLeaveApplied> TblEmpLeaveAppliedEmps { get; set; } = new List<TblEmpLeaveApplied>();

    public virtual ICollection<TblEmpLeaveApplied> TblEmpLeaveAppliedUsers { get; set; } = new List<TblEmpLeaveApplied>();

    public virtual ICollection<TblEmpSalaryDetail> TblEmpSalaryDetails { get; set; } = new List<TblEmpSalaryDetail>();

    public virtual ICollection<TblEmployeeAdditionalInfo> TblEmployeeAdditionalInfos { get; set; } = new List<TblEmployeeAdditionalInfo>();

    public virtual ICollection<TblEmployeeAttachment> TblEmployeeAttachments { get; set; } = new List<TblEmployeeAttachment>();

    public virtual ICollection<TblEmployeeAttrition> TblEmployeeAttritions { get; set; } = new List<TblEmployeeAttrition>();

    public virtual ICollection<TblEmployeeGroupDetail> TblEmployeeGroupDetails { get; set; } = new List<TblEmployeeGroupDetail>();

    public virtual ICollection<TblEmployeeLetter> TblEmployeeLetters { get; set; } = new List<TblEmployeeLetter>();

    public virtual ICollection<TblExamSchedule> TblExamSchedules { get; set; } = new List<TblExamSchedule>();

    public virtual ICollection<TblFeedback> TblFeedbacks { get; set; } = new List<TblFeedback>();

    public virtual ICollection<TblGallery> TblGalleries { get; set; } = new List<TblGallery>();

    public virtual ICollection<TblGrievanceRecord> TblGrievanceRecords { get; set; } = new List<TblGrievanceRecord>();

    public virtual ICollection<TblImageGallery> TblImageGalleries { get; set; } = new List<TblImageGallery>();

    public virtual ICollection<TblInactiveEmployee> TblInactiveEmployeeEmployees { get; set; } = new List<TblInactiveEmployee>();

    public virtual ICollection<TblInactiveEmployeeLog> TblInactiveEmployeeLogEmployees { get; set; } = new List<TblInactiveEmployeeLog>();

    public virtual ICollection<TblInactiveEmployeeLog> TblInactiveEmployeeLogUsers { get; set; } = new List<TblInactiveEmployeeLog>();

    public virtual ICollection<TblInactiveEmployee> TblInactiveEmployeeUsers { get; set; } = new List<TblInactiveEmployee>();

    public virtual ICollection<TblIndicatorResultHeader> TblIndicatorResultHeaderEmps { get; set; } = new List<TblIndicatorResultHeader>();

    public virtual ICollection<TblIndicatorResultHeader> TblIndicatorResultHeaderLoggedUsers { get; set; } = new List<TblIndicatorResultHeader>();

    public virtual ICollection<TblIndicatorResult> TblIndicatorResults { get; set; } = new List<TblIndicatorResult>();

    public virtual ICollection<TblLeadFollowUp> TblLeadFollowUpAssignToNavigations { get; set; } = new List<TblLeadFollowUp>();

    public virtual ICollection<TblLeadFollowUp> TblLeadFollowUpCreatedByNavigations { get; set; } = new List<TblLeadFollowUp>();

    public virtual ICollection<TblMessageCenter> TblMessageCenters { get; set; } = new List<TblMessageCenter>();

    public virtual ICollection<TblMessageRecipient> TblMessageRecipients { get; set; } = new List<TblMessageRecipient>();

    public virtual ICollection<TblParentCommunication> TblParentCommunications { get; set; } = new List<TblParentCommunication>();

    public virtual ICollection<TblPayroll> TblPayrolls { get; set; } = new List<TblPayroll>();

    public virtual ICollection<TblPrincipalMonthlyReport> TblPrincipalMonthlyReports { get; set; } = new List<TblPrincipalMonthlyReport>();

    public virtual ICollection<TblReportSentDetail> TblReportSentDetails { get; set; } = new List<TblReportSentDetail>();

    public virtual ICollection<TblSmsLog> TblSmsLogs { get; set; } = new List<TblSmsLog>();

    public virtual ICollection<TblStockItemsDeliveryHeader> TblStockItemsDeliveryHeaders { get; set; } = new List<TblStockItemsDeliveryHeader>();

    public virtual ICollection<TblStudentFeedbackDetail> TblStudentFeedbackDetails { get; set; } = new List<TblStudentFeedbackDetail>();

    public virtual ICollection<TblTimeTable> TblTimeTables { get; set; } = new List<TblTimeTable>();

    public virtual ICollection<TblTrainingAttendance> TblTrainingAttendances { get; set; } = new List<TblTrainingAttendance>();

    public virtual ICollection<TblTraningSchedule> TblTraningSchedules { get; set; } = new List<TblTraningSchedule>();

    public virtual ICollection<TblVideoGallery> TblVideoGalleries { get; set; } = new List<TblVideoGallery>();
}
