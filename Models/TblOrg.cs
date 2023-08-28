using System;
using System.Collections.Generic;

namespace PaatashalaApi.Models;

public partial class TblOrg
{
    public long Id { get; set; }

    public string OrgName { get; set; } = null!;

    public string? OrgFullName { get; set; }

    public string? PrimaryContact { get; set; }

    public long? Mobile { get; set; }

    public string? Email { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public DateTime? SubscriptionStartDate { get; set; }

    public DateTime? SubscriptionEndDate { get; set; }

    public byte[]? OrgPhoto { get; set; }

    public long? OrgType { get; set; }

    public long? ParentOrgId { get; set; }

    public string? Gstnumber { get; set; }

    public string? Sacnumber { get; set; }

    public string? InvoiceEmailIds { get; set; }

    public string? InvoiceSmsnumbers { get; set; }

    public bool? InvoiceAutomate { get; set; }

    public long? SectorId { get; set; }

    public virtual ICollection<CounsellorNote> CounsellorNotes { get; set; } = new List<CounsellorNote>();

    public virtual TblSector? Sector { get; set; }

    public virtual ICollection<TblAbsentAttendance> TblAbsentAttendances { get; set; } = new List<TblAbsentAttendance>();

    public virtual ICollection<TblAccountGroup> TblAccountGroups { get; set; } = new List<TblAccountGroup>();

    public virtual ICollection<TblAccountLedger> TblAccountLedgers { get; set; } = new List<TblAccountLedger>();

    public virtual ICollection<TblActRemedialPlanSubjectWise> TblActRemedialPlanSubjectWises { get; set; } = new List<TblActRemedialPlanSubjectWise>();

    public virtual ICollection<TblActacademicHandholdingChecklist> TblActacademicHandholdingChecklistOrgs { get; set; } = new List<TblActacademicHandholdingChecklist>();

    public virtual ICollection<TblActacademicHandholdingChecklist> TblActacademicHandholdingChecklistSchools { get; set; } = new List<TblActacademicHandholdingChecklist>();

    public virtual ICollection<TblActahreportHeader> TblActahreportHeaders { get; set; } = new List<TblActahreportHeader>();

    public virtual ICollection<TblActahreport> TblActahreports { get; set; } = new List<TblActahreport>();

    public virtual ICollection<TblActappraisalDetail> TblActappraisalDetails { get; set; } = new List<TblActappraisalDetail>();

    public virtual ICollection<TblActappraisalHeader> TblActappraisalHeaders { get; set; } = new List<TblActappraisalHeader>();

    public virtual ICollection<TblActdailyPlanDetail> TblActdailyPlanDetails { get; set; } = new List<TblActdailyPlanDetail>();

    public virtual ICollection<TblActdailyPlanHeader> TblActdailyPlanHeaders { get; set; } = new List<TblActdailyPlanHeader>();

    public virtual ICollection<TblActdepartmentGoalHeader> TblActdepartmentGoalHeaders { get; set; } = new List<TblActdepartmentGoalHeader>();

    public virtual ICollection<TblActexitInterviewResultHeader> TblActexitInterviewResultHeaders { get; set; } = new List<TblActexitInterviewResultHeader>();

    public virtual ICollection<TblActivityAol> TblActivityAols { get; set; } = new List<TblActivityAol>();

    public virtual ICollection<TblActmentorReflection> TblActmentorReflections { get; set; } = new List<TblActmentorReflection>();

    public virtual ICollection<TblActmentoringHomeVisit> TblActmentoringHomeVisits { get; set; } = new List<TblActmentoringHomeVisit>();

    public virtual ICollection<TblActmentoringPlan> TblActmentoringPlans { get; set; } = new List<TblActmentoringPlan>();

    public virtual ICollection<TblActmentoringSchedule> TblActmentoringSchedules { get; set; } = new List<TblActmentoringSchedule>();

    public virtual ICollection<TblActmentoringUnPlanned> TblActmentoringUnPlanneds { get; set; } = new List<TblActmentoringUnPlanned>();

    public virtual ICollection<TblActprincipalReportMainHeadingDetail> TblActprincipalReportMainHeadingDetails { get; set; } = new List<TblActprincipalReportMainHeadingDetail>();

    public virtual ICollection<TblActprincipalReportMainHeadingDetailsDatum> TblActprincipalReportMainHeadingDetailsData { get; set; } = new List<TblActprincipalReportMainHeadingDetailsDatum>();

    public virtual ICollection<TblActprincipalReportMainHeading> TblActprincipalReportMainHeadings { get; set; } = new List<TblActprincipalReportMainHeading>();

    public virtual ICollection<TblActprincipalReportSubCategoryHeadingDatum> TblActprincipalReportSubCategoryHeadingData { get; set; } = new List<TblActprincipalReportSubCategoryHeadingDatum>();

    public virtual ICollection<TblActprincipalReportSubCategoryHeading> TblActprincipalReportSubCategoryHeadings { get; set; } = new List<TblActprincipalReportSubCategoryHeading>();

    public virtual ICollection<TblActprincipalReportSubHeadingDetail> TblActprincipalReportSubHeadingDetails { get; set; } = new List<TblActprincipalReportSubHeadingDetail>();

    public virtual ICollection<TblActprincipalReportSubHeadingDetailsDatum> TblActprincipalReportSubHeadingDetailsData { get; set; } = new List<TblActprincipalReportSubHeadingDetailsDatum>();

    public virtual ICollection<TblActprincipalReportSubHeading> TblActprincipalReportSubHeadings { get; set; } = new List<TblActprincipalReportSubHeading>();

    public virtual ICollection<TblActptmrecord> TblActptmrecords { get; set; } = new List<TblActptmrecord>();

    public virtual ICollection<TblActremedialPlanSessionwise> TblActremedialPlanSessionwises { get; set; } = new List<TblActremedialPlanSessionwise>();

    public virtual ICollection<TblActremedialStudent> TblActremedialStudents { get; set; } = new List<TblActremedialStudent>();

    public virtual ICollection<TblActremedialStudentsSubject> TblActremedialStudentsSubjects { get; set; } = new List<TblActremedialStudentsSubject>();

    public virtual ICollection<TblActschool> TblActschools { get; set; } = new List<TblActschool>();

    public virtual ICollection<TblActssfconfigDetail> TblActssfconfigDetails { get; set; } = new List<TblActssfconfigDetail>();

    public virtual ICollection<TblActssfconfigHeader> TblActssfconfigHeaders { get; set; } = new List<TblActssfconfigHeader>();

    public virtual ICollection<TblActssfinteraction> TblActssfinteractionOrgs { get; set; } = new List<TblActssfinteraction>();

    public virtual ICollection<TblActssfinteraction> TblActssfinteractionRelatedToOrgs { get; set; } = new List<TblActssfinteraction>();

    public virtual ICollection<TblActsubstituionRecord> TblActsubstituionRecords { get; set; } = new List<TblActsubstituionRecord>();

    public virtual ICollection<TblActtrainingFeedbackHeader> TblActtrainingFeedbackHeaders { get; set; } = new List<TblActtrainingFeedbackHeader>();

    public virtual ICollection<TblActvisitDetail> TblActvisitDetails { get; set; } = new List<TblActvisitDetail>();

    public virtual ICollection<TblActvisitHeader> TblActvisitHeaderOrgs { get; set; } = new List<TblActvisitHeader>();

    public virtual ICollection<TblActvisitHeader> TblActvisitHeaderVisitingOrgs { get; set; } = new List<TblActvisitHeader>();

    public virtual ICollection<TblActwallOfFrameDoc> TblActwallOfFrameDocs { get; set; } = new List<TblActwallOfFrameDoc>();

    public virtual ICollection<TblActyearPlanHeader> TblActyearPlanHeaders { get; set; } = new List<TblActyearPlanHeader>();

    public virtual ICollection<TblActyearlyGoalHeader> TblActyearlyGoalHeaderOrgs { get; set; } = new List<TblActyearlyGoalHeader>();

    public virtual ICollection<TblActyearlyGoalHeader> TblActyearlyGoalHeaderUserOrgs { get; set; } = new List<TblActyearlyGoalHeader>();

    public virtual ICollection<TblActyearlyGoalPerson> TblActyearlyGoalPeople { get; set; } = new List<TblActyearlyGoalPerson>();

    public virtual ICollection<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; } = new List<TblAdvanceFeeDebit>();

    public virtual ICollection<TblAdvancedFeePayment> TblAdvancedFeePayments { get; set; } = new List<TblAdvancedFeePayment>();

    public virtual ICollection<TblAolcomment> TblAolcomments { get; set; } = new List<TblAolcomment>();

    public virtual ICollection<TblAolstudentEntry> TblAolstudentEntries { get; set; } = new List<TblAolstudentEntry>();

    public virtual ICollection<TblAppMenuDefinition> TblAppMenuDefinitions { get; set; } = new List<TblAppMenuDefinition>();

    public virtual ICollection<TblAppMenuOrg> TblAppMenuOrgs { get; set; } = new List<TblAppMenuOrg>();

    public virtual ICollection<TblAppParentMessageContent> TblAppParentMessageContents { get; set; } = new List<TblAppParentMessageContent>();

    public virtual ICollection<TblAreaOfLearning> TblAreaOfLearnings { get; set; } = new List<TblAreaOfLearning>();

    public virtual ICollection<TblAssetAttribute> TblAssetAttributes { get; set; } = new List<TblAssetAttribute>();

    public virtual ICollection<TblAssetCategory> TblAssetCategories { get; set; } = new List<TblAssetCategory>();

    public virtual ICollection<TblAssetCategoryAttribute> TblAssetCategoryAttributes { get; set; } = new List<TblAssetCategoryAttribute>();

    public virtual ICollection<TblAssetLocation> TblAssetLocations { get; set; } = new List<TblAssetLocation>();

    public virtual ICollection<TblAssetRequest> TblAssetRequests { get; set; } = new List<TblAssetRequest>();

    public virtual ICollection<TblAssetTrackingLog> TblAssetTrackingLogs { get; set; } = new List<TblAssetTrackingLog>();

    public virtual ICollection<TblAssetTracking> TblAssetTrackings { get; set; } = new List<TblAssetTracking>();

    public virtual ICollection<TblAsset> TblAssets { get; set; } = new List<TblAsset>();

    public virtual ICollection<TblAssignmentQuestion> TblAssignmentQuestions { get; set; } = new List<TblAssignmentQuestion>();

    public virtual ICollection<TblAssignment> TblAssignments { get; set; } = new List<TblAssignment>();

    public virtual ICollection<TblAttendanceConfig> TblAttendanceConfigs { get; set; } = new List<TblAttendanceConfig>();

    public virtual ICollection<TblAttendanceHourly> TblAttendanceHourlies { get; set; } = new List<TblAttendanceHourly>();

    public virtual ICollection<TblAttendanceHourlyOtherProgram> TblAttendanceHourlyOtherPrograms { get; set; } = new List<TblAttendanceHourlyOtherProgram>();

    public virtual ICollection<TblAttendance> TblAttendances { get; set; } = new List<TblAttendance>();

    public virtual ICollection<TblBankDetail> TblBankDetails { get; set; } = new List<TblBankDetail>();

    public virtual ICollection<TblBatchAdmissionArchive> TblBatchAdmissionArchives { get; set; } = new List<TblBatchAdmissionArchive>();

    public virtual ICollection<TblBatchAdmissionPast> TblBatchAdmissionPasts { get; set; } = new List<TblBatchAdmissionPast>();

    public virtual ICollection<TblBatchAdmission> TblBatchAdmissions { get; set; } = new List<TblBatchAdmission>();

    public virtual ICollection<TblBatch> TblBatches { get; set; } = new List<TblBatch>();

    public virtual ICollection<TblBlockAttributesCce> TblBlockAttributesCces { get; set; } = new List<TblBlockAttributesCce>();

    public virtual ICollection<TblBlockCce> TblBlockCces { get; set; } = new List<TblBlockCce>();

    public virtual ICollection<TblBranch> TblBranches { get; set; } = new List<TblBranch>();

    public virtual ICollection<TblCalenderAssignment> TblCalenderAssignmentEmpOrgs { get; set; } = new List<TblCalenderAssignment>();

    public virtual ICollection<TblCalenderAssignment> TblCalenderAssignmentOrgs { get; set; } = new List<TblCalenderAssignment>();

    public virtual ICollection<TblCalenderDetail> TblCalenderDetails { get; set; } = new List<TblCalenderDetail>();

    public virtual ICollection<TblCalenderHeaader> TblCalenderHeaaders { get; set; } = new List<TblCalenderHeaader>();

    public virtual ICollection<TblCaste> TblCastes { get; set; } = new List<TblCaste>();

    public virtual ICollection<TblCertificate> TblCertificates { get; set; } = new List<TblCertificate>();

    public virtual ICollection<TblChannel> TblChannels { get; set; } = new List<TblChannel>();

    public virtual ICollection<TblCircular> TblCirculars { get; set; } = new List<TblCircular>();

    public virtual ICollection<TblCounsellor> TblCounsellors { get; set; } = new List<TblCounsellor>();

    public virtual ICollection<TblCourseFeeDetail> TblCourseFeeDetails { get; set; } = new List<TblCourseFeeDetail>();

    public virtual ICollection<TblCourseSubject> TblCourseSubjects { get; set; } = new List<TblCourseSubject>();

    public virtual ICollection<TblCourse> TblCourses { get; set; } = new List<TblCourse>();

    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    public virtual ICollection<TblDepartment> TblDepartments { get; set; } = new List<TblDepartment>();

    public virtual ICollection<TblDesignation> TblDesignations { get; set; } = new List<TblDesignation>();

    public virtual ICollection<TblDietPlanDetail> TblDietPlanDetails { get; set; } = new List<TblDietPlanDetail>();

    public virtual ICollection<TblDietPlanLinkedStudent> TblDietPlanLinkedStudents { get; set; } = new List<TblDietPlanLinkedStudent>();

    public virtual ICollection<TblDietPlanRecording> TblDietPlanRecordings { get; set; } = new List<TblDietPlanRecording>();

    public virtual ICollection<TblDietPlan> TblDietPlans { get; set; } = new List<TblDietPlan>();

    public virtual ICollection<TblDietaryItem> TblDietaryItems { get; set; } = new List<TblDietaryItem>();

    public virtual ICollection<TblDiscountType> TblDiscountTypes { get; set; } = new List<TblDiscountType>();

    public virtual ICollection<TblDmsrootUser> TblDmsrootUsers { get; set; } = new List<TblDmsrootUser>();

    public virtual ICollection<TblDocumentFolder> TblDocumentFolders { get; set; } = new List<TblDocumentFolder>();

    public virtual ICollection<TblDocumentTagName> TblDocumentTagNames { get; set; } = new List<TblDocumentTagName>();

    public virtual ICollection<TblDocumentTag> TblDocumentTags { get; set; } = new List<TblDocumentTag>();

    public virtual ICollection<TblDocumentVersion> TblDocumentVersions { get; set; } = new List<TblDocumentVersion>();

    public virtual ICollection<TblDocument> TblDocuments { get; set; } = new List<TblDocument>();

    public virtual ICollection<TblDriverAttachment> TblDriverAttachments { get; set; } = new List<TblDriverAttachment>();

    public virtual ICollection<TblDriver> TblDrivers { get; set; } = new List<TblDriver>();

    public virtual ICollection<TblEmailLog> TblEmailLogs { get; set; } = new List<TblEmailLog>();

    public virtual ICollection<TblEmailTemplate> TblEmailTemplates { get; set; } = new List<TblEmailTemplate>();

    public virtual ICollection<TblEmpLeaveApplied> TblEmpLeaveApplieds { get; set; } = new List<TblEmpLeaveApplied>();

    public virtual ICollection<TblEmpSalaryDetail> TblEmpSalaryDetails { get; set; } = new List<TblEmpSalaryDetail>();

    public virtual ICollection<TblEmployeeAdditionalInfo> TblEmployeeAdditionalInfos { get; set; } = new List<TblEmployeeAdditionalInfo>();

    public virtual ICollection<TblEmployeeAttachment> TblEmployeeAttachments { get; set; } = new List<TblEmployeeAttachment>();

    public virtual ICollection<TblEmployeeAttendance> TblEmployeeAttendances { get; set; } = new List<TblEmployeeAttendance>();

    public virtual ICollection<TblEmployeeAttrition> TblEmployeeAttritions { get; set; } = new List<TblEmployeeAttrition>();

    public virtual ICollection<TblEmployeeExitCheckList> TblEmployeeExitCheckLists { get; set; } = new List<TblEmployeeExitCheckList>();

    public virtual ICollection<TblEmployeeGroupDetail> TblEmployeeGroupDetails { get; set; } = new List<TblEmployeeGroupDetail>();

    public virtual ICollection<TblEmployeeGroupHeader> TblEmployeeGroupHeaders { get; set; } = new List<TblEmployeeGroupHeader>();

    public virtual ICollection<TblEmployeeLeaveType> TblEmployeeLeaveTypes { get; set; } = new List<TblEmployeeLeaveType>();

    public virtual ICollection<TblEmployeeLetterTemplate> TblEmployeeLetterTemplates { get; set; } = new List<TblEmployeeLetterTemplate>();

    public virtual ICollection<TblEmployeeLetter> TblEmployeeLetters { get; set; } = new List<TblEmployeeLetter>();

    public virtual ICollection<TblEmployeeSalaryComponent> TblEmployeeSalaryComponents { get; set; } = new List<TblEmployeeSalaryComponent>();

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();

    public virtual ICollection<TblEventType> TblEventTypes { get; set; } = new List<TblEventType>();

    public virtual ICollection<TblEvent> TblEvents { get; set; } = new List<TblEvent>();

    public virtual ICollection<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; } = new List<TblExamAttributeWiseMark>();

    public virtual ICollection<TblExamHall> TblExamHalls { get; set; } = new List<TblExamHall>();

    public virtual ICollection<TblExamMark> TblExamMarks { get; set; } = new List<TblExamMark>();

    public virtual ICollection<TblExamSchedule> TblExamSchedules { get; set; } = new List<TblExamSchedule>();

    public virtual ICollection<TblExamTypeLinkedWithCourse> TblExamTypeLinkedWithCourses { get; set; } = new List<TblExamTypeLinkedWithCourse>();

    public virtual ICollection<TblExamTypeLinkedWithSubject> TblExamTypeLinkedWithSubjects { get; set; } = new List<TblExamTypeLinkedWithSubject>();

    public virtual ICollection<TblExamType> TblExamTypes { get; set; } = new List<TblExamType>();

    public virtual ICollection<TblExitInterviewQuestionnaire> TblExitInterviewQuestionnaires { get; set; } = new List<TblExitInterviewQuestionnaire>();

    public virtual ICollection<TblExpenditureDoc> TblExpenditureDocs { get; set; } = new List<TblExpenditureDoc>();

    public virtual ICollection<TblExpenseCategory> TblExpenseCategories { get; set; } = new List<TblExpenseCategory>();

    public virtual ICollection<TblExpenseDetail> TblExpenseDetails { get; set; } = new List<TblExpenseDetail>();

    public virtual ICollection<TblFeeDescription> TblFeeDescriptions { get; set; } = new List<TblFeeDescription>();

    public virtual ICollection<TblFeeInstallmentDetail> TblFeeInstallmentDetails { get; set; } = new List<TblFeeInstallmentDetail>();

    public virtual ICollection<TblFeeItemDetail> TblFeeItemDetails { get; set; } = new List<TblFeeItemDetail>();

    public virtual ICollection<TblFeeLedgerGroup> TblFeeLedgerGroups { get; set; } = new List<TblFeeLedgerGroup>();

    public virtual ICollection<TblFeeLinkedInventoryItem> TblFeeLinkedInventoryItems { get; set; } = new List<TblFeeLinkedInventoryItem>();

    public virtual ICollection<TblFeePaidDetail> TblFeePaidDetails { get; set; } = new List<TblFeePaidDetail>();

    public virtual ICollection<TblFeePaymentDetail> TblFeePaymentDetails { get; set; } = new List<TblFeePaymentDetail>();

    public virtual ICollection<TblFeePaymentMode> TblFeePaymentModes { get; set; } = new List<TblFeePaymentMode>();

    public virtual ICollection<TblFeedback> TblFeedbacks { get; set; } = new List<TblFeedback>();

    public virtual ICollection<TblFinancialYear> TblFinancialYears { get; set; } = new List<TblFinancialYear>();

    public virtual ICollection<TblFormativeAssessmentCce> TblFormativeAssessmentCces { get; set; } = new List<TblFormativeAssessmentCce>();

    public virtual ICollection<TblFranchiseDetail> TblFranchiseDetails { get; set; } = new List<TblFranchiseDetail>();

    public virtual ICollection<TblGallery> TblGalleries { get; set; } = new List<TblGallery>();

    public virtual ICollection<TblGlobalOrgSetting> TblGlobalOrgSettings { get; set; } = new List<TblGlobalOrgSetting>();

    public virtual ICollection<TblGpsdatum> TblGpsdata { get; set; } = new List<TblGpsdatum>();

    public virtual ICollection<TblGradeSystem> TblGradeSystems { get; set; } = new List<TblGradeSystem>();

    public virtual ICollection<TblGradesystemDetail> TblGradesystemDetails { get; set; } = new List<TblGradesystemDetail>();

    public virtual ICollection<TblGrievanceCategory> TblGrievanceCategories { get; set; } = new List<TblGrievanceCategory>();

    public virtual ICollection<TblGrievanceRecord> TblGrievanceRecords { get; set; } = new List<TblGrievanceRecord>();

    public virtual ICollection<TblGrnPoDetail> TblGrnPoDetails { get; set; } = new List<TblGrnPoDetail>();

    public virtual ICollection<TblGrnPoHeader> TblGrnPoHeaders { get; set; } = new List<TblGrnPoHeader>();

    public virtual ICollection<TblGroupMember> TblGroupMembers { get; set; } = new List<TblGroupMember>();

    public virtual ICollection<TblGroup> TblGroups { get; set; } = new List<TblGroup>();

    public virtual ICollection<TblHolidayList> TblHolidayLists { get; set; } = new List<TblHolidayList>();

    public virtual ICollection<TblHostelBilling> TblHostelBillings { get; set; } = new List<TblHostelBilling>();

    public virtual ICollection<TblHostelRoom1> TblHostelRoom1s { get; set; } = new List<TblHostelRoom1>();

    public virtual ICollection<TblHostelRoomStudent> TblHostelRoomStudents { get; set; } = new List<TblHostelRoomStudent>();

    public virtual ICollection<TblHostelRoom> TblHostelRooms { get; set; } = new List<TblHostelRoom>();

    public virtual ICollection<TblHostelType> TblHostelTypes { get; set; } = new List<TblHostelType>();

    public virtual ICollection<TblHostel> TblHostels { get; set; } = new List<TblHostel>();

    public virtual ICollection<TblImageGallery> TblImageGalleries { get; set; } = new List<TblImageGallery>();

    public virtual ICollection<TblInactiveEmployeeLog> TblInactiveEmployeeLogs { get; set; } = new List<TblInactiveEmployeeLog>();

    public virtual ICollection<TblInactiveEmployee> TblInactiveEmployees { get; set; } = new List<TblInactiveEmployee>();

    public virtual ICollection<TblInactiveStudentLog> TblInactiveStudentLogs { get; set; } = new List<TblInactiveStudentLog>();

    public virtual ICollection<TblInactiveStudent> TblInactiveStudents { get; set; } = new List<TblInactiveStudent>();

    public virtual ICollection<TblIncomeHeader> TblIncomeHeaders { get; set; } = new List<TblIncomeHeader>();

    public virtual ICollection<TblIndicatorConfig> TblIndicatorConfigLoggedUserOrgs { get; set; } = new List<TblIndicatorConfig>();

    public virtual ICollection<TblIndicatorConfig> TblIndicatorConfigOrgs { get; set; } = new List<TblIndicatorConfig>();

    public virtual ICollection<TblIndicatorDetail> TblIndicatorDetails { get; set; } = new List<TblIndicatorDetail>();

    public virtual ICollection<TblIndicatorGroup> TblIndicatorGroups { get; set; } = new List<TblIndicatorGroup>();

    public virtual ICollection<TblIndicatorPoint> TblIndicatorPoints { get; set; } = new List<TblIndicatorPoint>();

    public virtual ICollection<TblIndicatorResultHeader> TblIndicatorResultHeaders { get; set; } = new List<TblIndicatorResultHeader>();

    public virtual ICollection<TblIndicatorResult> TblIndicatorResults { get; set; } = new List<TblIndicatorResult>();

    public virtual ICollection<TblIndicator> TblIndicators { get; set; } = new List<TblIndicator>();

    public virtual ICollection<TblInstallmentTemplateHeader> TblInstallmentTemplateHeaders { get; set; } = new List<TblInstallmentTemplateHeader>();

    public virtual ICollection<TblInstitution> TblInstitutions { get; set; } = new List<TblInstitution>();

    public virtual ICollection<TblIssueList> TblIssueLists { get; set; } = new List<TblIssueList>();

    public virtual ICollection<TblItemCategory> TblItemCategories { get; set; } = new List<TblItemCategory>();

    public virtual ICollection<TblItemVendor> TblItemVendors { get; set; } = new List<TblItemVendor>();

    public virtual ICollection<TblItem> TblItems { get; set; } = new List<TblItem>();

    public virtual ICollection<TblLeadFollowUp> TblLeadFollowUps { get; set; } = new List<TblLeadFollowUp>();

    public virtual ICollection<TblLearnoMeterCce> TblLearnoMeterCces { get; set; } = new List<TblLearnoMeterCce>();

    public virtual ICollection<TblLeaveType> TblLeaveTypes { get; set; } = new List<TblLeaveType>();

    public virtual ICollection<TblLibrary> TblLibraries { get; set; } = new List<TblLibrary>();

    public virtual ICollection<TblLibraryBookAuthor> TblLibraryBookAuthors { get; set; } = new List<TblLibraryBookAuthor>();

    public virtual ICollection<TblLibraryBookCategory> TblLibraryBookCategories { get; set; } = new List<TblLibraryBookCategory>();

    public virtual ICollection<TblLibraryBookEdition> TblLibraryBookEditions { get; set; } = new List<TblLibraryBookEdition>();

    public virtual ICollection<TblLibraryBookLedger> TblLibraryBookLedgers { get; set; } = new List<TblLibraryBookLedger>();

    public virtual ICollection<TblLibraryBookPublication> TblLibraryBookPublications { get; set; } = new List<TblLibraryBookPublication>();

    public virtual ICollection<TblLibraryBookVolume> TblLibraryBookVolumes { get; set; } = new List<TblLibraryBookVolume>();

    public virtual ICollection<TblLibraryBook> TblLibraryBooks { get; set; } = new List<TblLibraryBook>();

    public virtual ICollection<TblLogin> TblLogins { get; set; } = new List<TblLogin>();

    public virtual ICollection<TblMarksCardDetail> TblMarksCardDetails { get; set; } = new List<TblMarksCardDetail>();

    public virtual ICollection<TblMedicineDetail> TblMedicineDetails { get; set; } = new List<TblMedicineDetail>();

    public virtual ICollection<TblMenu> TblMenus { get; set; } = new List<TblMenu>();

    public virtual ICollection<TblMessageAttachment> TblMessageAttachments { get; set; } = new List<TblMessageAttachment>();

    public virtual ICollection<TblMessageCenter> TblMessageCenters { get; set; } = new List<TblMessageCenter>();

    public virtual ICollection<TblMessageRecipient> TblMessageRecipients { get; set; } = new List<TblMessageRecipient>();

    public virtual ICollection<TblMonthlyBillingDatum> TblMonthlyBillingData { get; set; } = new List<TblMonthlyBillingDatum>();

    public virtual ICollection<TblNationality> TblNationalities { get; set; } = new List<TblNationality>();

    public virtual ICollection<TblNewsLetter> TblNewsLetters { get; set; } = new List<TblNewsLetter>();

    public virtual ICollection<TblOtherProgram> TblOtherPrograms { get; set; } = new List<TblOtherProgram>();

    public virtual ICollection<TblOtherProgramsStudent> TblOtherProgramsStudents { get; set; } = new List<TblOtherProgramsStudent>();

    public virtual ICollection<TblPaatashalaBilling> TblPaatashalaBillings { get; set; } = new List<TblPaatashalaBilling>();

    public virtual ICollection<TblParentCommunication> TblParentCommunications { get; set; } = new List<TblParentCommunication>();

    public virtual ICollection<TblParentFeedbackHeader> TblParentFeedbackHeaders { get; set; } = new List<TblParentFeedbackHeader>();

    public virtual ICollection<TblParentMessageBox> TblParentMessageBoxes { get; set; } = new List<TblParentMessageBox>();

    public virtual ICollection<TblParentMessageOption1> TblParentMessageOption1s { get; set; } = new List<TblParentMessageOption1>();

    public virtual ICollection<TblPayGroupDetail> TblPayGroupDetails { get; set; } = new List<TblPayGroupDetail>();

    public virtual ICollection<TblPayGroup> TblPayGroups { get; set; } = new List<TblPayGroup>();

    public virtual ICollection<TblPayrollDetail> TblPayrollDetails { get; set; } = new List<TblPayrollDetail>();

    public virtual ICollection<TblPettyCashCategory> TblPettyCashCategories { get; set; } = new List<TblPettyCashCategory>();

    public virtual ICollection<TblPettyCashDetail> TblPettyCashDetails { get; set; } = new List<TblPettyCashDetail>();

    public virtual ICollection<TblPettyCashDoc> TblPettyCashDocs { get; set; } = new List<TblPettyCashDoc>();

    public virtual ICollection<TblPettyCashMaster> TblPettyCashMasters { get; set; } = new List<TblPettyCashMaster>();

    public virtual ICollection<TblPostDatedPayment> TblPostDatedPayments { get; set; } = new List<TblPostDatedPayment>();

    public virtual ICollection<TblPrincipalMonthlyReport> TblPrincipalMonthlyReports { get; set; } = new List<TblPrincipalMonthlyReport>();

    public virtual ICollection<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; } = new List<TblPurchaseOrderDetail>();

    public virtual ICollection<TblPurchaseOrderHeader> TblPurchaseOrderHeaders { get; set; } = new List<TblPurchaseOrderHeader>();

    public virtual ICollection<TblQuestionBank> TblQuestionBanks { get; set; } = new List<TblQuestionBank>();

    public virtual ICollection<TblReportSentDetail> TblReportSentDetails { get; set; } = new List<TblReportSentDetail>();

    public virtual ICollection<TblRolePermission> TblRolePermissions { get; set; } = new List<TblRolePermission>();

    public virtual ICollection<TblRoleWidget> TblRoleWidgets { get; set; } = new List<TblRoleWidget>();

    public virtual ICollection<TblRole> TblRoles { get; set; } = new List<TblRole>();

    public virtual ICollection<TblRouteStop1> TblRouteStop1s { get; set; } = new List<TblRouteStop1>();

    public virtual ICollection<TblRouteStop> TblRouteStops { get; set; } = new List<TblRouteStop>();

    public virtual ICollection<TblRouteVehicle> TblRouteVehicles { get; set; } = new List<TblRouteVehicle>();

    public virtual ICollection<TblRoute> TblRoutes { get; set; } = new List<TblRoute>();

    public virtual ICollection<TblRoyaltyFeeCollection> TblRoyaltyFeeCollections { get; set; } = new List<TblRoyaltyFeeCollection>();

    public virtual ICollection<TblRubricsConfiguration> TblRubricsConfigurationActorgs { get; set; } = new List<TblRubricsConfiguration>();

    public virtual ICollection<TblRubricsConfiguration> TblRubricsConfigurationOrgs { get; set; } = new List<TblRubricsConfiguration>();

    public virtual ICollection<TblRubricsRoleConfiguration> TblRubricsRoleConfigurationOrgs { get; set; } = new List<TblRubricsRoleConfiguration>();

    public virtual ICollection<TblRubricsRoleConfiguration> TblRubricsRoleConfigurationRoleOrgs { get; set; } = new List<TblRubricsRoleConfiguration>();

    public virtual ICollection<TblSector> TblSectors { get; set; } = new List<TblSector>();

    public virtual ICollection<TblSmsLog> TblSmsLogs { get; set; } = new List<TblSmsLog>();

    public virtual ICollection<TblSmscredential> TblSmscredentials { get; set; } = new List<TblSmscredential>();

    public virtual ICollection<TblSmstemplate> TblSmstemplates { get; set; } = new List<TblSmstemplate>();

    public virtual ICollection<TblSsgarchiveClientPayment> TblSsgarchiveClientPayments { get; set; } = new List<TblSsgarchiveClientPayment>();

    public virtual ICollection<TblSsgbillingDetail> TblSsgbillingDetails { get; set; } = new List<TblSsgbillingDetail>();

    public virtual ICollection<TblSsgclientPaymentDetail> TblSsgclientPaymentDetails { get; set; } = new List<TblSsgclientPaymentDetail>();

    public virtual ICollection<TblStockGroup> TblStockGroups { get; set; } = new List<TblStockGroup>();

    public virtual ICollection<TblStockItem> TblStockItems { get; set; } = new List<TblStockItem>();

    public virtual ICollection<TblStockItemsDeliveryHeader> TblStockItemsDeliveryHeaders { get; set; } = new List<TblStockItemsDeliveryHeader>();

    public virtual ICollection<TblStream> TblStreams { get; set; } = new List<TblStream>();

    public virtual ICollection<TblStudentActivity> TblStudentActivities { get; set; } = new List<TblStudentActivity>();

    public virtual ICollection<TblStudentActivityType> TblStudentActivityTypes { get; set; } = new List<TblStudentActivityType>();

    public virtual ICollection<TblStudentAttachment> TblStudentAttachments { get; set; } = new List<TblStudentAttachment>();

    public virtual ICollection<TblStudentCategory> TblStudentCategories { get; set; } = new List<TblStudentCategory>();

    public virtual ICollection<TblStudentCustomizeValue> TblStudentCustomizeValues { get; set; } = new List<TblStudentCustomizeValue>();

    public virtual ICollection<TblStudentCustomize> TblStudentCustomizes { get; set; } = new List<TblStudentCustomize>();

    public virtual ICollection<TblStudentFeePaidHeader> TblStudentFeePaidHeaders { get; set; } = new List<TblStudentFeePaidHeader>();

    public virtual ICollection<TblStudentFeedbackDetail> TblStudentFeedbackDetails { get; set; } = new List<TblStudentFeedbackDetail>();

    public virtual ICollection<TblStudentFeedbackMain> TblStudentFeedbackMains { get; set; } = new List<TblStudentFeedbackMain>();

    public virtual ICollection<TblStudentFeedbackMobileAppQuestion> TblStudentFeedbackMobileAppQuestions { get; set; } = new List<TblStudentFeedbackMobileAppQuestion>();

    public virtual ICollection<TblStudentFeedbackQuestionnaire> TblStudentFeedbackQuestionnaires { get; set; } = new List<TblStudentFeedbackQuestionnaire>();

    public virtual ICollection<TblStudentKitItem> TblStudentKitItems { get; set; } = new List<TblStudentKitItem>();

    public virtual ICollection<TblStudentKit> TblStudentKits { get; set; } = new List<TblStudentKit>();

    public virtual ICollection<TblStudentMedicine> TblStudentMedicines { get; set; } = new List<TblStudentMedicine>();

    public virtual ICollection<TblStudentPrevQualificationReason> TblStudentPrevQualificationReasons { get; set; } = new List<TblStudentPrevQualificationReason>();

    public virtual ICollection<TblStudentQualification> TblStudentQualifications { get; set; } = new List<TblStudentQualification>();

    public virtual ICollection<TblStudentRegistration> TblStudentRegistrations { get; set; } = new List<TblStudentRegistration>();

    public virtual ICollection<TblStudentResultsCce> TblStudentResultsCces { get; set; } = new List<TblStudentResultsCce>();

    public virtual ICollection<TblStudentValue> TblStudentValues { get; set; } = new List<TblStudentValue>();

    public virtual ICollection<TblStudent> TblStudents { get; set; } = new List<TblStudent>();

    public virtual ICollection<TblSubBlockCce> TblSubBlockCces { get; set; } = new List<TblSubBlockCce>();

    public virtual ICollection<TblSubCaste> TblSubCastes { get; set; } = new List<TblSubCaste>();

    public virtual ICollection<TblSubComponentAttribute> TblSubComponentAttributes { get; set; } = new List<TblSubComponentAttribute>();

    public virtual ICollection<TblSubjectSubComponent> TblSubjectSubComponents { get; set; } = new List<TblSubjectSubComponent>();

    public virtual ICollection<TblSubject> TblSubjects { get; set; } = new List<TblSubject>();

    public virtual ICollection<TblSummativeAssessmentCce> TblSummativeAssessmentCces { get; set; } = new List<TblSummativeAssessmentCce>();

    public virtual ICollection<TblTaxDetail> TblTaxDetails { get; set; } = new List<TblTaxDetail>();

    public virtual ICollection<TblTaxType> TblTaxTypes { get; set; } = new List<TblTaxType>();

    public virtual ICollection<TblTermCce> TblTermCces { get; set; } = new List<TblTermCce>();

    public virtual ICollection<TblTerm> TblTerms { get; set; } = new List<TblTerm>();

    public virtual ICollection<TblThemeAol> TblThemeAols { get; set; } = new List<TblThemeAol>();

    public virtual ICollection<TblTimeTableDetail> TblTimeTableDetails { get; set; } = new List<TblTimeTableDetail>();

    public virtual ICollection<TblTimetableWorkingDay> TblTimetableWorkingDays { get; set; } = new List<TblTimetableWorkingDay>();

    public virtual ICollection<TblTopic> TblTopics { get; set; } = new List<TblTopic>();

    public virtual ICollection<TblTrainingFeedbackQuestion> TblTrainingFeedbackQuestions { get; set; } = new List<TblTrainingFeedbackQuestion>();

    public virtual ICollection<TblTrainingReportReview> TblTrainingReportReviews { get; set; } = new List<TblTrainingReportReview>();

    public virtual ICollection<TblTrainingScheduleHeader> TblTrainingScheduleHeaders { get; set; } = new List<TblTrainingScheduleHeader>();

    public virtual ICollection<TblTrainingSessionHeader> TblTrainingSessionHeaders { get; set; } = new List<TblTrainingSessionHeader>();

    public virtual ICollection<TblTraningSchedule> TblTraningScheduleEmpOrgs { get; set; } = new List<TblTraningSchedule>();

    public virtual ICollection<TblTraningSchedule> TblTraningScheduleOrgs { get; set; } = new List<TblTraningSchedule>();

    public virtual ICollection<TblTransportPayment> TblTransportPayments { get; set; } = new List<TblTransportPayment>();

    public virtual ICollection<TblTransportTripSheet> TblTransportTripSheets { get; set; } = new List<TblTransportTripSheet>();

    public virtual ICollection<TblTripParticipant> TblTripParticipants { get; set; } = new List<TblTripParticipant>();

    public virtual ICollection<TblTripSheet> TblTripSheets { get; set; } = new List<TblTripSheet>();

    public virtual ICollection<TblUnitOfMeasure> TblUnitOfMeasures { get; set; } = new List<TblUnitOfMeasure>();

    public virtual ICollection<TblVehicleAttachment> TblVehicleAttachments { get; set; } = new List<TblVehicleAttachment>();

    public virtual ICollection<TblVehicleDevice> TblVehicleDevices { get; set; } = new List<TblVehicleDevice>();

    public virtual ICollection<TblVehicleType> TblVehicleTypes { get; set; } = new List<TblVehicleType>();

    public virtual ICollection<TblVehicle> TblVehicles { get; set; } = new List<TblVehicle>();

    public virtual ICollection<TblVendor> TblVendors { get; set; } = new List<TblVendor>();

    public virtual ICollection<TblVideoGallery> TblVideoGalleries { get; set; } = new List<TblVideoGallery>();

    public virtual ICollection<TblVisitorMaterial> TblVisitorMaterials { get; set; } = new List<TblVisitorMaterial>();

    public virtual ICollection<TblVisitor> TblVisitors { get; set; } = new List<TblVisitor>();

    public virtual ICollection<TblVisualTimeTablePhotoType> TblVisualTimeTablePhotoTypes { get; set; } = new List<TblVisualTimeTablePhotoType>();

    public virtual ICollection<TblVoucherList> TblVoucherLists { get; set; } = new List<TblVoucherList>();
}
