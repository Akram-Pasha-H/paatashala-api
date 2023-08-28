using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PaatashalaApi.Models;

public partial class WebSchoolContext : DbContext
{
    public WebSchoolContext()
    {
    }

    public WebSchoolContext(DbContextOptions<WebSchoolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CounsellorNote> CounsellorNotes { get; set; }

    public virtual DbSet<TblAbsentAttendance> TblAbsentAttendances { get; set; }

    public virtual DbSet<TblAccountGroup> TblAccountGroups { get; set; }

    public virtual DbSet<TblAccountLedger> TblAccountLedgers { get; set; }

    public virtual DbSet<TblActExitInterviewResultDetail> TblActExitInterviewResultDetails { get; set; }

    public virtual DbSet<TblActRemedialPlanSubjectWise> TblActRemedialPlanSubjectWises { get; set; }

    public virtual DbSet<TblActacademicCoordinator> TblActacademicCoordinators { get; set; }

    public virtual DbSet<TblActacademicHandholdingChecklist> TblActacademicHandholdingChecklists { get; set; }

    public virtual DbSet<TblActahreport> TblActahreports { get; set; }

    public virtual DbSet<TblActahreportHeader> TblActahreportHeaders { get; set; }

    public virtual DbSet<TblActappraisalDetail> TblActappraisalDetails { get; set; }

    public virtual DbSet<TblActappraisalHeader> TblActappraisalHeaders { get; set; }

    public virtual DbSet<TblActconfiguration> TblActconfigurations { get; set; }

    public virtual DbSet<TblActdailyPlanDetail> TblActdailyPlanDetails { get; set; }

    public virtual DbSet<TblActdailyPlanHeader> TblActdailyPlanHeaders { get; set; }

    public virtual DbSet<TblActdepartmentGoalDetail> TblActdepartmentGoalDetails { get; set; }

    public virtual DbSet<TblActdepartmentGoalHeader> TblActdepartmentGoalHeaders { get; set; }

    public virtual DbSet<TblActexitInterviewResultHeader> TblActexitInterviewResultHeaders { get; set; }

    public virtual DbSet<TblActivityAol> TblActivityAols { get; set; }

    public virtual DbSet<TblActmentorReflection> TblActmentorReflections { get; set; }

    public virtual DbSet<TblActmentoringHomeVisit> TblActmentoringHomeVisits { get; set; }

    public virtual DbSet<TblActmentoringPlan> TblActmentoringPlans { get; set; }

    public virtual DbSet<TblActmentoringSchedule> TblActmentoringSchedules { get; set; }

    public virtual DbSet<TblActmentoringUnPlanned> TblActmentoringUnPlanneds { get; set; }

    public virtual DbSet<TblActprincipalReportMainHeading> TblActprincipalReportMainHeadings { get; set; }

    public virtual DbSet<TblActprincipalReportMainHeadingDetail> TblActprincipalReportMainHeadingDetails { get; set; }

    public virtual DbSet<TblActprincipalReportMainHeadingDetailsDatum> TblActprincipalReportMainHeadingDetailsData { get; set; }

    public virtual DbSet<TblActprincipalReportSubCategoryHeading> TblActprincipalReportSubCategoryHeadings { get; set; }

    public virtual DbSet<TblActprincipalReportSubCategoryHeadingDatum> TblActprincipalReportSubCategoryHeadingData { get; set; }

    public virtual DbSet<TblActprincipalReportSubHeading> TblActprincipalReportSubHeadings { get; set; }

    public virtual DbSet<TblActprincipalReportSubHeadingDetail> TblActprincipalReportSubHeadingDetails { get; set; }

    public virtual DbSet<TblActprincipalReportSubHeadingDetailsDatum> TblActprincipalReportSubHeadingDetailsData { get; set; }

    public virtual DbSet<TblActptmrecord> TblActptmrecords { get; set; }

    public virtual DbSet<TblActremedialPlanSessionwise> TblActremedialPlanSessionwises { get; set; }

    public virtual DbSet<TblActremedialStudent> TblActremedialStudents { get; set; }

    public virtual DbSet<TblActremedialStudentsSubject> TblActremedialStudentsSubjects { get; set; }

    public virtual DbSet<TblActschool> TblActschools { get; set; }

    public virtual DbSet<TblActssfconfigDetail> TblActssfconfigDetails { get; set; }

    public virtual DbSet<TblActssfconfigHeader> TblActssfconfigHeaders { get; set; }

    public virtual DbSet<TblActssfinteraction> TblActssfinteractions { get; set; }

    public virtual DbSet<TblActsubstituionRecord> TblActsubstituionRecords { get; set; }

    public virtual DbSet<TblActtrainingFeedbackDetail> TblActtrainingFeedbackDetails { get; set; }

    public virtual DbSet<TblActtrainingFeedbackHeader> TblActtrainingFeedbackHeaders { get; set; }

    public virtual DbSet<TblActvisitDetail> TblActvisitDetails { get; set; }

    public virtual DbSet<TblActvisitHeader> TblActvisitHeaders { get; set; }

    public virtual DbSet<TblActwallOfFrameDoc> TblActwallOfFrameDocs { get; set; }

    public virtual DbSet<TblActyearPlanDetail> TblActyearPlanDetails { get; set; }

    public virtual DbSet<TblActyearPlanHeader> TblActyearPlanHeaders { get; set; }

    public virtual DbSet<TblActyearlyGoalHeader> TblActyearlyGoalHeaders { get; set; }

    public virtual DbSet<TblActyearlyGoalPerson> TblActyearlyGoalPeople { get; set; }

    public virtual DbSet<TblActyearlyGoalTarget> TblActyearlyGoalTargets { get; set; }

    public virtual DbSet<TblAdmissionStatusType> TblAdmissionStatusTypes { get; set; }

    public virtual DbSet<TblAdvanceFeeDebit> TblAdvanceFeeDebits { get; set; }

    public virtual DbSet<TblAdvancedFeePayment> TblAdvancedFeePayments { get; set; }

    public virtual DbSet<TblAffiliation> TblAffiliations { get; set; }

    public virtual DbSet<TblAolcomment> TblAolcomments { get; set; }

    public virtual DbSet<TblAolstudentEntry> TblAolstudentEntries { get; set; }

    public virtual DbSet<TblAppLogin> TblAppLogins { get; set; }

    public virtual DbSet<TblAppMenuDefinition> TblAppMenuDefinitions { get; set; }

    public virtual DbSet<TblAppMenuName> TblAppMenuNames { get; set; }

    public virtual DbSet<TblAppMenuOrg> TblAppMenuOrgs { get; set; }

    public virtual DbSet<TblAppParentMessageContent> TblAppParentMessageContents { get; set; }

    public virtual DbSet<TblAppVersion> TblAppVersions { get; set; }

    public virtual DbSet<TblApplicationLog> TblApplicationLogs { get; set; }

    public virtual DbSet<TblAreaOfLearning> TblAreaOfLearnings { get; set; }

    public virtual DbSet<TblAsset> TblAssets { get; set; }

    public virtual DbSet<TblAssetAttribute> TblAssetAttributes { get; set; }

    public virtual DbSet<TblAssetCategory> TblAssetCategories { get; set; }

    public virtual DbSet<TblAssetCategoryAttribute> TblAssetCategoryAttributes { get; set; }

    public virtual DbSet<TblAssetLocation> TblAssetLocations { get; set; }

    public virtual DbSet<TblAssetRequest> TblAssetRequests { get; set; }

    public virtual DbSet<TblAssetTracking> TblAssetTrackings { get; set; }

    public virtual DbSet<TblAssetTrackingLog> TblAssetTrackingLogs { get; set; }

    public virtual DbSet<TblAssignment> TblAssignments { get; set; }

    public virtual DbSet<TblAssignmentQuestion> TblAssignmentQuestions { get; set; }

    public virtual DbSet<TblAttendance> TblAttendances { get; set; }

    public virtual DbSet<TblAttendanceConfig> TblAttendanceConfigs { get; set; }

    public virtual DbSet<TblAttendanceHourly> TblAttendanceHourlies { get; set; }

    public virtual DbSet<TblAttendanceHourlyOtherProgram> TblAttendanceHourlyOtherPrograms { get; set; }

    public virtual DbSet<TblAttributeType> TblAttributeTypes { get; set; }

    public virtual DbSet<TblBankDetail> TblBankDetails { get; set; }

    public virtual DbSet<TblBarCodeSymbology> TblBarCodeSymbologies { get; set; }

    public virtual DbSet<TblBatch> TblBatches { get; set; }

    public virtual DbSet<TblBatchAdmission> TblBatchAdmissions { get; set; }

    public virtual DbSet<TblBatchAdmissionArchive> TblBatchAdmissionArchives { get; set; }

    public virtual DbSet<TblBatchAdmissionPast> TblBatchAdmissionPasts { get; set; }

    public virtual DbSet<TblBillingTemplate> TblBillingTemplates { get; set; }

    public virtual DbSet<TblBlockAttributesCce> TblBlockAttributesCces { get; set; }

    public virtual DbSet<TblBlockCce> TblBlockCces { get; set; }

    public virtual DbSet<TblBranch> TblBranches { get; set; }

    public virtual DbSet<TblCalenderAssignment> TblCalenderAssignments { get; set; }

    public virtual DbSet<TblCalenderDetail> TblCalenderDetails { get; set; }

    public virtual DbSet<TblCalenderHeaader> TblCalenderHeaaders { get; set; }

    public virtual DbSet<TblCaste> TblCastes { get; set; }

    public virtual DbSet<TblCertificate> TblCertificates { get; set; }

    public virtual DbSet<TblChallanInvoiceDetail> TblChallanInvoiceDetails { get; set; }

    public virtual DbSet<TblChallanInvoiceHeader> TblChallanInvoiceHeaders { get; set; }

    public virtual DbSet<TblChannel> TblChannels { get; set; }

    public virtual DbSet<TblCircular> TblCirculars { get; set; }

    public virtual DbSet<TblCounsellor> TblCounsellors { get; set; }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblCourseFeeDetail> TblCourseFeeDetails { get; set; }

    public virtual DbSet<TblCourseSubject> TblCourseSubjects { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblDatabaseLog> TblDatabaseLogs { get; set; }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblDesignation> TblDesignations { get; set; }

    public virtual DbSet<TblDietPlan> TblDietPlans { get; set; }

    public virtual DbSet<TblDietPlanDetail> TblDietPlanDetails { get; set; }

    public virtual DbSet<TblDietPlanLinkedStudent> TblDietPlanLinkedStudents { get; set; }

    public virtual DbSet<TblDietPlanRecording> TblDietPlanRecordings { get; set; }

    public virtual DbSet<TblDietaryItem> TblDietaryItems { get; set; }

    public virtual DbSet<TblDiscountType> TblDiscountTypes { get; set; }

    public virtual DbSet<TblDmsrootUser> TblDmsrootUsers { get; set; }

    public virtual DbSet<TblDocfolderAccess> TblDocfolderAccesses { get; set; }

    public virtual DbSet<TblDocument> TblDocuments { get; set; }

    public virtual DbSet<TblDocumentAccess> TblDocumentAccesses { get; set; }

    public virtual DbSet<TblDocumentFolder> TblDocumentFolders { get; set; }

    public virtual DbSet<TblDocumentTag> TblDocumentTags { get; set; }

    public virtual DbSet<TblDocumentTagName> TblDocumentTagNames { get; set; }

    public virtual DbSet<TblDocumentVersion> TblDocumentVersions { get; set; }

    public virtual DbSet<TblDriver> TblDrivers { get; set; }

    public virtual DbSet<TblDriverAttachment> TblDriverAttachments { get; set; }

    public virtual DbSet<TblEmailLog> TblEmailLogs { get; set; }

    public virtual DbSet<TblEmailTemplate> TblEmailTemplates { get; set; }

    public virtual DbSet<TblEmpLeaveApplied> TblEmpLeaveApplieds { get; set; }

    public virtual DbSet<TblEmpSalaryDetail> TblEmpSalaryDetails { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblEmployeeAdditionalInfo> TblEmployeeAdditionalInfos { get; set; }

    public virtual DbSet<TblEmployeeAttachment> TblEmployeeAttachments { get; set; }

    public virtual DbSet<TblEmployeeAttendance> TblEmployeeAttendances { get; set; }

    public virtual DbSet<TblEmployeeAttrition> TblEmployeeAttritions { get; set; }

    public virtual DbSet<TblEmployeeAttritionChecklist> TblEmployeeAttritionChecklists { get; set; }

    public virtual DbSet<TblEmployeeExitCheckList> TblEmployeeExitCheckLists { get; set; }

    public virtual DbSet<TblEmployeeGroupDetail> TblEmployeeGroupDetails { get; set; }

    public virtual DbSet<TblEmployeeGroupHeader> TblEmployeeGroupHeaders { get; set; }

    public virtual DbSet<TblEmployeeLeaveType> TblEmployeeLeaveTypes { get; set; }

    public virtual DbSet<TblEmployeeLetter> TblEmployeeLetters { get; set; }

    public virtual DbSet<TblEmployeeLetterTemplate> TblEmployeeLetterTemplates { get; set; }

    public virtual DbSet<TblEmployeeSalaryComponent> TblEmployeeSalaryComponents { get; set; }

    public virtual DbSet<TblEvent> TblEvents { get; set; }

    public virtual DbSet<TblEventType> TblEventTypes { get; set; }

    public virtual DbSet<TblExamAttributeWiseMark> TblExamAttributeWiseMarks { get; set; }

    public virtual DbSet<TblExamHall> TblExamHalls { get; set; }

    public virtual DbSet<TblExamMark> TblExamMarks { get; set; }

    public virtual DbSet<TblExamSchedule> TblExamSchedules { get; set; }

    public virtual DbSet<TblExamType> TblExamTypes { get; set; }

    public virtual DbSet<TblExamTypeLinkedWithComponent> TblExamTypeLinkedWithComponents { get; set; }

    public virtual DbSet<TblExamTypeLinkedWithCourse> TblExamTypeLinkedWithCourses { get; set; }

    public virtual DbSet<TblExamTypeLinkedWithSubject> TblExamTypeLinkedWithSubjects { get; set; }

    public virtual DbSet<TblExitInterviewQuestionnaire> TblExitInterviewQuestionnaires { get; set; }

    public virtual DbSet<TblExpenditureDoc> TblExpenditureDocs { get; set; }

    public virtual DbSet<TblExpenseCategory> TblExpenseCategories { get; set; }

    public virtual DbSet<TblExpenseDetail> TblExpenseDetails { get; set; }

    public virtual DbSet<TblFeeDescription> TblFeeDescriptions { get; set; }

    public virtual DbSet<TblFeeInstallmentDetail> TblFeeInstallmentDetails { get; set; }

    public virtual DbSet<TblFeeItemDetail> TblFeeItemDetails { get; set; }

    public virtual DbSet<TblFeeLedgerGroup> TblFeeLedgerGroups { get; set; }

    public virtual DbSet<TblFeeLinkedInventoryItem> TblFeeLinkedInventoryItems { get; set; }

    public virtual DbSet<TblFeePaidDetail> TblFeePaidDetails { get; set; }

    public virtual DbSet<TblFeePaymentDetail> TblFeePaymentDetails { get; set; }

    public virtual DbSet<TblFeePaymentMode> TblFeePaymentModes { get; set; }

    public virtual DbSet<TblFeedback> TblFeedbacks { get; set; }

    public virtual DbSet<TblFinancialYear> TblFinancialYears { get; set; }

    public virtual DbSet<TblFormativeAssessmentCce> TblFormativeAssessmentCces { get; set; }

    public virtual DbSet<TblFranchiseDetail> TblFranchiseDetails { get; set; }

    public virtual DbSet<TblGallery> TblGalleries { get; set; }

    public virtual DbSet<TblGlobalOrgSetting> TblGlobalOrgSettings { get; set; }

    public virtual DbSet<TblGpsdatum> TblGpsdata { get; set; }

    public virtual DbSet<TblGradeSystem> TblGradeSystems { get; set; }

    public virtual DbSet<TblGradesystemDetail> TblGradesystemDetails { get; set; }

    public virtual DbSet<TblGrievanceCategory> TblGrievanceCategories { get; set; }

    public virtual DbSet<TblGrievanceRecord> TblGrievanceRecords { get; set; }

    public virtual DbSet<TblGrnDirectDetail> TblGrnDirectDetails { get; set; }

    public virtual DbSet<TblGrnDirectHeader> TblGrnDirectHeaders { get; set; }

    public virtual DbSet<TblGrnPoDetail> TblGrnPoDetails { get; set; }

    public virtual DbSet<TblGrnPoHeader> TblGrnPoHeaders { get; set; }

    public virtual DbSet<TblGroup> TblGroups { get; set; }

    public virtual DbSet<TblGroupMember> TblGroupMembers { get; set; }

    public virtual DbSet<TblHolidayList> TblHolidayLists { get; set; }

    public virtual DbSet<TblHostel> TblHostels { get; set; }

    public virtual DbSet<TblHostelBilling> TblHostelBillings { get; set; }

    public virtual DbSet<TblHostelRoom> TblHostelRooms { get; set; }

    public virtual DbSet<TblHostelRoom1> TblHostelRooms1 { get; set; }

    public virtual DbSet<TblHostelRoomStudent> TblHostelRoomStudents { get; set; }

    public virtual DbSet<TblHostelType> TblHostelTypes { get; set; }

    public virtual DbSet<TblImageGallery> TblImageGalleries { get; set; }

    public virtual DbSet<TblInactiveEmployee> TblInactiveEmployees { get; set; }

    public virtual DbSet<TblInactiveEmployeeLog> TblInactiveEmployeeLogs { get; set; }

    public virtual DbSet<TblInactiveStudent> TblInactiveStudents { get; set; }

    public virtual DbSet<TblInactiveStudentLog> TblInactiveStudentLogs { get; set; }

    public virtual DbSet<TblIncomeHeader> TblIncomeHeaders { get; set; }

    public virtual DbSet<TblIndicator> TblIndicators { get; set; }

    public virtual DbSet<TblIndicatorConfig> TblIndicatorConfigs { get; set; }

    public virtual DbSet<TblIndicatorDescriptor> TblIndicatorDescriptors { get; set; }

    public virtual DbSet<TblIndicatorDetail> TblIndicatorDetails { get; set; }

    public virtual DbSet<TblIndicatorGroup> TblIndicatorGroups { get; set; }

    public virtual DbSet<TblIndicatorPoint> TblIndicatorPoints { get; set; }

    public virtual DbSet<TblIndicatorResult> TblIndicatorResults { get; set; }

    public virtual DbSet<TblIndicatorResultHeader> TblIndicatorResultHeaders { get; set; }

    public virtual DbSet<TblInstallmentTemplateDetail> TblInstallmentTemplateDetails { get; set; }

    public virtual DbSet<TblInstallmentTemplateHeader> TblInstallmentTemplateHeaders { get; set; }

    public virtual DbSet<TblInstitution> TblInstitutions { get; set; }

    public virtual DbSet<TblIssueList> TblIssueLists { get; set; }

    public virtual DbSet<TblItem> TblItems { get; set; }

    public virtual DbSet<TblItemCategory> TblItemCategories { get; set; }

    public virtual DbSet<TblItemVendor> TblItemVendors { get; set; }

    public virtual DbSet<TblLeadFollowUp> TblLeadFollowUps { get; set; }

    public virtual DbSet<TblLeadStatus> TblLeadStatuses { get; set; }

    public virtual DbSet<TblLearnoMeterCce> TblLearnoMeterCces { get; set; }

    public virtual DbSet<TblLeaveOnRolewise> TblLeaveOnRolewises { get; set; }

    public virtual DbSet<TblLeaveType> TblLeaveTypes { get; set; }

    public virtual DbSet<TblLibrary> TblLibraries { get; set; }

    public virtual DbSet<TblLibraryBook> TblLibraryBooks { get; set; }

    public virtual DbSet<TblLibraryBookAuthor> TblLibraryBookAuthors { get; set; }

    public virtual DbSet<TblLibraryBookCategory> TblLibraryBookCategories { get; set; }

    public virtual DbSet<TblLibraryBookEdition> TblLibraryBookEditions { get; set; }

    public virtual DbSet<TblLibraryBookLedger> TblLibraryBookLedgers { get; set; }

    public virtual DbSet<TblLibraryBookPublication> TblLibraryBookPublications { get; set; }

    public virtual DbSet<TblLibraryBookVolume> TblLibraryBookVolumes { get; set; }

    public virtual DbSet<TblLogin> TblLogins { get; set; }

    public virtual DbSet<TblLoginUserType> TblLoginUserTypes { get; set; }

    public virtual DbSet<TblMarksCardDetail> TblMarksCardDetails { get; set; }

    public virtual DbSet<TblMasterAccountGroup> TblMasterAccountGroups { get; set; }

    public virtual DbSet<TblMasterPermissionSet> TblMasterPermissionSets { get; set; }

    public virtual DbSet<TblMasterVoucherList> TblMasterVoucherLists { get; set; }

    public virtual DbSet<TblMedicineDetail> TblMedicineDetails { get; set; }

    public virtual DbSet<TblMenu> TblMenus { get; set; }

    public virtual DbSet<TblMessageAttachment> TblMessageAttachments { get; set; }

    public virtual DbSet<TblMessageCenter> TblMessageCenters { get; set; }

    public virtual DbSet<TblMessageRecipient> TblMessageRecipients { get; set; }

    public virtual DbSet<TblMonthlyBillingDatum> TblMonthlyBillingData { get; set; }

    public virtual DbSet<TblMonthlyBillingDetail> TblMonthlyBillingDetails { get; set; }

    public virtual DbSet<TblMonthlyBillingOtherCourseDetail> TblMonthlyBillingOtherCourseDetails { get; set; }

    public virtual DbSet<TblNationality> TblNationalities { get; set; }

    public virtual DbSet<TblNewsLetter> TblNewsLetters { get; set; }

    public virtual DbSet<TblOrg> TblOrgs { get; set; }

    public virtual DbSet<TblOtherProgram> TblOtherPrograms { get; set; }

    public virtual DbSet<TblOtherProgramsStudent> TblOtherProgramsStudents { get; set; }

    public virtual DbSet<TblPaatashalaBilling> TblPaatashalaBillings { get; set; }

    public virtual DbSet<TblPaatashalaBillingDetail> TblPaatashalaBillingDetails { get; set; }

    public virtual DbSet<TblParentCommunication> TblParentCommunications { get; set; }

    public virtual DbSet<TblParentFeedbackDetail> TblParentFeedbackDetails { get; set; }

    public virtual DbSet<TblParentFeedbackHeader> TblParentFeedbackHeaders { get; set; }

    public virtual DbSet<TblParentMessageBox> TblParentMessageBoxes { get; set; }

    public virtual DbSet<TblParentMessageOption> TblParentMessageOptions { get; set; }

    public virtual DbSet<TblParentMessageOption1> TblParentMessageOptions1 { get; set; }

    public virtual DbSet<TblPayGroup> TblPayGroups { get; set; }

    public virtual DbSet<TblPayGroupDetail> TblPayGroupDetails { get; set; }

    public virtual DbSet<TblPayroll> TblPayrolls { get; set; }

    public virtual DbSet<TblPayrollDetail> TblPayrollDetails { get; set; }

    public virtual DbSet<TblPermissionValueDetail> TblPermissionValueDetails { get; set; }

    public virtual DbSet<TblPettyCashCategory> TblPettyCashCategories { get; set; }

    public virtual DbSet<TblPettyCashDetail> TblPettyCashDetails { get; set; }

    public virtual DbSet<TblPettyCashDoc> TblPettyCashDocs { get; set; }

    public virtual DbSet<TblPettyCashMaster> TblPettyCashMasters { get; set; }

    public virtual DbSet<TblPostDatedPayment> TblPostDatedPayments { get; set; }

    public virtual DbSet<TblPrincipalMonthlyReport> TblPrincipalMonthlyReports { get; set; }

    public virtual DbSet<TblProformaInvoiceDetail> TblProformaInvoiceDetails { get; set; }

    public virtual DbSet<TblProformaInvoiceHeader> TblProformaInvoiceHeaders { get; set; }

    public virtual DbSet<TblProformaServiceInvoiceDetail> TblProformaServiceInvoiceDetails { get; set; }

    public virtual DbSet<TblProformaServiceInvoiceHeader> TblProformaServiceInvoiceHeaders { get; set; }

    public virtual DbSet<TblProformaTaxInvoiceDetail> TblProformaTaxInvoiceDetails { get; set; }

    public virtual DbSet<TblProformaTaxInvoiceHeader> TblProformaTaxInvoiceHeaders { get; set; }

    public virtual DbSet<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; }

    public virtual DbSet<TblPurchaseOrderHeader> TblPurchaseOrderHeaders { get; set; }

    public virtual DbSet<TblQuestionBank> TblQuestionBanks { get; set; }

    public virtual DbSet<TblReportCategory> TblReportCategories { get; set; }

    public virtual DbSet<TblReportSentDetail> TblReportSentDetails { get; set; }

    public virtual DbSet<TblRetailInvoiceDetail> TblRetailInvoiceDetails { get; set; }

    public virtual DbSet<TblRetailInvoiceHeader> TblRetailInvoiceHeaders { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblRolePermission> TblRolePermissions { get; set; }

    public virtual DbSet<TblRoleWidget> TblRoleWidgets { get; set; }

    public virtual DbSet<TblRoute> TblRoutes { get; set; }

    public virtual DbSet<TblRouteStop> TblRouteStops { get; set; }

    public virtual DbSet<TblRouteStop1> TblRouteStops1 { get; set; }

    public virtual DbSet<TblRouteVehicle> TblRouteVehicles { get; set; }

    public virtual DbSet<TblRoyaltyFeeCollection> TblRoyaltyFeeCollections { get; set; }

    public virtual DbSet<TblRubricsConfiguration> TblRubricsConfigurations { get; set; }

    public virtual DbSet<TblRubricsRoleConfiguration> TblRubricsRoleConfigurations { get; set; }

    public virtual DbSet<TblSector> TblSectors { get; set; }

    public virtual DbSet<TblServiceInvoiceDetail> TblServiceInvoiceDetails { get; set; }

    public virtual DbSet<TblServiceInvoiceHeader> TblServiceInvoiceHeaders { get; set; }

    public virtual DbSet<TblSmsLog> TblSmsLogs { get; set; }

    public virtual DbSet<TblSmscredential> TblSmscredentials { get; set; }

    public virtual DbSet<TblSmstemplate> TblSmstemplates { get; set; }

    public virtual DbSet<TblSsgarchiveClientPayment> TblSsgarchiveClientPayments { get; set; }

    public virtual DbSet<TblSsgbillingDetail> TblSsgbillingDetails { get; set; }

    public virtual DbSet<TblSsgclientPaymentDetail> TblSsgclientPaymentDetails { get; set; }

    public virtual DbSet<TblSsgemployee> TblSsgemployees { get; set; }

    public virtual DbSet<TblSsgrole> TblSsgroles { get; set; }

    public virtual DbSet<TblStockGroup> TblStockGroups { get; set; }

    public virtual DbSet<TblStockItem> TblStockItems { get; set; }

    public virtual DbSet<TblStockItemDeliveryDetail> TblStockItemDeliveryDetails { get; set; }

    public virtual DbSet<TblStockItemsDeliveryHeader> TblStockItemsDeliveryHeaders { get; set; }

    public virtual DbSet<TblStream> TblStreams { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    public virtual DbSet<TblStudentActivity> TblStudentActivities { get; set; }

    public virtual DbSet<TblStudentActivityType> TblStudentActivityTypes { get; set; }

    public virtual DbSet<TblStudentAttachment> TblStudentAttachments { get; set; }

    public virtual DbSet<TblStudentCategory> TblStudentCategories { get; set; }

    public virtual DbSet<TblStudentCourse> TblStudentCourses { get; set; }

    public virtual DbSet<TblStudentCustomize> TblStudentCustomizes { get; set; }

    public virtual DbSet<TblStudentCustomizeValue> TblStudentCustomizeValues { get; set; }

    public virtual DbSet<TblStudentDiary> TblStudentDiaries { get; set; }

    public virtual DbSet<TblStudentFeePaidHeader> TblStudentFeePaidHeaders { get; set; }

    public virtual DbSet<TblStudentFeedbackDetail> TblStudentFeedbackDetails { get; set; }

    public virtual DbSet<TblStudentFeedbackMain> TblStudentFeedbackMains { get; set; }

    public virtual DbSet<TblStudentFeedbackMobileAppQuestion> TblStudentFeedbackMobileAppQuestions { get; set; }

    public virtual DbSet<TblStudentFeedbackQuestionnaire> TblStudentFeedbackQuestionnaires { get; set; }

    public virtual DbSet<TblStudentKit> TblStudentKits { get; set; }

    public virtual DbSet<TblStudentKitItem> TblStudentKitItems { get; set; }

    public virtual DbSet<TblStudentMedicine> TblStudentMedicines { get; set; }

    public virtual DbSet<TblStudentPrevQualificationReason> TblStudentPrevQualificationReasons { get; set; }

    public virtual DbSet<TblStudentQualification> TblStudentQualifications { get; set; }

    public virtual DbSet<TblStudentRegistration> TblStudentRegistrations { get; set; }

    public virtual DbSet<TblStudentResultsCce> TblStudentResultsCces { get; set; }

    public virtual DbSet<TblStudentValue> TblStudentValues { get; set; }

    public virtual DbSet<TblSubBlockCce> TblSubBlockCces { get; set; }

    public virtual DbSet<TblSubCaste> TblSubCastes { get; set; }

    public virtual DbSet<TblSubComponentAttribute> TblSubComponentAttributes { get; set; }

    public virtual DbSet<TblSubject> TblSubjects { get; set; }

    public virtual DbSet<TblSubjectSubComponent> TblSubjectSubComponents { get; set; }

    public virtual DbSet<TblSummativeAssessmentCce> TblSummativeAssessmentCces { get; set; }

    public virtual DbSet<TblTaxDetail> TblTaxDetails { get; set; }

    public virtual DbSet<TblTaxInvoiceDetail> TblTaxInvoiceDetails { get; set; }

    public virtual DbSet<TblTaxInvoiceHeader> TblTaxInvoiceHeaders { get; set; }

    public virtual DbSet<TblTaxType> TblTaxTypes { get; set; }

    public virtual DbSet<TblTerm> TblTerms { get; set; }

    public virtual DbSet<TblTermCce> TblTermCces { get; set; }

    public virtual DbSet<TblThemeAol> TblThemeAols { get; set; }

    public virtual DbSet<TblTimeTable> TblTimeTables { get; set; }

    public virtual DbSet<TblTimeTableDetail> TblTimeTableDetails { get; set; }

    public virtual DbSet<TblTimetableWorkingDay> TblTimetableWorkingDays { get; set; }

    public virtual DbSet<TblTopic> TblTopics { get; set; }

    public virtual DbSet<TblTrainingAttendance> TblTrainingAttendances { get; set; }

    public virtual DbSet<TblTrainingFeedbackQuestion> TblTrainingFeedbackQuestions { get; set; }

    public virtual DbSet<TblTrainingHeader> TblTrainingHeaders { get; set; }

    public virtual DbSet<TblTrainingReportReview> TblTrainingReportReviews { get; set; }

    public virtual DbSet<TblTrainingScheduleHeader> TblTrainingScheduleHeaders { get; set; }

    public virtual DbSet<TblTrainingSessionDetail> TblTrainingSessionDetails { get; set; }

    public virtual DbSet<TblTrainingSessionHeader> TblTrainingSessionHeaders { get; set; }

    public virtual DbSet<TblTraningSchedule> TblTraningSchedules { get; set; }

    public virtual DbSet<TblTransportPayment> TblTransportPayments { get; set; }

    public virtual DbSet<TblTransportTripSheet> TblTransportTripSheets { get; set; }

    public virtual DbSet<TblTripParticipant> TblTripParticipants { get; set; }

    public virtual DbSet<TblTripSheet> TblTripSheets { get; set; }

    public virtual DbSet<TblUnitOfMeasure> TblUnitOfMeasures { get; set; }

    public virtual DbSet<TblVehicle> TblVehicles { get; set; }

    public virtual DbSet<TblVehicleAttachment> TblVehicleAttachments { get; set; }

    public virtual DbSet<TblVehicleDevice> TblVehicleDevices { get; set; }

    public virtual DbSet<TblVehicleType> TblVehicleTypes { get; set; }

    public virtual DbSet<TblVendor> TblVendors { get; set; }

    public virtual DbSet<TblVideoGallery> TblVideoGalleries { get; set; }

    public virtual DbSet<TblVisitor> TblVisitors { get; set; }

    public virtual DbSet<TblVisitorMaterial> TblVisitorMaterials { get; set; }

    public virtual DbSet<TblVisualTimeTablePhotoType> TblVisualTimeTablePhotoTypes { get; set; }

    public virtual DbSet<TblVoucherList> TblVoucherLists { get; set; }

    public virtual DbSet<TblWidget> TblWidgets { get; set; }

    public virtual DbSet<View> Views { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Connection string not configured. Error: "+ex.Message);
            }
        }
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-PAK321Q\\MSSQLSERVER01;Initial Catalog=webSchool;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True; Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<CounsellorNote>(entity =>
        {
            entity.HasIndex(e => new { e.CounsellorId, e.StudentId, e.OrgId }, "NonClusteredIndex-20170102-164540");

            entity.Property(e => e.DateOfCounselling).HasColumnType("date");
            entity.Property(e => e.Notes).IsUnicode(false);

            entity.HasOne(d => d.Counsellor).WithMany(p => p.CounsellorNotes)
                .HasForeignKey(d => d.CounsellorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CounsellorNotes_tblCounsellor");

            entity.HasOne(d => d.Org).WithMany(p => p.CounsellorNotes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CounsellorNotes_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.CounsellorNotes)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CounsellorNotes_tblStudent");
        });

        modelBuilder.Entity<TblAbsentAttendance>(entity =>
        {
            entity.ToTable("tblAbsentAttendance");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.AttendanceTypeNavigation).WithMany(p => p.TblAbsentAttendances)
                .HasForeignKey(d => d.AttendanceType)
                .HasConstraintName("FK_tblAbsentAttendance_tblAttendanceConfig");

            entity.HasOne(d => d.BatchNavigation).WithMany(p => p.TblAbsentAttendances)
                .HasForeignKey(d => d.Batch)
                .HasConstraintName("FK_tblAbsentAttendance_tblBatch");

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblAbsentAttendances)
                .HasForeignKey(d => d.Course)
                .HasConstraintName("FK_tblAbsentAttendance_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAbsentAttendances)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAbsentAttendance_tblOrg");
        });

        modelBuilder.Entity<TblAccountGroup>(entity =>
        {
            entity.ToTable("tblAccountGroup");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-164639");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblAccountGroups)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAccountGroup_tblOrg");
        });

        modelBuilder.Entity<TblAccountLedger>(entity =>
        {
            entity.ToTable("tblAccountLedger");

            entity.HasIndex(e => new { e.AccountGroup, e.OrgId }, "NonClusteredIndex-20170102-164719");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountGroupNavigation).WithMany(p => p.TblAccountLedgers)
                .HasForeignKey(d => d.AccountGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAccountLedger_tblAccountGroup");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAccountLedgers)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAccountLedger_tblOrg");
        });

        modelBuilder.Entity<TblActExitInterviewResultDetail>(entity =>
        {
            entity.ToTable("tblActExitInterviewResultDetails");

            entity.Property(e => e.Score).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.Header).WithMany(p => p.TblActExitInterviewResultDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblActExitInterviewResultDetails_tblACTExitInterviewResultHeader");
        });

        modelBuilder.Entity<TblActRemedialPlanSubjectWise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblActRemedialPlanSubjectsWise");

            entity.ToTable("tblActRemedialPlanSubjectWise");

            entity.Property(e => e.AreaOfImprove).IsUnicode(false);
            entity.Property(e => e.ClassesAttended).IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActRemedialPlanSubjectWises)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblActRemedialPlanSubjectsWise_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActRemedialPlanSubjectWises)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblActRemedialPlanSubjectsWise_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActRemedialPlanSubjectWises)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblActRemedialPlanSubjectsWise_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActRemedialPlanSubjectWises)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblActRemedialPlanSubjectsWise_tblStudent");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblActRemedialPlanSubjectWises)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblActRemedialPlanSubjectsWise_tblSubjects");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActRemedialPlanSubjectWises)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblActRemedialPlanSubjectsWise_tblEmployee");
        });

        modelBuilder.Entity<TblActacademicCoordinator>(entity =>
        {
            entity.ToTable("tblACTAcademicCoordinator");

            entity.HasOne(d => d.AcademicHandholding).WithMany(p => p.TblActacademicCoordinators)
                .HasForeignKey(d => d.AcademicHandholdingId)
                .HasConstraintName("FK_tblACTAcademicCoordinator_tblACTAcademicHandholdingChecklist");
        });

        modelBuilder.Entity<TblActacademicHandholdingChecklist>(entity =>
        {
            entity.ToTable("tblACTAcademicHandholdingChecklist");

            entity.Property(e => e.DateOfAssessment).HasColumnType("date");
            entity.Property(e => e.Ssf).HasColumnName("SSF");

            entity.HasOne(d => d.ChairmanNavigation).WithMany(p => p.TblActacademicHandholdingChecklistChairmanNavigations)
                .HasForeignKey(d => d.Chairman)
                .HasConstraintName("FK_tblACTAcademicHandholdingChecklist_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActacademicHandholdingChecklistOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTAcademicHandholdingChecklist_tblOrg1");

            entity.HasOne(d => d.PrincipalNavigation).WithMany(p => p.TblActacademicHandholdingChecklistPrincipalNavigations)
                .HasForeignKey(d => d.Principal)
                .HasConstraintName("FK_tblACTAcademicHandholdingChecklist_tblEmployee1");

            entity.HasOne(d => d.School).WithMany(p => p.TblActacademicHandholdingChecklistSchools)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_tblACTAcademicHandholdingChecklist_tblOrg");

            entity.HasOne(d => d.SsfNavigation).WithMany(p => p.TblActacademicHandholdingChecklistSsfNavigations)
                .HasForeignKey(d => d.Ssf)
                .HasConstraintName("FK_tblACTAcademicHandholdingChecklist_tblEmployee2");
        });

        modelBuilder.Entity<TblActahreport>(entity =>
        {
            entity.ToTable("tblACTAHReport");

            entity.Property(e => e.Action)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ByWhen).HasColumnType("date");
            entity.Property(e => e.ByWhom)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Report).IsUnicode(false);
            entity.Property(e => e.Status).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActahreports)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTAHReport_tblOrg");

            entity.HasOne(d => d.ReportHeader).WithMany(p => p.TblActahreports)
                .HasForeignKey(d => d.ReportHeaderId)
                .HasConstraintName("FK_tblACTAHReport_tblACTVisitHeader");

            entity.HasOne(d => d.VisitAgenda).WithMany(p => p.TblActahreports)
                .HasForeignKey(d => d.VisitAgendaId)
                .HasConstraintName("FK_tblACTAHReport_tblACTVisitDetails");
        });

        modelBuilder.Entity<TblActahreportHeader>(entity =>
        {
            entity.ToTable("tblACTAHReportHeader");

            entity.Property(e => e.ActvisitHeaderId).HasColumnName("ACTVisitHeaderId");
            entity.Property(e => e.Introduction).IsUnicode(false);
            entity.Property(e => e.ManagementPoints).IsUnicode(false);
            entity.Property(e => e.NextVisitSchedule).IsUnicode(false);
            entity.Property(e => e.Observation).IsUnicode(false);
            entity.Property(e => e.Others).IsUnicode(false);
            entity.Property(e => e.PrincipalPoints).IsUnicode(false);

            entity.HasOne(d => d.ActvisitHeader).WithMany(p => p.TblActahreportHeaders)
                .HasForeignKey(d => d.ActvisitHeaderId)
                .HasConstraintName("FK_tblACTAHReportHeader_tblACTVisitHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActahreportHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTAHReportHeader_tblOrg");
        });

        modelBuilder.Entity<TblActappraisalDetail>(entity =>
        {
            entity.ToTable("tblACTAppraisalDetails");

            entity.HasOne(d => d.AppraisalHeader).WithMany(p => p.TblActappraisalDetails)
                .HasForeignKey(d => d.AppraisalHeaderId)
                .HasConstraintName("FK_tblACTAppraisalDetails_tblACTAppraisalHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActappraisalDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTAppraisalDetails_tblOrg");
        });

        modelBuilder.Entity<TblActappraisalHeader>(entity =>
        {
            entity.ToTable("tblACTAppraisalHeader");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.Ssid).HasColumnName("SSID");

            entity.HasOne(d => d.Employee).WithMany(p => p.TblActappraisalHeaders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_tblACTAppraisalHeader_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActappraisalHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTAppraisalHeader_tblOrg");
        });

        modelBuilder.Entity<TblActconfiguration>(entity =>
        {
            entity.ToTable("tblACTConfiguration");

            entity.Property(e => e.ActorgId).HasColumnName("ACTOrgId");
        });

        modelBuilder.Entity<TblActdailyPlanDetail>(entity =>
        {
            entity.ToTable("tblACTDailyPlanDetails");

            entity.Property(e => e.Assessment).IsUnicode(false);
            entity.Property(e => e.Concept).IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Objective).IsUnicode(false);
            entity.Property(e => e.ReInforcement).IsUnicode(false);
            entity.Property(e => e.Resources).IsUnicode(false);
            entity.Property(e => e.Task).IsUnicode(false);

            entity.HasOne(d => d.Header).WithMany(p => p.TblActdailyPlanDetails)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblACTDailyPlanDetails_tblACTDailyPlanHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActdailyPlanDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTDailyPlanDetails_tblOrg");
        });

        modelBuilder.Entity<TblActdailyPlanHeader>(entity =>
        {
            entity.ToTable("tblACTDailyPlanHeader");

            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActdailyPlanHeaders)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTDailyPlanHeader_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActdailyPlanHeaders)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblACTDailyPlanHeader_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActdailyPlanHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTDailyPlanHeader_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblActdailyPlanHeaders)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblACTDailyPlanHeader_tblSubjects");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActdailyPlanHeaders)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTDailyPlanHeader_tblEmployee");
        });

        modelBuilder.Entity<TblActdepartmentGoalDetail>(entity =>
        {
            entity.ToTable("tblACTDepartmentGoalDetails");

            entity.Property(e => e.DateofInitiation).HasColumnType("date");
            entity.Property(e => e.Goal)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ResponsiblePerson)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusUpdate)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Stpes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Header).WithMany(p => p.TblActdepartmentGoalDetails)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblACTDepartmentGoalDetails_tblACTDepartmentGoalHeader");
        });

        modelBuilder.Entity<TblActdepartmentGoalHeader>(entity =>
        {
            entity.ToTable("tblACTDepartmentGoalHeader");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActdepartmentGoalHeaders)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTDepartmentGoalHeader_tblBatch");

            entity.HasOne(d => d.Department).WithMany(p => p.TblActdepartmentGoalHeaders)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_tblACTDepartmentGoalHeader_tblDepartments");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblActdepartmentGoalHeaders)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblACTDepartmentGoalHeader_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActdepartmentGoalHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTDepartmentGoalHeader_tblOrg");
        });

        modelBuilder.Entity<TblActexitInterviewResultHeader>(entity =>
        {
            entity.ToTable("tblACTExitInterviewResultHeader");

            entity.Property(e => e.Comments).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblActexitInterviewResultHeaders)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTExitInterviewResultHeader_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActexitInterviewResultHeaders)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTExitInterviewResultHeader_tblOrg");
        });

        modelBuilder.Entity<TblActivityAol>(entity =>
        {
            entity.ToTable("tblActivityAOL");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActivityAols)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblActivityAOL_tblOrg");

            entity.HasOne(d => d.ThemeNavigation).WithMany(p => p.TblActivityAols)
                .HasForeignKey(d => d.Theme)
                .HasConstraintName("FK_tblActivityAOL_tblThemeAOL");
        });

        modelBuilder.Entity<TblActmentorReflection>(entity =>
        {
            entity.ToTable("tblACTMentorReflection");

            entity.Property(e => e.Reflection).IsUnicode(false);

            entity.HasOne(d => d.MentorSchedule).WithMany(p => p.TblActmentorReflections)
                .HasForeignKey(d => d.MentorScheduleId)
                .HasConstraintName("FK_tblACTMentorReflection_tblACTMentoringSchedule");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActmentorReflections)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTMentorReflection_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActmentorReflections)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTMentorReflection_tblStudent");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActmentorReflections)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTMentorReflection_tblEmployee");
        });

        modelBuilder.Entity<TblActmentoringHomeVisit>(entity =>
        {
            entity.ToTable("tblACTMentoringHomeVisit");

            entity.Property(e => e.DateOfVisit).HasColumnType("date");
            entity.Property(e => e.DurationOfVisit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MenteesAcademicProgress).IsUnicode(false);
            entity.Property(e => e.MenteesAttendance).IsUnicode(false);
            entity.Property(e => e.MenteesBehaviour).IsUnicode(false);
            entity.Property(e => e.MenteesFamilyBackground).IsUnicode(false);
            entity.Property(e => e.MenteesHealth).IsUnicode(false);
            entity.Property(e => e.MenteesPersonality).IsUnicode(false);
            entity.Property(e => e.PositiveQuality).IsUnicode(false);
            entity.Property(e => e.RecreationProgramme).IsUnicode(false);
            entity.Property(e => e.TeacherReflection).IsUnicode(false);
            entity.Property(e => e.UnderstandParentalExpectations).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActmentoringHomeVisits)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTMentoringHomeVisit_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActmentoringHomeVisits)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTMentoringHomeVisit_tblStudent");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActmentoringHomeVisits)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTMentoringHomeVisit_tblEmployee");
        });

        modelBuilder.Entity<TblActmentoringPlan>(entity =>
        {
            entity.ToTable("tblACTMentoringPlan");

            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActmentoringPlans)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTMentoringPlan_tblBatch");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActmentoringPlans)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTMentoringPlan_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActmentoringPlans)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTMentoringPlan_tblStudent");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActmentoringPlans)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTMentoringPlan_tblEmployee");
        });

        modelBuilder.Entity<TblActmentoringSchedule>(entity =>
        {
            entity.ToTable("tblACTMentoringSchedule");

            entity.Property(e => e.ActivitiesPlanned).IsUnicode(false);
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Objective).IsUnicode(false);

            entity.HasOne(d => d.MentoringPlan).WithMany(p => p.TblActmentoringSchedules)
                .HasForeignKey(d => d.MentoringPlanId)
                .HasConstraintName("FK_tblACTMentoringSchedule_tblACTMentoringPlan");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActmentoringSchedules)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTMentoringSchedule_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActmentoringSchedules)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTMentoringSchedule_tblStudent");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActmentoringSchedules)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTMentoringSchedule_tblEmployee");
        });

        modelBuilder.Entity<TblActmentoringUnPlanned>(entity =>
        {
            entity.ToTable("tblACTMentoringUnPlanned");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Interaction).IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActmentoringUnPlanneds)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTMentoringUnPlanned_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActmentoringUnPlanneds)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTMentoringUnPlanned_tblStudent");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActmentoringUnPlanneds)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTMentoringUnPlanned_tblEmployee");
        });

        modelBuilder.Entity<TblActprincipalReportMainHeading>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportMainHeading");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportMainHeadings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportMainHeading_tblOrg");
        });

        modelBuilder.Entity<TblActprincipalReportMainHeadingDetail>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportMainHeadingDetails");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.MainHeading).WithMany(p => p.TblActprincipalReportMainHeadingDetails)
                .HasForeignKey(d => d.MainHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportMainHeadingDetails_tblACTPrincipalReportMainHeading");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportMainHeadingDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportMainHeadingDetails_tblOrg");
        });

        modelBuilder.Entity<TblActprincipalReportMainHeadingDetailsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblACTPrincipalReportMainHeadingData");

            entity.ToTable("tblACTPrincipalReportMainHeadingDetailsData");

            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.MainHeadingDetail).WithMany(p => p.TblActprincipalReportMainHeadingDetailsData)
                .HasForeignKey(d => d.MainHeadingDetailId)
                .HasConstraintName("FK_tblACTPrincipalReportMainHeadingData_tblACTPrincipalReportMainHeadingDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportMainHeadingDetailsData)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportMainHeadingData_tblOrg");

            entity.HasOne(d => d.Report).WithMany(p => p.TblActprincipalReportMainHeadingDetailsData)
                .HasForeignKey(d => d.ReportId)
                .HasConstraintName("FK_tblACTPrincipalReportMainHeadingData_tblPrincipalMonthlyReport");
        });

        modelBuilder.Entity<TblActprincipalReportSubCategoryHeading>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportSubCategoryHeading");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.MainHeading).WithMany(p => p.TblActprincipalReportSubCategoryHeadings)
                .HasForeignKey(d => d.MainHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportSubCategoryHeading_tblACTPrincipalReportMainHeading");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportSubCategoryHeadings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportSubCategoryHeading_tblOrg");

            entity.HasOne(d => d.SubHeading).WithMany(p => p.TblActprincipalReportSubCategoryHeadings)
                .HasForeignKey(d => d.SubHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportSubCategoryHeading_tblACTPrincipalReportSubHeading");
        });

        modelBuilder.Entity<TblActprincipalReportSubCategoryHeadingDatum>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportSubCategoryHeadingData");

            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportSubCategoryHeadingData)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportSubCategoryHeadingData_tblOrg");

            entity.HasOne(d => d.Report).WithMany(p => p.TblActprincipalReportSubCategoryHeadingData)
                .HasForeignKey(d => d.ReportId)
                .HasConstraintName("FK_tblACTPrincipalReportSubCategoryHeadingData_tblPrincipalMonthlyReport");

            entity.HasOne(d => d.SubCategoryHeading).WithMany(p => p.TblActprincipalReportSubCategoryHeadingData)
                .HasForeignKey(d => d.SubCategoryHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportSubCategoryHeadingData_tblACTPrincipalReportSubCategoryHeading");
        });

        modelBuilder.Entity<TblActprincipalReportSubHeading>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportSubHeading");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.MainHeading).WithMany(p => p.TblActprincipalReportSubHeadings)
                .HasForeignKey(d => d.MainHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeading_tblACTPrincipalReportMainHeading");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportSubHeadings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeading_tblOrg");
        });

        modelBuilder.Entity<TblActprincipalReportSubHeadingDetail>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportSubHeadingDetails");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.MainHeading).WithMany(p => p.TblActprincipalReportSubHeadingDetails)
                .HasForeignKey(d => d.MainHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeadingDetails_tblACTPrincipalReportMainHeading");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportSubHeadingDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeadingDetails_tblOrg");

            entity.HasOne(d => d.SubHeading).WithMany(p => p.TblActprincipalReportSubHeadingDetails)
                .HasForeignKey(d => d.SubHeadingId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeadingDetails_tblACTPrincipalReportSubHeading");
        });

        modelBuilder.Entity<TblActprincipalReportSubHeadingDetailsDatum>(entity =>
        {
            entity.ToTable("tblACTPrincipalReportSubHeadingDetailsData");

            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActprincipalReportSubHeadingDetailsData)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeadingDetailsData_tblOrg");

            entity.HasOne(d => d.Report).WithMany(p => p.TblActprincipalReportSubHeadingDetailsData)
                .HasForeignKey(d => d.ReportId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeadingDetailsData_tblPrincipalMonthlyReport");

            entity.HasOne(d => d.SubHeadingDetails).WithMany(p => p.TblActprincipalReportSubHeadingDetailsData)
                .HasForeignKey(d => d.SubHeadingDetailsId)
                .HasConstraintName("FK_tblACTPrincipalReportSubHeadingDetailsData_tblACTPrincipalReportSubHeadingDetails");
        });

        modelBuilder.Entity<TblActptmrecord>(entity =>
        {
            entity.ToTable("tblACTPTMRecord");

            entity.Property(e => e.Academics).IsUnicode(false);
            entity.Property(e => e.Action).IsUnicode(false);
            entity.Property(e => e.Behaviour).IsUnicode(false);
            entity.Property(e => e.ParentPoint).IsUnicode(false);
            entity.Property(e => e.Ptmdate)
                .HasColumnType("datetime")
                .HasColumnName("PTMDate");
            entity.Property(e => e.Punctuality).IsUnicode(false);
            entity.Property(e => e.ReferTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section).HasMaxLength(50);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActptmrecords)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTPTMRecord_tblBatch");

            entity.HasOne(d => d.ClassTeacher).WithMany(p => p.TblActptmrecordClassTeachers)
                .HasForeignKey(d => d.ClassTeacherId)
                .HasConstraintName("FK_tblACTPTMRecord_tblEmployee");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActptmrecords)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblACTPTMRecord_tblCourse");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblActptmrecordCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblACTPTMRecord_tblEmployee1");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActptmrecords)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTPTMRecord_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActptmrecords)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTPTMRecord_tblStudent");
        });

        modelBuilder.Entity<TblActremedialPlanSessionwise>(entity =>
        {
            entity.ToTable("tblACTRemedialPlanSessionwise");

            entity.Property(e => e.AreaOfFocus).IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.RemedialTask).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActremedialPlanSessionwises)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTRemedialPlanSessionwise_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActremedialPlanSessionwises)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTRemedialPlanSessionwise_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActremedialPlanSessionwises)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTRemedialPlanSessionwise_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActremedialPlanSessionwises)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTRemedialPlanSessionwise_tblStudent");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblActremedialPlanSessionwises)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblACTRemedialPlanSessionwise_tblSubjects");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActremedialPlanSessionwises)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTRemedialPlanSessionwise_tblEmployee");
        });

        modelBuilder.Entity<TblActremedialStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblACTRemidialStudents");

            entity.ToTable("tblACTRemedialStudents");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActremedialStudents)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTRemedialStudents_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActremedialStudents)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblACTRemedialStudents_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActremedialStudents)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTRemidialStudents_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblActremedialStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblACTRemidialStudents_tblStudent");
        });

        modelBuilder.Entity<TblActremedialStudentsSubject>(entity =>
        {
            entity.ToTable("tblACTRemedialStudentsSubjects");

            entity.Property(e => e.ActremedialId).HasColumnName("ACTRemedialId");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActremedialStudentsSubjects)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTRemedialStudentsSubjects_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblActremedialStudentsSubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblACTRemedialStudentsSubjects_tblSubjects");
        });

        modelBuilder.Entity<TblActschool>(entity =>
        {
            entity.ToTable("tblACTSchool");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActschools)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTSchool_tblOrg");
        });

        modelBuilder.Entity<TblActssfconfigDetail>(entity =>
        {
            entity.ToTable("tblACTSSFConfigDetails");

            entity.Property(e => e.ActssfconfigHeaderId).HasColumnName("ACTSSFConfigHeaderId");

            entity.HasOne(d => d.ActssfconfigHeader).WithMany(p => p.TblActssfconfigDetails)
                .HasForeignKey(d => d.ActssfconfigHeaderId)
                .HasConstraintName("FK_tblACTSSFConfigDetails_tblACTSSFConfigHeader");

            entity.HasOne(d => d.AssignedOrg).WithMany(p => p.TblActssfconfigDetails)
                .HasForeignKey(d => d.AssignedOrgId)
                .HasConstraintName("FK_tblACTSSFConfigDetails_tblOrg");
        });

        modelBuilder.Entity<TblActssfconfigHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblACTSSFConfig");

            entity.ToTable("tblACTSSFConfigHeader");

            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.ToDate).HasColumnType("date");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblActssfconfigHeaders)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblACTSSFConfig_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActssfconfigHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTSSFConfig_tblOrg1");
        });

        modelBuilder.Entity<TblActssfinteraction>(entity =>
        {
            entity.ToTable("tblACTSSFInteraction");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.FileName).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblActssfinteractions)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblACTSSFInteraction_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActssfinteractionOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTSSFInteraction_tblOrg");

            entity.HasOne(d => d.RelatedToOrg).WithMany(p => p.TblActssfinteractionRelatedToOrgs)
                .HasForeignKey(d => d.RelatedToOrgId)
                .HasConstraintName("FK_tblACTSSFInteraction_tblOrg1");
        });

        modelBuilder.Entity<TblActsubstituionRecord>(entity =>
        {
            entity.ToTable("tblACTSubstituionRecord");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Task).IsUnicode(false);

            entity.HasOne(d => d.AbsentTeacher).WithMany(p => p.TblActsubstituionRecordAbsentTeachers)
                .HasForeignKey(d => d.AbsentTeacherId)
                .HasConstraintName("FK_tblACTSubstituionRecord_tblEmployee");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActsubstituionRecords)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblACTSubstituionRecord_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActsubstituionRecords)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTSubstituionRecord_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblActsubstituionRecords)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblACTSubstituionRecord_tblSubjects");

            entity.HasOne(d => d.SubstituteTeacher).WithMany(p => p.TblActsubstituionRecordSubstituteTeachers)
                .HasForeignKey(d => d.SubstituteTeacherId)
                .HasConstraintName("FK_tblACTSubstituionRecord_tblEmployee1");
        });

        modelBuilder.Entity<TblActtrainingFeedbackDetail>(entity =>
        {
            entity.ToTable("tblACTTrainingFeedbackDetails");

            entity.HasOne(d => d.Header).WithMany(p => p.TblActtrainingFeedbackDetails)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblACTTrainingFeedbackDetails_tblACTTrainingFeedbackHeader");

            entity.HasOne(d => d.Question).WithMany(p => p.TblActtrainingFeedbackDetails)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_tblACTTrainingFeedbackDetails_tblTrainingFeedbackQuestion");
        });

        modelBuilder.Entity<TblActtrainingFeedbackHeader>(entity =>
        {
            entity.ToTable("tblACTTrainingFeedbackHeader");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.FindUsefulAndInteresting).IsUnicode(false);
            entity.Property(e => e.IrrelavantOrNotMuchUseful).IsUnicode(false);
            entity.Property(e => e.KeyLearningFromProgramme).IsUnicode(false);
            entity.Property(e => e.SuggestionsForImprovements).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblActtrainingFeedbackHeaders)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblACTTrainingFeedbackHeader_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActtrainingFeedbackHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTTrainingFeedbackHeader_tblOrg");

            entity.HasOne(d => d.Training).WithMany(p => p.TblActtrainingFeedbackHeaders)
                .HasForeignKey(d => d.TrainingId)
                .HasConstraintName("FK_tblACTTrainingFeedbackHeader_tblTrainingHeader");
        });

        modelBuilder.Entity<TblActvisitDetail>(entity =>
        {
            entity.ToTable("tblACTVisitDetails");

            entity.Property(e => e.AgendaDetails).IsUnicode(false);

            entity.HasOne(d => d.ActVisitHeader).WithMany(p => p.TblActvisitDetails)
                .HasForeignKey(d => d.ActVisitHeaderId)
                .HasConstraintName("FK_tblACTVisitDetails_tblACTVisitHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActvisitDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTVisitDetails_tblOrg");
        });

        modelBuilder.Entity<TblActvisitHeader>(entity =>
        {
            entity.ToTable("tblACTVisitHeader");

            entity.Property(e => e.DateOfVisit).HasColumnType("date");
            entity.Property(e => e.ExpectedDocument).IsUnicode(false);
            entity.Property(e => e.FacultyMembers).IsUnicode(false);
            entity.Property(e => e.FocusAreas).IsUnicode(false);
            entity.Property(e => e.NameOfOrgVisiting)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblActvisitHeaderOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTVisitHeader_tblOrg");

            entity.HasOne(d => d.User).WithMany(p => p.TblActvisitHeaders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblACTVisitHeader_tblEmployee");

            entity.HasOne(d => d.VisitingOrg).WithMany(p => p.TblActvisitHeaderVisitingOrgs)
                .HasForeignKey(d => d.VisitingOrgId)
                .HasConstraintName("FK_tblACTVisitHeader_tblOrg1");
        });

        modelBuilder.Entity<TblActwallOfFrameDoc>(entity =>
        {
            entity.ToTable("tblACTWallOfFrameDoc");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Doc).WithMany(p => p.TblActwallOfFrameDocs)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_tblACTWallOfFrameDoc_tblDocument");

            entity.HasOne(d => d.DocVersion).WithMany(p => p.TblActwallOfFrameDocs)
                .HasForeignKey(d => d.DocVersionId)
                .HasConstraintName("FK_tblACTWallOfFrameDoc_tblDocumentVersion");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActwallOfFrameDocs)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblACTWallOfFrameDoc_tblOrg");
        });

        modelBuilder.Entity<TblActyearPlanDetail>(entity =>
        {
            entity.ToTable("tblACTYearPlanDetails");

            entity.Property(e => e.NatureOfAssessment).IsUnicode(false);
            entity.Property(e => e.PlaceForFieldTrip)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReasonForDeviation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StatusOfCompletion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TopicToBeTaught).IsUnicode(false);

            entity.HasOne(d => d.Header).WithMany(p => p.TblActyearPlanDetails)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblACTYearPlanDetails_tblACTYearPlanHeader");
        });

        modelBuilder.Entity<TblActyearPlanHeader>(entity =>
        {
            entity.ToTable("tblACTYearPlanHeader");

            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActyearPlanHeaders)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTYearPlanHeader_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblActyearPlanHeaders)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblACTYearPlanHeader_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActyearPlanHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTYearPlanHeader_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblActyearPlanHeaders)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblACTYearPlanHeader_tblSubjects");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblActyearPlanHeaders)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblACTYearPlanHeader_tblEmployee");
        });

        modelBuilder.Entity<TblActyearlyGoalHeader>(entity =>
        {
            entity.ToTable("tblACTYearlyGoalHeader");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblActyearlyGoalHeaders)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblACTYearlyGoalHeader_tblBatch");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActyearlyGoalHeaderOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTYearlyGoalHeader_tblOrg");

            entity.HasOne(d => d.UserOrg).WithMany(p => p.TblActyearlyGoalHeaderUserOrgs)
                .HasForeignKey(d => d.UserOrgId)
                .HasConstraintName("FK_tblACTYearlyGoalHeader_tblOrg1");
        });

        modelBuilder.Entity<TblActyearlyGoalPerson>(entity =>
        {
            entity.ToTable("tblACTYearlyGoalPerson");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblActyearlyGoalPeople)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblACTYearlyGoalPerson_tblEmployee");

            entity.HasOne(d => d.Goal).WithMany(p => p.TblActyearlyGoalPeople)
                .HasForeignKey(d => d.GoalId)
                .HasConstraintName("FK_tblACTYearlyGoalPerson_tblACTYearlyGoalTarget");

            entity.HasOne(d => d.Org).WithMany(p => p.TblActyearlyGoalPeople)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblACTYearlyGoalPerson_tblOrg");
        });

        modelBuilder.Entity<TblActyearlyGoalTarget>(entity =>
        {
            entity.ToTable("tblACTYearlyGoalTarget");

            entity.Property(e => e.Goal).IsUnicode(false);
            entity.Property(e => e.PlanOfAction).IsUnicode(false);

            entity.HasOne(d => d.Header).WithMany(p => p.TblActyearlyGoalTargets)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblACTYearlyGoalTarget_tblACTYearlyGoalHeader");
        });

        modelBuilder.Entity<TblAdmissionStatusType>(entity =>
        {
            entity.ToTable("tblAdmissionStatusType");

            entity.Property(e => e.IsLead).HasColumnName("isLead");
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<TblAdvanceFeeDebit>(entity =>
        {
            entity.ToTable("tblAdvanceFeeDebit");

            entity.Property(e => e.Amount).HasColumnType("money");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblCourse");

            entity.HasOne(d => d.FeePaidHeader).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.FeePaidHeaderId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblStudentFeePaidHeader");

            entity.HasOne(d => d.FeePaymentDetail).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.FeePaymentDetailId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblFeePaymentDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblOrg");

            entity.HasOne(d => d.OtherCourse).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.OtherCourseId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblOtherPrograms");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAdvanceFeeDebits)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblAdvanceFeeDebit_tblStudent");
        });

        modelBuilder.Entity<TblAdvancedFeePayment>(entity =>
        {
            entity.ToTable("tblAdvancedFeePayment");

            entity.Property(e => e.AdvReceiptNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Narration).IsUnicode(false);
            entity.Property(e => e.PaidDate).HasColumnType("date");
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BankNavigation).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.Bank)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblBankDetails");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblOrg");

            entity.HasOne(d => d.OtherCourse).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.OtherCourseId)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblOtherPrograms");

            entity.HasOne(d => d.PaymentModeNavigation).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.PaymentMode)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblFeePaymentMode");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAdvancedFeePayments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAdvancedFeePayment_tblStudent");
        });

        modelBuilder.Entity<TblAffiliation>(entity =>
        {
            entity.ToTable("tblAffiliation");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TblAolcomment>(entity =>
        {
            entity.ToTable("tblAOLComments");

            entity.Property(e => e.Comments).IsUnicode(false);

            entity.HasOne(d => d.AreaOfLearning).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.AreaOfLearningId)
                .HasConstraintName("FK_tblAOLComments_tblAreaOfLearning");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblAOLComments_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblAOLComments_tblCourse");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblAOLComments_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAOLComments_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblAOLComments_tblStudent");

            entity.HasOne(d => d.Term).WithMany(p => p.TblAolcomments)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK_tblAOLComments_tblTerm");
        });

        modelBuilder.Entity<TblAolstudentEntry>(entity =>
        {
            entity.ToTable("tblAOLStudentEntry");

            entity.Property(e => e.Score)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblAolstudentEntries)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblAOLStudentEntry_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblAolstudentEntries)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblAOLStudentEntry_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAolstudentEntries)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAOLStudentEntry_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAolstudentEntries)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAOLStudentEntry_tblStudent");

            entity.HasOne(d => d.TermNavigation).WithMany(p => p.TblAolstudentEntries)
                .HasForeignKey(d => d.Term)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAOLStudentEntry_tblTerm");
        });

        modelBuilder.Entity<TblAppLogin>(entity =>
        {
            entity.ToTable("tblAppLogin");

            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("date");
            entity.Property(e => e.Passcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SenderId).IsUnicode(false);
            entity.Property(e => e.ValidTill).HasColumnType("date");
        });

        modelBuilder.Entity<TblAppMenuDefinition>(entity =>
        {
            entity.ToTable("tblAppMenuDefinition");

            entity.HasOne(d => d.MenuName).WithMany(p => p.TblAppMenuDefinitions)
                .HasForeignKey(d => d.MenuNameId)
                .HasConstraintName("FK_tblAppMenuDefinition_tblAppMenuNames");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAppMenuDefinitions)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAppMenuDefinition_tblOrg");
        });

        modelBuilder.Entity<TblAppMenuName>(entity =>
        {
            entity.ToTable("tblAppMenuNames");

            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAppMenuOrg>(entity =>
        {
            entity.ToTable("tblAppMenuOrg");

            entity.HasOne(d => d.Menu).WithMany(p => p.TblAppMenuOrgs)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAppMenuOrg_tblAppMenuNames");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAppMenuOrgs)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAppMenuOrg_tblOrg");
        });

        modelBuilder.Entity<TblAppParentMessageContent>(entity =>
        {
            entity.ToTable("tblAppParentMessageContent");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblAppParentMessageContents)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAppParentMessageContent_tblOrg");
        });

        modelBuilder.Entity<TblAppVersion>(entity =>
        {
            entity.HasKey(e => e.VersionId);

            entity.ToTable("tblAppVersion");

            entity.Property(e => e.BuidDate).HasColumnType("date");
            entity.Property(e => e.UpdateMessage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblApplicationLog>(entity =>
        {
            entity.ToTable("tblApplicationLog");

            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ControllerName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RouteData).IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UserType)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAreaOfLearning>(entity =>
        {
            entity.ToTable("tblAreaOfLearning");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblAreaOfLearnings)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblAreaOfLearning_tblBatch");

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblAreaOfLearnings)
                .HasForeignKey(d => d.Course)
                .HasConstraintName("FK_tblAreaOfLearning_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAreaOfLearnings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAreaOfLearning_tblOrg");
        });

        modelBuilder.Entity<TblAsset>(entity =>
        {
            entity.ToTable("tblAssets");

            entity.HasIndex(e => new { e.AssetCategory, e.ParentAssetId, e.OrgId }, "NonClusteredIndex-20170102-165009");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.AssetCategoryNavigation).WithMany(p => p.TblAssets)
                .HasForeignKey(d => d.AssetCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssets_tblAssetCategory");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssets)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssets_tblOrg");

            entity.HasOne(d => d.ParentAsset).WithMany(p => p.InverseParentAsset)
                .HasForeignKey(d => d.ParentAssetId)
                .HasConstraintName("FK_tblAssets_tblAssets");
        });

        modelBuilder.Entity<TblAssetAttribute>(entity =>
        {
            entity.ToTable("tblAssetAttribute");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-164912");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Decimal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.String).IsUnicode(false);

            entity.HasOne(d => d.AssetCategoryAttribute).WithMany(p => p.TblAssetAttributes)
                .HasForeignKey(d => d.AssetCategoryAttributeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetAttribute_tblAssetCategoryAttribute");

            entity.HasOne(d => d.Asset).WithMany(p => p.TblAssetAttributes)
                .HasForeignKey(d => d.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetAttribute_tblAssets");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetAttributes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetAttribute_tblOrg");
        });

        modelBuilder.Entity<TblAssetCategory>(entity =>
        {
            entity.ToTable("tblAssetCategory");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-164933");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetCategories)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetCategory_tblOrg");
        });

        modelBuilder.Entity<TblAssetCategoryAttribute>(entity =>
        {
            entity.ToTable("tblAssetCategoryAttribute");

            entity.HasIndex(e => new { e.AttributeType, e.OrgId }, "NonClusteredIndex-20170102-164948");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AttributeTypeNavigation).WithMany(p => p.TblAssetCategoryAttributes)
                .HasForeignKey(d => d.AttributeType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetCategoryAttribute_tblAttributeTypes");

            entity.HasOne(d => d.Category).WithMany(p => p.TblAssetCategoryAttributes)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetCategoryAttribute_tblAssetCategory");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetCategoryAttributes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssetCategoryAttribute_tblOrg");
        });

        modelBuilder.Entity<TblAssetLocation>(entity =>
        {
            entity.ToTable("tblAssetLocation");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetLocations)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAssetLocation_tblOrg");
        });

        modelBuilder.Entity<TblAssetRequest>(entity =>
        {
            entity.ToTable("tblAssetRequest");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.RequestReason).IsUnicode(false);

            entity.HasOne(d => d.Asset).WithMany(p => p.TblAssetRequests)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK_tblAssetRequest_tblAssets");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetRequests)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAssetRequest_tblOrg");

            entity.HasOne(d => d.RequestLocationNavigation).WithMany(p => p.TblAssetRequests)
                .HasForeignKey(d => d.RequestLocation)
                .HasConstraintName("FK_tblAssetRequest_tblAssetLocation");
        });

        modelBuilder.Entity<TblAssetTracking>(entity =>
        {
            entity.ToTable("tblAssetTracking");

            entity.HasOne(d => d.Asset).WithMany(p => p.TblAssetTrackings)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK_tblAssetTracking_tblAssets");

            entity.HasOne(d => d.Location).WithMany(p => p.TblAssetTrackings)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_tblAssetTracking_tblAssetLocation");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetTrackings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAssetTracking_tblOrg");
        });

        modelBuilder.Entity<TblAssetTrackingLog>(entity =>
        {
            entity.ToTable("tblAssetTrackingLog");

            entity.Property(e => e.DateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Asset).WithMany(p => p.TblAssetTrackingLogs)
                .HasForeignKey(d => d.AssetId)
                .HasConstraintName("FK_tblAssetTrackingLog_tblAssets");

            entity.HasOne(d => d.Location).WithMany(p => p.TblAssetTrackingLogs)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_tblAssetTrackingLog_tblAssetLocation");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssetTrackingLogs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAssetTrackingLog_tblOrg");
        });

        modelBuilder.Entity<TblAssignment>(entity =>
        {
            entity.ToTable("tblAssignment");

            entity.HasIndex(e => new { e.CourseId, e.BatchId, e.SubjectId, e.OrgId }, "NonClusteredIndex-20170102-165030");

            entity.Property(e => e.AssignmentName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DateOfAssignment).HasColumnType("date");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblAssignments)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssignment_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblAssignments)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssignment_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssignments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssignment_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblAssignments)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssignment_tblSubjects");
        });

        modelBuilder.Entity<TblAssignmentQuestion>(entity =>
        {
            entity.ToTable("tblAssignmentQuestions");

            entity.HasIndex(e => new { e.AssignmentId, e.OrgId }, "NonClusteredIndex-20170102-165056");

            entity.Property(e => e.Question).IsUnicode(false);

            entity.HasOne(d => d.Assignment).WithMany(p => p.TblAssignmentQuestions)
                .HasForeignKey(d => d.AssignmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssignmentQuestions_tblAssignment");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAssignmentQuestions)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAssignmentQuestions_tblOrg");
        });

        modelBuilder.Entity<TblAttendance>(entity =>
        {
            entity.ToTable("tblAttendance");

            entity.HasIndex(e => new { e.StudentId, e.OrgId }, "NonClusteredIndex-20170102-165121");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAttendances)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAttendance_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAttendances)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblAttendance_tblStudent");
        });

        modelBuilder.Entity<TblAttendanceConfig>(entity =>
        {
            entity.ToTable("tblAttendanceConfig");

            entity.Property(e => e.AttendanceName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblAttendanceConfigs)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAttendanceConfig_tblOrg");
        });

        modelBuilder.Entity<TblAttendanceHourly>(entity =>
        {
            entity.ToTable("tblAttendanceHourly");

            entity.HasIndex(e => new { e.StudentId, e.OrgId }, "NonClusteredIndex-20170102-165147");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.AttendanceTypeNavigation).WithMany(p => p.TblAttendanceHourlies)
                .HasForeignKey(d => d.AttendanceType)
                .HasConstraintName("FK_tblAttendanceHourly_tblAttendanceConfig");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAttendanceHourlies)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAttendanceHourly_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAttendanceHourlies)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAttendanceHourly_tblStudent");
        });

        modelBuilder.Entity<TblAttendanceHourlyOtherProgram>(entity =>
        {
            entity.ToTable("tblAttendanceHourlyOtherPrograms");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblAttendanceHourlyOtherPrograms)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblAttendanceHourlyOtherPrograms_tblOrg");

            entity.HasOne(d => d.OtherProgram).WithMany(p => p.TblAttendanceHourlyOtherPrograms)
                .HasForeignKey(d => d.OtherProgramId)
                .HasConstraintName("FK_tblAttendanceHourlyOtherPrograms_tblOtherPrograms");

            entity.HasOne(d => d.Student).WithMany(p => p.TblAttendanceHourlyOtherPrograms)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblAttendanceHourlyOtherPrograms_tblStudent");
        });

        modelBuilder.Entity<TblAttributeType>(entity =>
        {
            entity.ToTable("tblAttributeTypes");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBankDetail>(entity =>
        {
            entity.ToTable("tblBankDetails");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165210");

            entity.Property(e => e.IsBilling).HasColumnName("isBilling");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblBankDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBankDetails_tblOrg");
        });

        modelBuilder.Entity<TblBarCodeSymbology>(entity =>
        {
            entity.ToTable("tblBarCodeSymbology");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBatch>(entity =>
        {
            entity.ToTable("tblBatch");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165228");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Org).WithMany(p => p.TblBatches)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatch_tblOrg");
        });

        modelBuilder.Entity<TblBatchAdmission>(entity =>
        {
            entity.ToTable("tblBatchAdmission");

            entity.HasIndex(e => new { e.StudentId, e.BatchId, e.PrevBatchId, e.CourseId, e.OrgId }, "NonClusteredIndex-20170102-165244");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RollNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblBatchAdmissionBatches)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblBatchAdmission_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblBatchAdmissions)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmission_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblBatchAdmissions)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmission_tblOrg");

            entity.HasOne(d => d.PrevBatch).WithMany(p => p.TblBatchAdmissionPrevBatches)
                .HasForeignKey(d => d.PrevBatchId)
                .HasConstraintName("FK_tblBatchAdmission_tblBatch1");

            entity.HasOne(d => d.Stream).WithMany(p => p.TblBatchAdmissions)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("FK_tblBatchAdmission_tblStream");

            entity.HasOne(d => d.Student).WithMany(p => p.TblBatchAdmissions)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmission_tblStudent");
        });

        modelBuilder.Entity<TblBatchAdmissionArchive>(entity =>
        {
            entity.ToTable("tblBatchAdmissionArchive");

            entity.HasIndex(e => new { e.StudentId, e.BatchId, e.PrevBatchId, e.CourseId, e.OrgId }, "NonClusteredIndex-20170102-165314");

            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.RollNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TcissueDate)
                .HasColumnType("datetime")
                .HasColumnName("TCIssueDate");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblBatchAdmissionArchiveBatches)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblBatchAdmissionArchives)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblBatchAdmissionArchives)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblOrg");

            entity.HasOne(d => d.PrevBatch).WithMany(p => p.TblBatchAdmissionArchivePrevBatches)
                .HasForeignKey(d => d.PrevBatchId)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblBatch1");

            entity.HasOne(d => d.Stream).WithMany(p => p.TblBatchAdmissionArchives)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblStream");

            entity.HasOne(d => d.Student).WithMany(p => p.TblBatchAdmissionArchives)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblStudent");

            entity.HasOne(d => d.User).WithMany(p => p.TblBatchAdmissionArchives)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblBatchAdmissionArchive_tblEmployee");
        });

        modelBuilder.Entity<TblBatchAdmissionPast>(entity =>
        {
            entity.ToTable("tblBatchAdmissionPast");

            entity.HasIndex(e => new { e.StudentId, e.BatchId, e.CourseId, e.OrgId }, "NonClusteredIndex-20170102-165337");

            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.RollNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TcisuueDate)
                .HasColumnType("datetime")
                .HasColumnName("TCIsuueDate");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblBatchAdmissionPasts)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblBatchAdmissionPast_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblBatchAdmissionPasts)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmissionPast_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblBatchAdmissionPasts)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmissionPast_tblOrg");

            entity.HasOne(d => d.Stream).WithMany(p => p.TblBatchAdmissionPasts)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("FK_tblBatchAdmissionPast_tblStream");

            entity.HasOne(d => d.Student).WithMany(p => p.TblBatchAdmissionPasts)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchAdmissionPast_tblStudent");

            entity.HasOne(d => d.User).WithMany(p => p.TblBatchAdmissionPasts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblBatchAdmissionPast_tblEmployee");
        });

        modelBuilder.Entity<TblBillingTemplate>(entity =>
        {
            entity.ToTable("tblBillingTemplate");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Heading)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TemplateName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TermsAndConditions)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBlockAttributesCce>(entity =>
        {
            entity.ToTable("tblBlockAttributesCCE");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165357");

            entity.Property(e => e.AttributeName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblBlockAttributesCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBlockAttributesCCE_tblOrg");
        });

        modelBuilder.Entity<TblBlockCce>(entity =>
        {
            entity.ToTable("tblBlockCCE");

            entity.HasIndex(e => new { e.FormativeAssessmentId, e.OrgId }, "NonClusteredIndex-20170102-165412");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.FormativeAssessment).WithMany(p => p.TblBlockCces)
                .HasForeignKey(d => d.FormativeAssessmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBlockCCE_tblFormativeAssessmentCCE");

            entity.HasOne(d => d.Org).WithMany(p => p.TblBlockCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBlockCCE_tblOrg");
        });

        modelBuilder.Entity<TblBranch>(entity =>
        {
            entity.ToTable("tblBranch");

            entity.HasIndex(e => new { e.InstId, e.OrgId }, "NonClusteredIndex-20170102-165428");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Inst).WithMany(p => p.TblBranches)
                .HasForeignKey(d => d.InstId)
                .HasConstraintName("FK_tblBranch_tblInstitution");

            entity.HasOne(d => d.Org).WithMany(p => p.TblBranches)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBranch_tblOrg");
        });

        modelBuilder.Entity<TblCalenderAssignment>(entity =>
        {
            entity.ToTable("tblCalenderAssignment");

            entity.HasOne(d => d.Calender).WithMany(p => p.TblCalenderAssignments)
                .HasForeignKey(d => d.CalenderId)
                .HasConstraintName("FK_tblCalenderAssignment_tblCalenderHeaader");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblCalenderAssignments)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblCalenderAssignment_tblEmployee");

            entity.HasOne(d => d.EmpOrg).WithMany(p => p.TblCalenderAssignmentEmpOrgs)
                .HasForeignKey(d => d.EmpOrgId)
                .HasConstraintName("FK_tblCalenderAssignment_tblOrg1");

            entity.HasOne(d => d.Org).WithMany(p => p.TblCalenderAssignmentOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblCalenderAssignment_tblOrg");
        });

        modelBuilder.Entity<TblCalenderDetail>(entity =>
        {
            entity.ToTable("tblCalenderDetails");

            entity.Property(e => e.DatetimeDetail).HasColumnType("datetime");
            entity.Property(e => e.EventName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CalenderHeader).WithMany(p => p.TblCalenderDetails)
                .HasForeignKey(d => d.CalenderHeaderId)
                .HasConstraintName("FK_tblCalenderDetails_tblCalenderHeaader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblCalenderDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblCalenderDetails_tblOrg");
        });

        modelBuilder.Entity<TblCalenderHeaader>(entity =>
        {
            entity.ToTable("tblCalenderHeaader");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblCalenderHeaaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblCalenderHeaader_tblOrg");
        });

        modelBuilder.Entity<TblCaste>(entity =>
        {
            entity.ToTable("tblCaste");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165457");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblCastes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCaste_tblOrg");
        });

        modelBuilder.Entity<TblCertificate>(entity =>
        {
            entity.ToTable("tblCertificate");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165530");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblCertificates)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCertificate_tblOrg");
        });

        modelBuilder.Entity<TblChallanInvoiceDetail>(entity =>
        {
            entity.ToTable("tblChallan_InvoiceDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<TblChallanInvoiceHeader>(entity =>
        {
            entity.ToTable("tblChallan_InvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate)
                .HasColumnType("date")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.TinOrCst).HasColumnName("TinOrCST");
        });

        modelBuilder.Entity<TblChannel>(entity =>
        {
            entity.ToTable("tblChannel");

            entity.Property(e => e.ChannelName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblChannels)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblChannel_tblOrg");
        });

        modelBuilder.Entity<TblCircular>(entity =>
        {
            entity.ToTable("tblCircular");

            entity.Property(e => e.Dated).HasColumnType("datetime");
            entity.Property(e => e.Notice)
                .HasMaxLength(5000)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblCirculars)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblCircular_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblCirculars)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblCircular_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblCirculars)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCircular_tblOrg");
        });

        modelBuilder.Entity<TblCounsellor>(entity =>
        {
            entity.ToTable("tblCounsellor");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165612");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblCounsellors)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCounsellor_tblOrg");
        });

        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity.ToTable("tblCourse");

            entity.HasIndex(e => new { e.StreamId, e.OrgId }, "NonClusteredIndex-20170102-165631");

            entity.Property(e => e.CourseCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Fees).HasColumnType("money");
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblCourses)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourse_tblOrg");

            entity.HasOne(d => d.Stream).WithMany(p => p.TblCourses)
                .HasForeignKey(d => d.StreamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourse_tblStream");
        });

        modelBuilder.Entity<TblCourseFeeDetail>(entity =>
        {
            entity.ToTable("tblCourseFeeDetails");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20161121-225203");

            entity.HasIndex(e => new { e.Course, e.Batch, e.FeeItem, e.OrgId }, "NonClusteredIndex-20170102-165731");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.IsBilling).HasColumnName("isBilling");
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
            entity.Property(e => e.StandardRate).HasColumnType("money");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");

            entity.HasOne(d => d.BatchNavigation).WithMany(p => p.TblCourseFeeDetails)
                .HasForeignKey(d => d.Batch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourseFeeDetails_tblBatch");

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblCourseFeeDetails)
                .HasForeignKey(d => d.Course)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourseFeeDetails_tblCourse");

            entity.HasOne(d => d.FeeItemNavigation).WithMany(p => p.TblCourseFeeDetails)
                .HasForeignKey(d => d.FeeItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourseFeeDetails_tblFeeItemDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblCourseFeeDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourseFeeDetails_tblOrg");
        });

        modelBuilder.Entity<TblCourseSubject>(entity =>
        {
            entity.ToTable("tblCourse$Subject");

            entity.HasIndex(e => new { e.SubjectId, e.CourseId, e.OrgId }, "NonClusteredIndex-20170102-165648");

            entity.Property(e => e.Year).HasColumnType("date");

            entity.HasOne(d => d.Course).WithMany(p => p.TblCourseSubjects)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourse$Subject_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblCourseSubjects)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourse$Subject_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblCourseSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCourse$Subject_tblSubjects");
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.ToTable("tblCustomer");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165753");

            entity.Property(e => e.BalanceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cstnumber).HasColumnName("CSTNumber");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.OpeningBalance).HasColumnType("money");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblCustomers)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomer_tblOrg");
        });

        modelBuilder.Entity<TblDatabaseLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblDbLogging");

            entity.ToTable("tblDatabaseLog");

            entity.Property(e => e.CommandText).IsUnicode(false);
            entity.Property(e => e.Parameters).IsUnicode(false);
        });

        modelBuilder.Entity<TblDepartment>(entity =>
        {
            entity.ToTable("tblDepartments");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165811");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDepartments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDepartments_tblOrg");
        });

        modelBuilder.Entity<TblDesignation>(entity =>
        {
            entity.ToTable("tblDesignation");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165826");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDesignations)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDesignation_tblOrg");
        });

        modelBuilder.Entity<TblDietPlan>(entity =>
        {
            entity.ToTable("tblDietPlan");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165853");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDietPlans)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDietPlan_tblOrg");
        });

        modelBuilder.Entity<TblDietPlanDetail>(entity =>
        {
            entity.ToTable("tblDietPlanDetails");

            entity.HasIndex(e => new { e.DietId, e.Item, e.Course, e.OrgId }, "NonClusteredIndex-20170102-165906");

            entity.Property(e => e.Days)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblDietPlanDetails)
                .HasForeignKey(d => d.Course)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDietPlanDetails_tblCourse");

            entity.HasOne(d => d.Diet).WithMany(p => p.TblDietPlanDetails)
                .HasForeignKey(d => d.DietId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDietPlanDetails_tblDietPlan");

            entity.HasOne(d => d.ItemNavigation).WithMany(p => p.TblDietPlanDetails)
                .HasForeignKey(d => d.Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDietPlanDetails_tblDietaryItems");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDietPlanDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDietPlanDetails_tblOrg");
        });

        modelBuilder.Entity<TblDietPlanLinkedStudent>(entity =>
        {
            entity.ToTable("tblDietPlanLinkedStudents");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblDietPlanLinkedStudents)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblDietPlanLinkedStudents_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblDietPlanLinkedStudents)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblDietPlanLinkedStudents_tblCourse");

            entity.HasOne(d => d.DietPlan).WithMany(p => p.TblDietPlanLinkedStudents)
                .HasForeignKey(d => d.DietPlanId)
                .HasConstraintName("FK_tblDietPlanLinkedStudents_tblDietPlan");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDietPlanLinkedStudents)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblDietPlanLinkedStudents_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblDietPlanLinkedStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblDietPlanLinkedStudents_tblStudent");
        });

        modelBuilder.Entity<TblDietPlanRecording>(entity =>
        {
            entity.ToTable("tblDietPlanRecording");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblDietPlanRecordings)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblDietPlanRecording_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblDietPlanRecordings)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblDietPlanRecording_tblCourse");

            entity.HasOne(d => d.DietItem).WithMany(p => p.TblDietPlanRecordings)
                .HasForeignKey(d => d.DietItemId)
                .HasConstraintName("FK_tblDietPlanRecording_tblDietaryItems");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDietPlanRecordings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblDietPlanRecording_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblDietPlanRecordings)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblDietPlanRecording_tblStudent");
        });

        modelBuilder.Entity<TblDietaryItem>(entity =>
        {
            entity.ToTable("tblDietaryItems");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165838");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDietaryItems)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDietaryItems_tblOrg");
        });

        modelBuilder.Entity<TblDiscountType>(entity =>
        {
            entity.ToTable("tblDiscountType");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165924");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDiscountTypes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDiscountType_tblOrg");
        });

        modelBuilder.Entity<TblDmsrootUser>(entity =>
        {
            entity.ToTable("tblDMSRootUser");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblDmsrootUsers)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblDMSRootUser_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDmsrootUsers)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblDMSRootUser_tblOrg");
        });

        modelBuilder.Entity<TblDocfolderAccess>(entity =>
        {
            entity.ToTable("tblDOCFolderAccess");

            entity.HasOne(d => d.Folder).WithMany(p => p.TblDocfolderAccesses)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_tblDOCFolderAccess_tblDocumentFolder");

            entity.HasOne(d => d.User).WithMany(p => p.TblDocfolderAccesses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblDOCFolderAccess_tblEmployee");
        });

        modelBuilder.Entity<TblDocument>(entity =>
        {
            entity.ToTable("tblDocument");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DocName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileExt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastModifiedBy).HasColumnType("datetime");

            entity.HasOne(d => d.Folder).WithMany(p => p.TblDocuments)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_tblDocument_tblDocFolder");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDocuments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocument_tblOrg");
        });

        modelBuilder.Entity<TblDocumentAccess>(entity =>
        {
            entity.ToTable("tblDocumentAccess");

            entity.HasOne(d => d.Doc).WithMany(p => p.TblDocumentAccesses)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_tblDocumentAccess_tblDocument");

            entity.HasOne(d => d.User).WithMany(p => p.TblDocumentAccesses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblDocumentAccess_tblEmployee");
        });

        modelBuilder.Entity<TblDocumentFolder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblDocFolder");

            entity.ToTable("tblDocumentFolder");

            entity.Property(e => e.FolderName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDocumentFolders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblDocFolder_tblOrg");
        });

        modelBuilder.Entity<TblDocumentTag>(entity =>
        {
            entity.ToTable("tblDocumentTags");

            entity.Property(e => e.TagName).IsUnicode(false);

            entity.HasOne(d => d.Doc).WithMany(p => p.TblDocumentTags)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_tblDocumentTags_tblDocumentVersion");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDocumentTags)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblDocumentTags_tblOrg");

            entity.HasOne(d => d.User).WithMany(p => p.TblDocumentTags)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblDocumentTags_tblEmployee");
        });

        modelBuilder.Entity<TblDocumentTagName>(entity =>
        {
            entity.ToTable("tblDocumentTagNames");

            entity.Property(e => e.TagName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDocumentTagNames)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblDocumentTagNames_tblOrg");
        });

        modelBuilder.Entity<TblDocumentVersion>(entity =>
        {
            entity.ToTable("tblDocumentVersion");

            entity.Property(e => e.DocTag)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Doc).WithMany(p => p.TblDocumentVersions)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK_tblDocumentVersion_tblDocument");

            entity.HasOne(d => d.DocTagNavigation).WithMany(p => p.TblDocumentVersions)
                .HasForeignKey(d => d.DocTagId)
                .HasConstraintName("FK_tblDocumentVersion_tblDocumentTagNames");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDocumentVersions)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentVersion_tblOrg");
        });

        modelBuilder.Entity<TblDriver>(entity =>
        {
            entity.ToTable("tblDriver");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-165938");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.LicenseExpiry).HasColumnType("date");
            entity.Property(e => e.LicenseNumber).IsUnicode(false);
            entity.Property(e => e.Mobile).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.Phone).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblDrivers)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDriver_tblOrg1");
        });

        modelBuilder.Entity<TblDriverAttachment>(entity =>
        {
            entity.ToTable("tblDriverAttachment");

            entity.Property(e => e.FileName)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.Driver).WithMany(p => p.TblDriverAttachments)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDriverAttachment_tblDriver");

            entity.HasOne(d => d.Org).WithMany(p => p.TblDriverAttachments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDriverAttachment_tblOrg");
        });

        modelBuilder.Entity<TblEmailLog>(entity =>
        {
            entity.ToTable("tblEmailLog");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmailLogs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmailLog_tblOrg");

            entity.HasOne(d => d.User).WithMany(p => p.TblEmailLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblEmailLog_tblEmployee");
        });

        modelBuilder.Entity<TblEmailTemplate>(entity =>
        {
            entity.ToTable("tblEmailTemplate");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmailTemplates)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmailTemplate_tblOrg");
        });

        modelBuilder.Entity<TblEmpLeaveApplied>(entity =>
        {
            entity.ToTable("tblEmpLeaveApplied");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RejectReason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmpLeaveAppliedEmps)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmpLeaveApplied_tblEmployee");

            entity.HasOne(d => d.LeaveTypeNavigation).WithMany(p => p.TblEmpLeaveApplieds)
                .HasForeignKey(d => d.LeaveType)
                .HasConstraintName("FK_tblEmpLeaveApplied_tblLeaveType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmpLeaveApplieds)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmpLeaveApplied_tblOrg");

            entity.HasOne(d => d.User).WithMany(p => p.TblEmpLeaveAppliedUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblEmpLeaveApplied_tblEmployee1");
        });

        modelBuilder.Entity<TblEmpSalaryDetail>(entity =>
        {
            entity.ToTable("tblEmpSalaryDetails");

            entity.HasIndex(e => new { e.EmpId, e.OrgId }, "NonClusteredIndex-20170102-170217");

            entity.Property(e => e.BankAccountNo).IsUnicode(false);
            entity.Property(e => e.BankLedgerNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BasicSalary).HasColumnType("money");
            entity.Property(e => e.DateOfAppointment).HasColumnType("date");
            entity.Property(e => e.DateOfConfirmation).HasColumnType("date");
            entity.Property(e => e.IncrementAmt).HasColumnType("money");
            entity.Property(e => e.IsEligibleForPf).HasColumnName("IsEligibleForPF");
            entity.Property(e => e.Pfno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PFNo");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmpSalaryDetails)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmpSalaryDetails_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmpSalaryDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpSalaryDetails_tblOrg");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.ToTable("tblEmployee");

            entity.HasIndex(e => new { e.Id, e.RoleId, e.EmpId, e.OrgId }, "NonClusteredIndex-20161121-224250");

            entity.HasIndex(e => new { e.DepartmentId, e.RoleId, e.Designation, e.OrgId }, "NonClusteredIndex-20170102-165953");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DateOfJoining).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FavouriteDashboardId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).IsUnicode(false);
            entity.Property(e => e.GuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationMarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LanguagesKnown)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName).IsUnicode(false);
            entity.Property(e => e.MiddleName).IsUnicode(false);
            entity.Property(e => e.MotherTongue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PassportNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddresLine1).IsUnicode(false);
            entity.Property(e => e.PermanentAddressLine2).IsUnicode(false);
            entity.Property(e => e.PermanentArea).IsUnicode(false);
            entity.Property(e => e.PermanentCity).IsUnicode(false);
            entity.Property(e => e.PermanentCountry).IsUnicode(false);
            entity.Property(e => e.PermanentState).IsUnicode(false);
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddressLine1).IsUnicode(false);
            entity.Property(e => e.PresentAddressLine2).IsUnicode(false);
            entity.Property(e => e.PresentArea).IsUnicode(false);
            entity.Property(e => e.PresentCity).IsUnicode(false);
            entity.Property(e => e.PresentCountry).IsUnicode(false);
            entity.Property(e => e.PresentState).IsUnicode(false);
            entity.Property(e => e.RhType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpouseName).IsUnicode(false);
            entity.Property(e => e.StateOfDomicile)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Department).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_tblEmployee_tblDepartments");

            entity.HasOne(d => d.DesignationNavigation).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.Designation)
                .HasConstraintName("FK_tblEmployee_tblDesignation");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployee_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblEmployee_tblRole");
        });

        modelBuilder.Entity<TblEmployeeAdditionalInfo>(entity =>
        {
            entity.ToTable("tblEmployeeAdditionalInfo");

            entity.HasIndex(e => new { e.EmpId, e.OrgId }, "NonClusteredIndex-20170102-170034");

            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Col1Details).IsUnicode(false);
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Col2Details).IsUnicode(false);
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Col3Details).IsUnicode(false);
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Col4Details).IsUnicode(false);
            entity.Property(e => e.Col5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Col5Details).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmployeeAdditionalInfos)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmployeeAdditionalInfo_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeAdditionalInfos)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmployeeAdditionalInfo_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeAttachment>(entity =>
        {
            entity.ToTable("tblEmployeeAttachment");

            entity.HasIndex(e => new { e.EmployeeId, e.OrgId }, "NonClusteredIndex-20170102-170049");

            entity.Property(e => e.FileName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.TblEmployeeAttachments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeAttachment_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeAttachments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeAttachment_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeAttendance>(entity =>
        {
            entity.ToTable("tblEmployeeAttendance");

            entity.HasIndex(e => new { e.LeaveType, e.OrgId }, "NonClusteredIndex-20170102-170105");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.AttendaceTypeNavigation).WithMany(p => p.TblEmployeeAttendances)
                .HasForeignKey(d => d.AttendaceType)
                .HasConstraintName("FK_tblEmployeeAttendance_tblAttendanceConfig");

            entity.HasOne(d => d.LeaveTypeNavigation).WithMany(p => p.TblEmployeeAttendances)
                .HasForeignKey(d => d.LeaveType)
                .HasConstraintName("FK_tblEmployeeAttendance_tblEmployeeLeaveTypes");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeAttendances)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeAttendance_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeAttrition>(entity =>
        {
            entity.ToTable("tblEmployeeAttrition");

            entity.Property(e => e.DateOfRegisteration).HasColumnType("date");
            entity.Property(e => e.ExamInterviewDate).HasColumnType("date");
            entity.Property(e => e.FacetoFaceComments).IsUnicode(false);
            entity.Property(e => e.LastWorkingDay).HasColumnType("date");
            entity.Property(e => e.Remarks).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmployeeAttritions)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmployeeAttrition_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeAttritions)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeAttrition_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeAttritionChecklist>(entity =>
        {
            entity.ToTable("tblEmployeeAttritionChecklist");

            entity.HasOne(d => d.EmployeeAttrition).WithMany(p => p.TblEmployeeAttritionChecklists)
                .HasForeignKey(d => d.EmployeeAttritionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeAttritionChecklist_tblEmployeeAttrition");
        });

        modelBuilder.Entity<TblEmployeeExitCheckList>(entity =>
        {
            entity.ToTable("tblEmployeeExitCheckList");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeExitCheckLists)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeExitCheckList_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeGroupDetail>(entity =>
        {
            entity.ToTable("tblEmployeeGroupDetail");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmployeeGroupDetails)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmployeeGroupDetail_tblEmployee");

            entity.HasOne(d => d.Header).WithMany(p => p.TblEmployeeGroupDetails)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblEmployeeGroupDetail_tblEmployeeGroupHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeGroupDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmployeeGroupDetail_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblEmployeeGroupDetails)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblEmployeeGroupDetail_tblRole");
        });

        modelBuilder.Entity<TblEmployeeGroupHeader>(entity =>
        {
            entity.ToTable("tblEmployeeGroupHeader");

            entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeGroupHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmployeeGroupHeader_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeLeaveType>(entity =>
        {
            entity.ToTable("tblEmployeeLeaveTypes");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170126");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeLeaveTypes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeLeaveTypes_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeLetter>(entity =>
        {
            entity.ToTable("tblEmployeeLetter");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.FinalContent).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmployeeLetters)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmployeeLetter_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeLetters)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmployeeLetter_tblOrg");

            entity.HasOne(d => d.Template).WithMany(p => p.TblEmployeeLetters)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("FK_tblEmployeeLetter_tblEmployeeLetterTemplate");
        });

        modelBuilder.Entity<TblEmployeeLetterTemplate>(entity =>
        {
            entity.ToTable("tblEmployeeLetterTemplate");

            entity.Property(e => e.TemplateContent).IsUnicode(false);
            entity.Property(e => e.TemplateName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeLetterTemplates)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEmployeeLetterTemplate_tblOrg");
        });

        modelBuilder.Entity<TblEmployeeSalaryComponent>(entity =>
        {
            entity.ToTable("tblEmployeeSalaryComponent");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170159");

            entity.Property(e => e.ComponentName).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEmployeeSalaryComponents)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmployeeSalaryComponent_tblOrg");
        });

        modelBuilder.Entity<TblEvent>(entity =>
        {
            entity.ToTable("tblEvent");

            entity.HasIndex(e => new { e.EventType, e.OrgId }, "NonClusteredIndex-20170102-170248");

            entity.Property(e => e.ContactPerson).IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.EventName).IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.EventTypeNavigation).WithMany(p => p.TblEvents)
                .HasForeignKey(d => d.EventType)
                .HasConstraintName("FK_tblEvent_tblEventType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblEvents)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEvent_tblOrg");
        });

        modelBuilder.Entity<TblEventType>(entity =>
        {
            entity.ToTable("tblEventType");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170310");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblEventTypes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblEventType_tblOrg");
        });

        modelBuilder.Entity<TblExamAttributeWiseMark>(entity =>
        {
            entity.ToTable("tblExamAttributeWiseMarks");

            entity.Property(e => e.Mark).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Attribute).WithMany(p => p.TblExamAttributeWiseMarks)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_tblExamAttributeWiseMarks_tblSubComponentAttributes");

            entity.HasOne(d => d.Component).WithMany(p => p.TblExamAttributeWiseMarks)
                .HasForeignKey(d => d.ComponentId)
                .HasConstraintName("FK_tblExamAttributeWiseMarks_tblSubjectSubComponents");

            entity.HasOne(d => d.ExamSchedule).WithMany(p => p.TblExamAttributeWiseMarks)
                .HasForeignKey(d => d.ExamScheduleId)
                .HasConstraintName("FK_tblExamAttributeWiseMarks_tblExamSchedule");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamAttributeWiseMarks)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExamAttributeWiseMarks_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblExamAttributeWiseMarks)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblExamAttributeWiseMarks_tblStudent");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblExamAttributeWiseMarks)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblExamAttributeWiseMarks_tblSubjects");
        });

        modelBuilder.Entity<TblExamHall>(entity =>
        {
            entity.ToTable("tblExamHall");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170329");

            entity.Property(e => e.HallNumber).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamHalls)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExamHall_tblOrg");
        });

        modelBuilder.Entity<TblExamMark>(entity =>
        {
            entity.ToTable("tblExamMarks");

            entity.HasIndex(e => new { e.ExamSchdeduleId, e.SubjectId, e.StudentId, e.OrgId }, "NonClusteredIndex-20170102-170347");

            entity.Property(e => e.Marks).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.ExamSchdedule).WithMany(p => p.TblExamMarks)
                .HasForeignKey(d => d.ExamSchdeduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExamMarks_tblExamSchedule");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamMarks)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExamMarks_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblExamMarks)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExamMarks_tblStudent");

            entity.HasOne(d => d.SubjectComponenet).WithMany(p => p.TblExamMarks)
                .HasForeignKey(d => d.SubjectComponenetId)
                .HasConstraintName("FK_tblExamMarks_tblSubjectSubComponents");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblExamMarks)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExamMarks_tblSubjects");
        });

        modelBuilder.Entity<TblExamSchedule>(entity =>
        {
            entity.ToTable("tblExamSchedule");

            entity.HasIndex(e => new { e.ExamType, e.SubjectId, e.BatchId, e.CourseId, e.Faculty, e.ExamHall, e.OrgId }, "NonClusteredIndex-20170102-170407");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblExamSchedule_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblExamSchedule_tblCourse");

            entity.HasOne(d => d.ExamHallNavigation).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.ExamHall)
                .HasConstraintName("FK_tblExamSchedule_tblExamHall");

            entity.HasOne(d => d.ExamTypeNavigation).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.ExamType)
                .HasConstraintName("FK_tblExamSchedule_tblExamType");

            entity.HasOne(d => d.FacultyNavigation).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.Faculty)
                .HasConstraintName("FK_tblExamSchedule_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExamSchedule_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblExamSchedules)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblExamSchedule_tblSubjects");
        });

        modelBuilder.Entity<TblExamType>(entity =>
        {
            entity.ToTable("tblExamType");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170435");

            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamTypes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExamType_tblOrg");
        });

        modelBuilder.Entity<TblExamTypeLinkedWithComponent>(entity =>
        {
            entity.ToTable("tblExamTypeLinkedWithComponents");
        });

        modelBuilder.Entity<TblExamTypeLinkedWithCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblCourseLinkedExamType");

            entity.ToTable("tblExamTypeLinkedWithCourse");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblExamTypeLinkedWithCourses)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblCourseLinkedExamType_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblExamTypeLinkedWithCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblCourseLinkedExamType_tblCourse");

            entity.HasOne(d => d.ExamType).WithMany(p => p.TblExamTypeLinkedWithCourses)
                .HasForeignKey(d => d.ExamTypeId)
                .HasConstraintName("FK_tblCourseLinkedExamType_tblExamType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamTypeLinkedWithCourses)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblCourseLinkedExamType_tblOrg");
        });

        modelBuilder.Entity<TblExamTypeLinkedWithSubject>(entity =>
        {
            entity.ToTable("tblExamTypeLinkedWithSubject");

            entity.HasOne(d => d.CourseLinkedExamType).WithMany(p => p.TblExamTypeLinkedWithSubjects)
                .HasForeignKey(d => d.CourseLinkedExamTypeId)
                .HasConstraintName("FK_tblExamTypeLinkedWithSubject_tblCourseLinkedExamType");

            entity.HasOne(d => d.ExamType).WithMany(p => p.TblExamTypeLinkedWithSubjects)
                .HasForeignKey(d => d.ExamTypeId)
                .HasConstraintName("FK_tblExamTypeLinkedWithSubject_tblExamType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExamTypeLinkedWithSubjects)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExamTypeLinkedWithSubject_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblExamTypeLinkedWithSubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblExamTypeLinkedWithSubject_tblSubjects");
        });

        modelBuilder.Entity<TblExitInterviewQuestionnaire>(entity =>
        {
            entity.ToTable("tblExitInterviewQuestionnaire");

            entity.Property(e => e.Question).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblExitInterviewQuestionnaires)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExitInterviewQuestionnaire_tblOrg");
        });

        modelBuilder.Entity<TblExpenditureDoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblExpenseDocuments");

            entity.ToTable("tblExpenditureDocs");

            entity.Property(e => e.ExpenditureFileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GUId");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExpenditureDocs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExpenditureDocs_tblOrg");
        });

        modelBuilder.Entity<TblExpenseCategory>(entity =>
        {
            entity.ToTable("tblExpenseCategory");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblExpenseCategories)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExpenseCategory_tblOrg");
        });

        modelBuilder.Entity<TblExpenseDetail>(entity =>
        {
            entity.ToTable("tblExpenseDetails");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.ExpenseName).IsUnicode(false);
            entity.Property(e => e.GrandTotal).HasColumnType("money");
            entity.Property(e => e.Guid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GUId");
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.Value).HasColumnType("money");

            entity.HasOne(d => d.BankNavigation).WithMany(p => p.TblExpenseDetails)
                .HasForeignKey(d => d.Bank)
                .HasConstraintName("FK_tblExpenseDetails_tblBankDetails");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.TblExpenseDetails)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_tblExpenseDetails_tblExpenseCategory");

            entity.HasOne(d => d.Org).WithMany(p => p.TblExpenseDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblExpenseDetails_tblOrg");

            entity.HasOne(d => d.PaymentModeNavigation).WithMany(p => p.TblExpenseDetails)
                .HasForeignKey(d => d.PaymentMode)
                .HasConstraintName("FK_tblExpenseDetails_tblFeePaymentMode");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TblExpenseDetails)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_tblExpenseDetails_tblVendor");
        });

        modelBuilder.Entity<TblFeeDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblPaidForPeriod");

            entity.ToTable("tblFeeDescription");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeeDescriptions)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblFeeDescription_tblOrg");
        });

        modelBuilder.Entity<TblFeeInstallmentDetail>(entity =>
        {
            entity.ToTable("tblFeeInstallmentDetail");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20161121-225216");

            entity.HasIndex(e => new { e.CourseId, e.OrgId }, "NonClusteredIndex-20170102-170447");

            entity.Property(e => e.MinFeeAmount).HasColumnType("money");

            entity.HasOne(d => d.Course).WithMany(p => p.TblFeeInstallmentDetails)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblFeeInstallmentDetail_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeeInstallmentDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeeInstallmentDetail_tblOrg");
        });

        modelBuilder.Entity<TblFeeItemDetail>(entity =>
        {
            entity.ToTable("tblFeeItemDetails");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20161121-225231");

            entity.HasIndex(e => new { e.LedgerGroup, e.OrgId }, "NonClusteredIndex-20170102-170501");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsBilling).HasColumnName("isBilling");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
            entity.Property(e => e.StandardRate).HasColumnType("money");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");

            entity.HasOne(d => d.LedgerGroupNavigation).WithMany(p => p.TblFeeItemDetails)
                .HasForeignKey(d => d.LedgerGroup)
                .HasConstraintName("FK_tblFeeItemDetails_tblFeeLedgerGroup");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeeItemDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeeItemDetails_tblOrg");
        });

        modelBuilder.Entity<TblFeeLedgerGroup>(entity =>
        {
            entity.ToTable("tblFeeLedgerGroup");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170518");

            entity.Property(e => e.IsBilling).HasColumnName("isBilling");
            entity.Property(e => e.LedgerCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeeLedgerGroups)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeeLedgerGroup_tblOrg");
        });

        modelBuilder.Entity<TblFeeLinkedInventoryItem>(entity =>
        {
            entity.ToTable("tblFeeLinkedInventoryItem");

            entity.HasOne(d => d.Fee).WithMany(p => p.TblFeeLinkedInventoryItems)
                .HasForeignKey(d => d.FeeId)
                .HasConstraintName("FK_tblFeeLinkedInventoryItem_tblFeeItemDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeeLinkedInventoryItems)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblFeeLinkedInventoryItem_tblOrg");

            entity.HasOne(d => d.Stock).WithMany(p => p.TblFeeLinkedInventoryItems)
                .HasForeignKey(d => d.StockId)
                .HasConstraintName("FK_tblFeeLinkedInventoryItem_tblStockItem");
        });

        modelBuilder.Entity<TblFeePaidDetail>(entity =>
        {
            entity.ToTable("tblFeePaidDetails");

            entity.HasIndex(e => new { e.FeePaidHeader, e.OrgId }, "NonClusteredIndex-20161121-224540");

            entity.HasIndex(e => new { e.FeePaidHeader, e.FeeItemId, e.OrgId }, "NonClusteredIndex-20170102-170531");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.IsBilling).HasColumnName("isBilling");

            entity.HasOne(d => d.FeeItem).WithMany(p => p.TblFeePaidDetails)
                .HasForeignKey(d => d.FeeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeePaidDetails_tblFeeItemDetails");

            entity.HasOne(d => d.FeePaidHeaderNavigation).WithMany(p => p.TblFeePaidDetails)
                .HasForeignKey(d => d.FeePaidHeader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeePaidDetails_tblStudentFeePaidHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeePaidDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeePaidDetails_tblOrg");
        });

        modelBuilder.Entity<TblFeePaymentDetail>(entity =>
        {
            entity.ToTable("tblFeePaymentDetails");

            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.CancelledReason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.IsCancelled).HasColumnName("isCancelled");
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("date");
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SubReceiptNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BankNavigation).WithMany(p => p.TblFeePaymentDetails)
                .HasForeignKey(d => d.Bank)
                .HasConstraintName("FK_tblFeePaymentDetails_tblBankDetails");

            entity.HasOne(d => d.FeeHeader).WithMany(p => p.TblFeePaymentDetails)
                .HasForeignKey(d => d.FeeHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeePaymentDetails_tblStudentFeePaidHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeePaymentDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblFeePaymentDetails_tblOrg");

            entity.HasOne(d => d.PaidForPeriodLinkedNavigation).WithMany(p => p.TblFeePaymentDetails)
                .HasForeignKey(d => d.PaidForPeriodLinked)
                .HasConstraintName("FK_tblFeePaymentDetails_tblFeeDescription");

            entity.HasOne(d => d.PaymentModeNavigation).WithMany(p => p.TblFeePaymentDetails)
                .HasForeignKey(d => d.PaymentMode)
                .HasConstraintName("FK_tblFeePaymentDetails_tblFeePaymentMode");

            entity.HasOne(d => d.Student).WithMany(p => p.TblFeePaymentDetails)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeePaymentDetails_tblStudent");
        });

        modelBuilder.Entity<TblFeePaymentMode>(entity =>
        {
            entity.ToTable("tblFeePaymentMode");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170549");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsBilling).HasColumnName("isBilling");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeePaymentModes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFeePaymentMode_tblOrg");
        });

        modelBuilder.Entity<TblFeedback>(entity =>
        {
            entity.ToTable("tblFeedback");

            entity.Property(e => e.FeedbackText).IsUnicode(false);
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.TblFeedbacks)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_tblFeedback_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFeedbacks)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblFeedback_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblFeedbacks)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblFeedback_tblStudent");
        });

        modelBuilder.Entity<TblFinancialYear>(entity =>
        {
            entity.ToTable("tblFinancialYear");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblFinancialYears)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFinancialYear_tblOrg");
        });

        modelBuilder.Entity<TblFormativeAssessmentCce>(entity =>
        {
            entity.ToTable("tblFormativeAssessmentCCE");

            entity.HasIndex(e => new { e.TermId, e.OrgId }, "NonClusteredIndex-20170102-170601");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblFormativeAssessmentCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFormativeAssessmentCCE_tblOrg");

            entity.HasOne(d => d.Term).WithMany(p => p.TblFormativeAssessmentCces)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFormativeAssessmentCCE_tblTermCCE");
        });

        modelBuilder.Entity<TblFranchiseDetail>(entity =>
        {
            entity.ToTable("tblFranchiseDetails");

            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.RoyaltyFlat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RoyaltyPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TermsAndConditions).HasMaxLength(200);

            entity.HasOne(d => d.ChildOrg).WithMany(p => p.TblFranchiseDetails)
                .HasForeignKey(d => d.ChildOrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFranchiseDetails_tblOrg");

            entity.HasOne(d => d.FinancialYear).WithMany(p => p.TblFranchiseDetails)
                .HasForeignKey(d => d.FinancialYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFranchiseDetails_tblFinancialYear");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TblFranchiseDetails)
                .HasForeignKey(d => d.UpdatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFranchiseDetails_tblLogin");
        });

        modelBuilder.Entity<TblGallery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gallery");

            entity.ToTable("tblGallery");

            entity.Property(e => e.Caption)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FilePath).IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Section)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblGalleries)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gallery_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblGalleries)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gallery_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGalleries)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gallery_tblOrg");

            entity.HasOne(d => d.UploadedByNavigation).WithMany(p => p.TblGalleries)
                .HasForeignKey(d => d.UploadedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gallery_tblEmployee");
        });

        modelBuilder.Entity<TblGlobalOrgSetting>(entity =>
        {
            entity.ToTable("tblGlobalOrgSettings");

            entity.HasIndex(e => new { e.BarcodeType, e.OrgId }, "NonClusteredIndex-20170102-170615");

            entity.Property(e => e.AnniversaryEmailContent).HasMaxLength(2000);
            entity.Property(e => e.BirthdayEmailContent).HasMaxLength(2000);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmailSenderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FeeBodyTemplate).HasMaxLength(2000);
            entity.Property(e => e.FooterHtml).HasColumnName("FooterHTML");
            entity.Property(e => e.HeaderHtml).HasColumnName("HeaderHTML");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Smtpport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTPPort");
            entity.Property(e => e.Smtpserver)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SMTPServer");
            entity.Property(e => e.TermsAndConditionPayment)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Udisenumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UDISENumber");

            entity.HasOne(d => d.BarcodeTypeNavigation).WithMany(p => p.TblGlobalOrgSettings)
                .HasForeignKey(d => d.BarcodeType)
                .HasConstraintName("FK_tblGlobalOrgSettings_tblBarCodeSymbology");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGlobalOrgSettings)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGlobalOrgSettings_tblOrg");
        });

        modelBuilder.Entity<TblGpsdatum>(entity =>
        {
            entity.ToTable("tblGPSData");

            entity.HasIndex(e => new { e.RouteCode, e.OrgId }, "NonClusteredIndex-20170102-170637");

            entity.Property(e => e.Time).HasColumnType("datetime");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGpsdata)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblGPSData_tblOrg");

            entity.HasOne(d => d.RouteCodeNavigation).WithMany(p => p.TblGpsdata)
                .HasForeignKey(d => d.RouteCode)
                .HasConstraintName("FK_tblGPSData_tblRoute");
        });

        modelBuilder.Entity<TblGradeSystem>(entity =>
        {
            entity.ToTable("tblGradeSystems");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblGradeSystems)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGradeSystems_tblOrg");
        });

        modelBuilder.Entity<TblGradesystemDetail>(entity =>
        {
            entity.ToTable("tblGradesystemDetails");

            entity.Property(e => e.Grade)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GradeSystem).WithMany(p => p.TblGradesystemDetails)
                .HasForeignKey(d => d.GradeSystemId)
                .HasConstraintName("FK_tblGradesystemDetails_tblGradeSystems");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGradesystemDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGradesystemDetails_tblOrg");
        });

        modelBuilder.Entity<TblGrievanceCategory>(entity =>
        {
            entity.ToTable("tblGrievanceCategory");

            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblGrievanceCategories)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblGrievanceCategory_tblOrg");
        });

        modelBuilder.Entity<TblGrievanceRecord>(entity =>
        {
            entity.ToTable("tblGrievanceRecord");

            entity.Property(e => e.ActionTaken).IsUnicode(false);
            entity.Property(e => e.ActionTakenDate).HasColumnType("date");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.GrievanceDescription).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.TblGrievanceRecords)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblGrievanceRecord_tblGrievanceCategory");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGrievanceRecords)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblGrievanceRecord_tblOrg");

            entity.HasOne(d => d.RecordedByNavigation).WithMany(p => p.TblGrievanceRecords)
                .HasForeignKey(d => d.RecordedBy)
                .HasConstraintName("FK_tblGrievanceRecord_tblEmployee");
        });

        modelBuilder.Entity<TblGrnDirectDetail>(entity =>
        {
            entity.ToTable("tblGRN_Direct_Detail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DiscountAmt).HasColumnType("money");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PricePerUnit).HasColumnType("money");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblGrnDirectHeader>(entity =>
        {
            entity.ToTable("tblGRN_Direct_Header");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TblGrnPoDetail>(entity =>
        {
            entity.ToTable("tblGRN_PO_Detail");

            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PricePerUnit).HasColumnType("money");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Header).WithMany(p => p.TblGrnPoDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGRN_PO_Detail_tblGRN_PO_Header");

            entity.HasOne(d => d.ItemNavigation).WithMany(p => p.TblGrnPoDetails)
                .HasForeignKey(d => d.Item)
                .HasConstraintName("FK_tblGRN_PO_Detail_tblStockItem");

            entity.HasOne(d => d.ItemCodeNavigation).WithMany(p => p.TblGrnPoDetails)
                .HasForeignKey(d => d.ItemCode)
                .HasConstraintName("FK_tblGRN_PO_Detail_tblStockGroup");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGrnPoDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGRN_PO_Detail_tblOrg");
        });

        modelBuilder.Entity<TblGrnPoHeader>(entity =>
        {
            entity.ToTable("tblGRN_PO_Header");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Grndate)
                .HasColumnType("date")
                .HasColumnName("GRNDate");
            entity.Property(e => e.InvoiceNo).IsUnicode(false);
            entity.Property(e => e.Pono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PONo");
            entity.Property(e => e.Total).HasColumnType("money");
            entity.Property(e => e.TotalTax).HasColumnType("money");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGrnPoHeaders)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGRN_PO_Header_tblOrg");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TblGrnPoHeaders)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_tblGRN_PO_Header_tblVendor");
        });

        modelBuilder.Entity<TblGroup>(entity =>
        {
            entity.ToTable("tblGroup");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblGroups)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGroup_tblOrg");
        });

        modelBuilder.Entity<TblGroupMember>(entity =>
        {
            entity.ToTable("tblGroupMember");

            entity.Property(e => e.MemberEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MemberName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MemberPhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Group).WithMany(p => p.TblGroupMembers)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGroupMember_tblGroup");

            entity.HasOne(d => d.Org).WithMany(p => p.TblGroupMembers)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblGroupMember_tblOrg");
        });

        modelBuilder.Entity<TblHolidayList>(entity =>
        {
            entity.ToTable("tblHolidayList");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170810");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblHolidayLists)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblHolidayList_tblOrg");
        });

        modelBuilder.Entity<TblHostel>(entity =>
        {
            entity.ToTable("tblHostel");

            entity.HasIndex(e => new { e.HostelType, e.OrgId }, "NonClusteredIndex-20170102-170825");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.ContactNumber).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.WardenName).IsUnicode(false);

            entity.HasOne(d => d.HostelTypeNavigation).WithMany(p => p.TblHostels)
                .HasForeignKey(d => d.HostelType)
                .HasConstraintName("FK_tblHostel_tblHostelType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblHostels)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblHostel_tblOrg");
        });

        modelBuilder.Entity<TblHostelBilling>(entity =>
        {
            entity.ToTable("tblHostelBilling");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170914");

            entity.HasOne(d => d.Org).WithMany(p => p.TblHostelBillings)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblHostelBilling_tblOrg");
        });

        modelBuilder.Entity<TblHostelRoom>(entity =>
        {
            entity.ToTable("tblHostel$Room");

            entity.HasIndex(e => new { e.HostelId, e.RoomId, e.OrgId }, "NonClusteredIndex-20170102-170840");

            entity.HasOne(d => d.Hostel).WithMany(p => p.TblHostelRooms)
                .HasForeignKey(d => d.HostelId)
                .HasConstraintName("FK_tblHostel$Room_tblHostel");

            entity.HasOne(d => d.Org).WithMany(p => p.TblHostelRooms)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblHostel$Room_tblOrg");

            entity.HasOne(d => d.Room).WithMany(p => p.TblHostelRooms)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_tblHostel$Room_tblHostelRoom");
        });

        modelBuilder.Entity<TblHostelRoom1>(entity =>
        {
            entity.ToTable("tblHostelRoom");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170925");

            entity.HasOne(d => d.Org).WithMany(p => p.TblHostelRoom1s)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblHostelRoom_tblOrg");
        });

        modelBuilder.Entity<TblHostelRoomStudent>(entity =>
        {
            entity.ToTable("tblHostel$Room$Student");

            entity.HasIndex(e => new { e.HostelRoomId, e.OrgId }, "NonClusteredIndex-20170102-170857");

            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.HostelRoom).WithMany(p => p.TblHostelRoomStudents)
                .HasForeignKey(d => d.HostelRoomId)
                .HasConstraintName("FK_tblHostel$Room$Student_tblHostel$Room");

            entity.HasOne(d => d.Org).WithMany(p => p.TblHostelRoomStudents)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblHostel$Room$Student_tblOrg");
        });

        modelBuilder.Entity<TblHostelType>(entity =>
        {
            entity.ToTable("tblHostelType");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-170938");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblHostelTypes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblHostelType_tblOrg");
        });

        modelBuilder.Entity<TblImageGallery>(entity =>
        {
            entity.ToTable("tblImageGallery");

            entity.HasIndex(e => new { e.EmpId, e.OrgId }, "NonClusteredIndex-20170102-170951");

            entity.Property(e => e.ImageName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.BatchNavigation).WithMany(p => p.TblImageGalleries)
                .HasForeignKey(d => d.Batch)
                .HasConstraintName("FK_tblImageGallery_tblBatch");

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblImageGalleries)
                .HasForeignKey(d => d.Course)
                .HasConstraintName("FK_tblImageGallery_tblCourse");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblImageGalleries)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblImageGallery_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblImageGalleries)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblImageGallery_tblOrg");
        });

        modelBuilder.Entity<TblInactiveEmployee>(entity =>
        {
            entity.ToTable("tblInactiveEmployee");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Narration).IsUnicode(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.TblInactiveEmployeeEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_tblInactiveEmployee_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblInactiveEmployees)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblInactiveEmployee_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblInactiveEmployees)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblInactiveEmployee_tblRole");

            entity.HasOne(d => d.User).WithMany(p => p.TblInactiveEmployeeUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblInactiveEmployee_tblEmployee1");
        });

        modelBuilder.Entity<TblInactiveEmployeeLog>(entity =>
        {
            entity.ToTable("tblInactiveEmployeeLog");

            entity.Property(e => e.Narration).IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.TblInactiveEmployeeLogEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_tblInactiveEmployeeLog_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblInactiveEmployeeLogs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblInactiveEmployeeLog_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblInactiveEmployeeLogs)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblInactiveEmployeeLog_tblRole");

            entity.HasOne(d => d.User).WithMany(p => p.TblInactiveEmployeeLogUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblInactiveEmployeeLog_tblEmployee1");
        });

        modelBuilder.Entity<TblInactiveStudent>(entity =>
        {
            entity.ToTable("tblInactiveStudent");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Narration).IsUnicode(false);
            entity.Property(e => e.RollNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblInactiveStudents)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblInactiveStudent_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblInactiveStudents)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInactiveStudent_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblInactiveStudents)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInactiveStudent_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblInactiveStudents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInactiveStudent_tblStudent");
        });

        modelBuilder.Entity<TblInactiveStudentLog>(entity =>
        {
            entity.ToTable("tblInactiveStudentLog");

            entity.Property(e => e.Narration).IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblInactiveStudentLogs)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblInactiveStudentLog_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblInactiveStudentLogs)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblInactiveStudentLog_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblInactiveStudentLogs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblInactiveStudentLog_tblOrg");

            entity.HasOne(d => d.OtherProgram).WithMany(p => p.TblInactiveStudentLogs)
                .HasForeignKey(d => d.OtherProgramId)
                .HasConstraintName("FK_tblInactiveStudentLog_tblOtherPrograms");

            entity.HasOne(d => d.Student).WithMany(p => p.TblInactiveStudentLogs)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblInactiveStudentLog_tblStudent");
        });

        modelBuilder.Entity<TblIncomeHeader>(entity =>
        {
            entity.ToTable("tblIncomeHeader");

            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.FromName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.RecievedOn).HasColumnType("money");

            entity.HasOne(d => d.ModeOfPaymentNavigation).WithMany(p => p.TblIncomeHeaders)
                .HasForeignKey(d => d.ModeOfPayment)
                .HasConstraintName("FK_tblIncomeHeader_tblFeePaymentMode");

            entity.HasOne(d => d.Org).WithMany(p => p.TblIncomeHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblIncomeHeader_tblOrg");
        });

        modelBuilder.Entity<TblIndicator>(entity =>
        {
            entity.ToTable("tblIndicator");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblIndicators)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIndicator_tblOrg");
        });

        modelBuilder.Entity<TblIndicatorConfig>(entity =>
        {
            entity.ToTable("tblIndicatorConfig");

            entity.HasOne(d => d.IndicatorHeader).WithMany(p => p.TblIndicatorConfigs)
                .HasForeignKey(d => d.IndicatorHeaderId)
                .HasConstraintName("FK_tblIndicatorConfig_tblIndicatorGroup");

            entity.HasOne(d => d.Indicator).WithMany(p => p.TblIndicatorConfigs)
                .HasForeignKey(d => d.IndicatorId)
                .HasConstraintName("FK_tblIndicatorConfig_tblIndicator");

            entity.HasOne(d => d.LoggedUserOrg).WithMany(p => p.TblIndicatorConfigLoggedUserOrgs)
                .HasForeignKey(d => d.LoggedUserOrgId)
                .HasConstraintName("FK_tblIndicatorConfig_tblOrg1");

            entity.HasOne(d => d.Org).WithMany(p => p.TblIndicatorConfigOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblIndicatorConfig_tblOrg");
        });

        modelBuilder.Entity<TblIndicatorDescriptor>(entity =>
        {
            entity.ToTable("tblIndicatorDescriptor");

            entity.Property(e => e.Descriptor).IsUnicode(false);
        });

        modelBuilder.Entity<TblIndicatorDetail>(entity =>
        {
            entity.ToTable("tblIndicatorDetails");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Indicator).WithMany(p => p.TblIndicatorDetails)
                .HasForeignKey(d => d.IndicatorId)
                .HasConstraintName("FK_tblIndicatorDetails_tblIndicator");

            entity.HasOne(d => d.Org).WithMany(p => p.TblIndicatorDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIndicatorDetails_tblOrg");
        });

        modelBuilder.Entity<TblIndicatorGroup>(entity =>
        {
            entity.ToTable("tblIndicatorGroup");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.IsLinkedWithHod).HasColumnName("IsLinkedWithHOD");
            entity.Property(e => e.IsLinkedWithSsf).HasColumnName("IsLinkedWithSSF");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblIndicatorGroups)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIndicatorGroup_tblOrg");
        });

        modelBuilder.Entity<TblIndicatorPoint>(entity =>
        {
            entity.ToTable("tblIndicatorPoints");

            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(5000)
                .IsUnicode(false);

            entity.HasOne(d => d.Indicator).WithMany(p => p.TblIndicatorPoints)
                .HasForeignKey(d => d.IndicatorId)
                .HasConstraintName("FK_tblIndicatorPoints_tblIndicator");

            entity.HasOne(d => d.Org).WithMany(p => p.TblIndicatorPoints)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIndicatorPoints_tblOrg");
        });

        modelBuilder.Entity<TblIndicatorResult>(entity =>
        {
            entity.ToTable("tblIndicatorResults");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblIndicatorResults)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblIndicatorResults_tblEmployee");

            entity.HasOne(d => d.IndicatorDetail).WithMany(p => p.TblIndicatorResults)
                .HasForeignKey(d => d.IndicatorDetailId)
                .HasConstraintName("FK_tblIndicatorResults_tblIndicatorDetails");

            entity.HasOne(d => d.IndicatorResultHeader).WithMany(p => p.TblIndicatorResults)
                .HasForeignKey(d => d.IndicatorResultHeaderId)
                .HasConstraintName("FK_tblIndicatorResults_tblIndicatorResultHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblIndicatorResults)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIndicatorResults_tblOrg");
        });

        modelBuilder.Entity<TblIndicatorResultHeader>(entity =>
        {
            entity.ToTable("tblIndicatorResultHeader");

            entity.Property(e => e.Comments).IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.TblIndicatorResultHeaderEmps)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblIndicatorResultHeader_tblEmployee");

            entity.HasOne(d => d.EmpOrg).WithMany(p => p.TblIndicatorResultHeaders)
                .HasForeignKey(d => d.EmpOrgId)
                .HasConstraintName("FK_tblIndicatorResultHeader_tblOrg");

            entity.HasOne(d => d.LoggedUser).WithMany(p => p.TblIndicatorResultHeaderLoggedUsers)
                .HasForeignKey(d => d.LoggedUserId)
                .HasConstraintName("FK_tblIndicatorResultHeader_tblEmployee1");

            entity.HasOne(d => d.RubricsHeader).WithMany(p => p.TblIndicatorResultHeaders)
                .HasForeignKey(d => d.RubricsHeaderId)
                .HasConstraintName("FK_tblIndicatorResultHeader_tblIndicatorGroup");
        });

        modelBuilder.Entity<TblInstallmentTemplateDetail>(entity =>
        {
            entity.ToTable("tblInstallmentTemplateDetails");

            entity.Property(e => e.Amount).HasColumnType("money");

            entity.HasOne(d => d.Header).WithMany(p => p.TblInstallmentTemplateDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInstallmentTemplateDetails_tblInstallmentTemplateHeader");
        });

        modelBuilder.Entity<TblInstallmentTemplateHeader>(entity =>
        {
            entity.ToTable("tblInstallmentTemplateHeader");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BatchNavigation).WithMany(p => p.TblInstallmentTemplateHeaders)
                .HasForeignKey(d => d.Batch)
                .HasConstraintName("FK_tblInstallmentTemplateHeader_tblBatch");

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblInstallmentTemplateHeaders)
                .HasForeignKey(d => d.Course)
                .HasConstraintName("FK_tblInstallmentTemplateHeader_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblInstallmentTemplateHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblInstallmentTemplateHeader_tblOrg");
        });

        modelBuilder.Entity<TblInstitution>(entity =>
        {
            entity.ToTable("tblInstitution");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171006");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.AdminContact).IsUnicode(false);
            entity.Property(e => e.Country).IsUnicode(false);
            entity.Property(e => e.CurrencyType).IsUnicode(false);
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Fax).IsUnicode(false);
            entity.Property(e => e.InstittuionCode).IsUnicode(false);
            entity.Property(e => e.Mobile).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Phone).IsUnicode(false);
            entity.Property(e => e.TimeZone).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblInstitutions)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblInstitution_tblOrg");
        });

        modelBuilder.Entity<TblIssueList>(entity =>
        {
            entity.ToTable("tblIssueList");

            entity.HasIndex(e => new { e.LoggedBy, e.OrgId }, "NonClusteredIndex-20170102-171018");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Description).IsUnicode(false);

            entity.HasOne(d => d.LoggedByNavigation).WithMany(p => p.TblIssueLists)
                .HasForeignKey(d => d.LoggedBy)
                .HasConstraintName("FK_tblIssueList_tblLogin");

            entity.HasOne(d => d.Org).WithMany(p => p.TblIssueLists)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblIssueList_tblOrg");
        });

        modelBuilder.Entity<TblItem>(entity =>
        {
            entity.ToTable("tblItems");

            entity.HasIndex(e => new { e.CategoryId, e.OrgId }, "NonClusteredIndex-20170102-171104");

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CostPrice).HasColumnType("money");
            entity.Property(e => e.Cstpercent)
                .HasColumnType("money")
                .HasColumnName("CSTpercent");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfPurchase).HasColumnType("date");
            entity.Property(e => e.ItemName).IsUnicode(false);
            entity.Property(e => e.MrpperUnit)
                .HasColumnType("money")
                .HasColumnName("MRPperUnit");
            entity.Property(e => e.Picture).HasMaxLength(50);
            entity.Property(e => e.RebateOnCp).HasColumnName("RebateOnCP");
            entity.Property(e => e.RebatePercentCp).HasColumnName("RebatePercentCP");
            entity.Property(e => e.Shape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpperUnit)
                .HasColumnType("money")
                .HasColumnName("SPperUnit");

            entity.HasOne(d => d.Category).WithMany(p => p.TblItems)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tblItems_tblItemCategory");

            entity.HasOne(d => d.Org).WithMany(p => p.TblItems)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblItems_tblOrg");
        });

        modelBuilder.Entity<TblItemCategory>(entity =>
        {
            entity.ToTable("tblItemCategory");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171049");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblItemCategories)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblItemCategory_tblOrg");
        });

        modelBuilder.Entity<TblItemVendor>(entity =>
        {
            entity.ToTable("tblItem$Vendor");

            entity.HasIndex(e => new { e.VendorId, e.ItemId, e.OrgId }, "NonClusteredIndex-20170102-171034");

            entity.HasOne(d => d.Item).WithMany(p => p.TblItemVendors)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_tblItem$Vendor_tblItems");

            entity.HasOne(d => d.Org).WithMany(p => p.TblItemVendors)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblItem$Vendor_tblOrg");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TblItemVendors)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_tblItem$Vendor_tblVendor");
        });

        modelBuilder.Entity<TblLeadFollowUp>(entity =>
        {
            entity.ToTable("tblLeadFollowUp");

            entity.Property(e => e.Channel)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Explanation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FollowupTime).HasColumnType("datetime");
            entity.Property(e => e.IsDismissed).HasColumnName("isDismissed");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.AdmissionStatusNavigation).WithMany(p => p.TblLeadFollowUps)
                .HasForeignKey(d => d.AdmissionStatus)
                .HasConstraintName("FK_tblLeadFollowUp_tblAdmissionStatusType");

            entity.HasOne(d => d.AssignToNavigation).WithMany(p => p.TblLeadFollowUpAssignToNavigations)
                .HasForeignKey(d => d.AssignTo)
                .HasConstraintName("FK_tblLeadFollowUp_tblEmployee");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblLeadFollowUpCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblLeadFollowUp_tblEmployee1");

            entity.HasOne(d => d.Org).WithMany(p => p.TblLeadFollowUps)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblLeadFollowUp_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblLeadFollowUps)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLeadFollowUp_tblStudent");
        });

        modelBuilder.Entity<TblLeadStatus>(entity =>
        {
            entity.ToTable("tblLeadStatus");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLearnoMeterCce>(entity =>
        {
            entity.ToTable("tblLearnoMeterCCE");

            entity.HasIndex(e => new { e.TermId, e.OrgId }, "NonClusteredIndex-20170102-171121");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLearnoMeterCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLearnoMeterCCE_tblOrg");

            entity.HasOne(d => d.Term).WithMany(p => p.TblLearnoMeterCces)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLearnoMeterCCE_tblTermCCE");
        });

        modelBuilder.Entity<TblLeaveOnRolewise>(entity =>
        {
            entity.ToTable("tblLeaveOnRolewise");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.TblLeaveOnRolewises)
                .HasForeignKey(d => d.LeaveTypeId)
                .HasConstraintName("FK_tblLeaveOnRolewise_tblLeaveType");
        });

        modelBuilder.Entity<TblLeaveType>(entity =>
        {
            entity.ToTable("tblLeaveType");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLeaveTypes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblLeaveType_tblOrg");
        });

        modelBuilder.Entity<TblLibrary>(entity =>
        {
            entity.ToTable("tblLibrary");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171140");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraries)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblLibrary_tblOrg");
        });

        modelBuilder.Entity<TblLibraryBook>(entity =>
        {
            entity.ToTable("tblLibraryBook");

            entity.HasIndex(e => new { e.LibraryId, e.Category, e.Author, e.Publication, e.Edition, e.Volume, e.OrgId }, "NonClusteredIndex-20170102-171209");

            entity.Property(e => e.BookCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BookPosition)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Isbn)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.PlaceOfPublication).IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PurchaseDate).HasColumnType("date");
            entity.Property(e => e.Series)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShelfNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title).IsUnicode(false);

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.Author)
                .HasConstraintName("FK_tblLibraryBook_tblLibraryBookAuthors");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_tblLibraryBook_tblLibraryBookCategory");

            entity.HasOne(d => d.EditionNavigation).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.Edition)
                .HasConstraintName("FK_tblLibraryBook_tblLibraryBookEdition");

            entity.HasOne(d => d.Library).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.LibraryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLibraryBook_tblLibrary");

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblLibraryBook_tblOrg");

            entity.HasOne(d => d.PublicationNavigation).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.Publication)
                .HasConstraintName("FK_tblLibraryBook_tblLibraryBookPublication");

            entity.HasOne(d => d.VolumeNavigation).WithMany(p => p.TblLibraryBooks)
                .HasForeignKey(d => d.Volume)
                .HasConstraintName("FK_tblLibraryBook_tblLibraryBookVolume");
        });

        modelBuilder.Entity<TblLibraryBookAuthor>(entity =>
        {
            entity.ToTable("tblLibraryBookAuthors");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171236");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBookAuthors)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblLibraryBookAuthors_tblOrg");
        });

        modelBuilder.Entity<TblLibraryBookCategory>(entity =>
        {
            entity.ToTable("tblLibraryBookCategory");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171248");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBookCategories)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLibraryBookCategory_tblOrg");
        });

        modelBuilder.Entity<TblLibraryBookEdition>(entity =>
        {
            entity.ToTable("tblLibraryBookEdition");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171300");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBookEditions)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLibraryBookEdition_tblOrg");
        });

        modelBuilder.Entity<TblLibraryBookLedger>(entity =>
        {
            entity.ToTable("tblLibraryBookLedger");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.ReturnDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.BatchNavigation).WithMany(p => p.TblLibraryBookLedgers)
                .HasForeignKey(d => d.Batch)
                .HasConstraintName("FK_tblLibraryBookLedger_tblBatch");

            entity.HasOne(d => d.Book).WithMany(p => p.TblLibraryBookLedgers)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_tblLibraryBookLedger_tblLibraryBook");

            entity.HasOne(d => d.Course).WithMany(p => p.TblLibraryBookLedgers)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblLibraryBookLedger_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBookLedgers)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblLibraryBookLedger_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblLibraryBookLedgers)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblLibraryBookLedger_tblStudent");
        });

        modelBuilder.Entity<TblLibraryBookPublication>(entity =>
        {
            entity.ToTable("tblLibraryBookPublication");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-171401");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBookPublications)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLibraryBookPublication_tblOrg");
        });

        modelBuilder.Entity<TblLibraryBookVolume>(entity =>
        {
            entity.ToTable("tblLibraryBookVolume");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170102-183641");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLibraryBookVolumes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLibraryBookVolume_tblOrg");
        });

        modelBuilder.Entity<TblLogin>(entity =>
        {
            entity.ToTable("tblLogin");

            entity.HasIndex(e => new { e.UserName, e.Password, e.UserId, e.UserType, e.IsActive, e.OrgId }, "NonClusteredIndex-20161121-224028");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-110554");

            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblLogins)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLogin_tblOrg");
        });

        modelBuilder.Entity<TblLoginUserType>(entity =>
        {
            entity.ToTable("tblLoginUserType");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMarksCardDetail>(entity =>
        {
            entity.ToTable("tblMarksCardDetails");

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblMarksCardDetails)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblMarksCardDetails_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblMarksCardDetails)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblMarksCardDetails_tblCourse");

            entity.HasOne(d => d.Exam).WithMany(p => p.TblMarksCardDetails)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_tblMarksCardDetails_tblExamType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblMarksCardDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblMarksCardDetails_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblMarksCardDetails)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblMarksCardDetails_tblStudent");
        });

        modelBuilder.Entity<TblMasterAccountGroup>(entity =>
        {
            entity.ToTable("tblMasterAccountGroup");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMasterPermissionSet>(entity =>
        {
            entity.ToTable("tblMasterPermissionSet");

            entity.HasIndex(e => e.Value, "IX_tblMasterPermissionSet").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMasterVoucherList>(entity =>
        {
            entity.ToTable("tblMasterVoucherList");

            entity.Property(e => e.VoucherName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMedicineDetail>(entity =>
        {
            entity.ToTable("tblMedicineDetails");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-110642");

            entity.Property(e => e.Company)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblMedicineDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMedicineDetails_tblOrg");
        });

        modelBuilder.Entity<TblMenu>(entity =>
        {
            entity.ToTable("tblMenu");

            entity.HasOne(d => d.Org).WithMany(p => p.TblMenus)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMenu_tblOrg");
        });

        modelBuilder.Entity<TblMessageAttachment>(entity =>
        {
            entity.ToTable("tblMessageAttachments");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-110723");

            entity.HasOne(d => d.From).WithMany(p => p.TblMessageAttachments)
                .HasForeignKey(d => d.FromId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageAttachments_tblMessageCenter");

            entity.HasOne(d => d.Org).WithMany(p => p.TblMessageAttachments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageAttachments_tblOrg");
        });

        modelBuilder.Entity<TblMessageCenter>(entity =>
        {
            entity.ToTable("tblMessageCenter");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-110737");

            entity.Property(e => e.MessageBody).IsUnicode(false);
            entity.Property(e => e.MessageTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SentDate).HasColumnType("datetime");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblMessageCenters)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageCenter_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblMessageCenters)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageCenter_tblOrg");
        });

        modelBuilder.Entity<TblMessageRecipient>(entity =>
        {
            entity.ToTable("tblMessageRecipients");

            entity.HasIndex(e => new { e.FromId, e.ToId, e.OrgId }, "NonClusteredIndex-20170103-110749");

            entity.HasOne(d => d.From).WithMany(p => p.TblMessageRecipients)
                .HasForeignKey(d => d.FromId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageRecipients_tblMessageCenter");

            entity.HasOne(d => d.Org).WithMany(p => p.TblMessageRecipients)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageRecipients_tblOrg");

            entity.HasOne(d => d.To).WithMany(p => p.TblMessageRecipients)
                .HasForeignKey(d => d.ToId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMessageRecipients_tblEmployee");
        });

        modelBuilder.Entity<TblMonthlyBillingDatum>(entity =>
        {
            entity.ToTable("tblMonthlyBillingData");

            entity.HasOne(d => d.ForOrgNavigation).WithMany(p => p.TblMonthlyBillingData)
                .HasForeignKey(d => d.ForOrg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingData_tblOrg");
        });

        modelBuilder.Entity<TblMonthlyBillingDetail>(entity =>
        {
            entity.ToTable("tblMonthlyBillingDetails");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblMonthlyBillingDetails)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingDetails_tblBatch");

            entity.HasOne(d => d.BillingData).WithMany(p => p.TblMonthlyBillingDetails)
                .HasForeignKey(d => d.BillingDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingDetails_tblMonthlyBillingData");

            entity.HasOne(d => d.Course).WithMany(p => p.TblMonthlyBillingDetails)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingDetails_tblCourse");

            entity.HasOne(d => d.Student).WithMany(p => p.TblMonthlyBillingDetails)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingDetails_tblStudent");
        });

        modelBuilder.Entity<TblMonthlyBillingOtherCourseDetail>(entity =>
        {
            entity.ToTable("tblMonthlyBillingOtherCourseDetails");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblMonthlyBillingOtherCourseDetails)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingOtherCourseDetails_tblBatch");

            entity.HasOne(d => d.BillingData).WithMany(p => p.TblMonthlyBillingOtherCourseDetails)
                .HasForeignKey(d => d.BillingDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingOtherCourseDetails_tblMonthlyBillingData");

            entity.HasOne(d => d.Course).WithMany(p => p.TblMonthlyBillingOtherCourseDetails)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingOtherCourseDetails_tblCourse");

            entity.HasOne(d => d.Student).WithMany(p => p.TblMonthlyBillingOtherCourseDetails)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMonthlyBillingOtherCourseDetails_tblStudent");
        });

        modelBuilder.Entity<TblNationality>(entity =>
        {
            entity.ToTable("tblNationality");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-110805");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblNationalities)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblNationality_tblOrg");
        });

        modelBuilder.Entity<TblNewsLetter>(entity =>
        {
            entity.ToTable("tblNewsLetter");

            entity.Property(e => e.Body).IsUnicode(false);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblNewsLetters)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblNewsLetter_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblNewsLetters)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblNewsLetter_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblNewsLetters)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblNewsLetter_tblOrg");
        });

        modelBuilder.Entity<TblOrg>(entity =>
        {
            entity.ToTable("tblOrg");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Gstnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSTNumber");
            entity.Property(e => e.InvoiceEmailIds).IsUnicode(false);
            entity.Property(e => e.InvoiceSmsnumbers)
                .IsUnicode(false)
                .HasColumnName("InvoiceSMSNumbers");
            entity.Property(e => e.OrgFullName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OrgName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sacnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SACNumber");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionEndDate).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionStartDate).HasColumnType("datetime");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Sector).WithMany(p => p.TblOrgs)
                .HasForeignKey(d => d.SectorId)
                .HasConstraintName("FK_tblOrg_tblSector");
        });

        modelBuilder.Entity<TblOtherProgram>(entity =>
        {
            entity.ToTable("tblOtherPrograms");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblOtherPrograms)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblOtherPrograms_tblOrg");
        });

        modelBuilder.Entity<TblOtherProgramsStudent>(entity =>
        {
            entity.ToTable("tblOtherProgramsStudent");

            entity.Property(e => e.IsDisabled).HasColumnName("isDisabled");

            entity.HasOne(d => d.Org).WithMany(p => p.TblOtherProgramsStudents)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblOtherProgramsStudent_tblOrg");

            entity.HasOne(d => d.OtherProgramsNavigation).WithMany(p => p.TblOtherProgramsStudents)
                .HasForeignKey(d => d.OtherPrograms)
                .HasConstraintName("FK_tblOtherProgramsStudent_tblOtherPrograms");

            entity.HasOne(d => d.Student).WithMany(p => p.TblOtherProgramsStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblOtherProgramsStudent_tblStudent");
        });

        modelBuilder.Entity<TblPaatashalaBilling>(entity =>
        {
            entity.ToTable("tblPaatashalaBilling");

            entity.Property(e => e.Year).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPaatashalaBillings)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPaatashalaBilling_tblOrg");
        });

        modelBuilder.Entity<TblPaatashalaBillingDetail>(entity =>
        {
            entity.ToTable("tblPaatashalaBillingDetails");

            entity.HasOne(d => d.ActiveStudent).WithMany(p => p.TblPaatashalaBillingDetailActiveStudents)
                .HasForeignKey(d => d.ActiveStudentId)
                .HasConstraintName("FK_tblPaatashalaBillingDetails_tblStudent1");

            entity.HasOne(d => d.InActiveStudent).WithMany(p => p.TblPaatashalaBillingDetailInActiveStudents)
                .HasForeignKey(d => d.InActiveStudentId)
                .HasConstraintName("FK_tblPaatashalaBillingDetails_tblStudent");

            entity.HasOne(d => d.OtherProgramStudent).WithMany(p => p.TblPaatashalaBillingDetailOtherProgramStudents)
                .HasForeignKey(d => d.OtherProgramStudentId)
                .HasConstraintName("FK_tblPaatashalaBillingDetails_tblStudent2");
        });

        modelBuilder.Entity<TblParentCommunication>(entity =>
        {
            entity.ToTable("tblParentCommunication");

            entity.Property(e => e.DateSent).HasColumnType("datetime");
            entity.Property(e => e.FromParentId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MsgContent).IsUnicode(false);
            entity.Property(e => e.Subject).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblParentCommunications)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblParentCommunication_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblParentCommunications)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblParentCommunication_tblStudent");

            entity.HasOne(d => d.ToEmp).WithMany(p => p.TblParentCommunications)
                .HasForeignKey(d => d.ToEmpId)
                .HasConstraintName("FK_tblParentCommunication_tblEmployee");
        });

        modelBuilder.Entity<TblParentFeedbackDetail>(entity =>
        {
            entity.ToTable("tblParentFeedbackDetails");

            entity.HasOne(d => d.Header).WithMany(p => p.TblParentFeedbackDetails)
                .HasForeignKey(d => d.HeaderId)
                .HasConstraintName("FK_tblParentFeedbackDetails_tblParentFeedbackHeader");

            entity.HasOne(d => d.Question).WithMany(p => p.TblParentFeedbackDetails)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_tblParentFeedbackDetails_tblStudentFeedbackMobileAppQuestions");
        });

        modelBuilder.Entity<TblParentFeedbackHeader>(entity =>
        {
            entity.ToTable("tblParentFeedbackHeader");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblParentFeedbackHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblParentFeedbackHeader_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblParentFeedbackHeaders)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblParentFeedbackHeader_tblStudent");
        });

        modelBuilder.Entity<TblParentMessageBox>(entity =>
        {
            entity.ToTable("tblParentMessageBox");

            entity.Property(e => e.Contents).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Response)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Message).WithMany(p => p.TblParentMessageBoxes)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("FK_tblParentMessageBox_tblAppParentMessageContent");

            entity.HasOne(d => d.Org).WithMany(p => p.TblParentMessageBoxes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblParentMessageBox_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblParentMessageBoxes)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblParentMessageBox_tblStudent");
        });

        modelBuilder.Entity<TblParentMessageOption>(entity =>
        {
            entity.ToTable("tblParentMessage$Options");

            entity.HasOne(d => d.ParentMessageBox).WithMany(p => p.TblParentMessageOptions)
                .HasForeignKey(d => d.ParentMessageBoxId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblParentMessage$Options_tblParentMessageBox");

            entity.HasOne(d => d.ParentMessageOptions).WithMany(p => p.TblParentMessageOptions)
                .HasForeignKey(d => d.ParentMessageOptionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblParentMessage$Options_tblParentMessageOption");
        });

        modelBuilder.Entity<TblParentMessageOption1>(entity =>
        {
            entity.ToTable("tblParentMessageOption");

            entity.Property(e => e.OptionValue)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Message).WithMany(p => p.TblParentMessageOption1s)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("FK_tblParentMessageOption_tblAppParentMessageContent");

            entity.HasOne(d => d.Org).WithMany(p => p.TblParentMessageOption1s)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblParentMessageOption_tblOrg");
        });

        modelBuilder.Entity<TblPayGroup>(entity =>
        {
            entity.ToTable("tblPayGroup");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-110823");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblPayGroups)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPayGroup_tblOrg");
        });

        modelBuilder.Entity<TblPayGroupDetail>(entity =>
        {
            entity.ToTable("tblPayGroupDetails");

            entity.HasIndex(e => new { e.PayGroupId, e.SalaryComponent, e.OrgId }, "NonClusteredIndex-20170103-110836");

            entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPayGroupDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPayGroupDetails_tblOrg");

            entity.HasOne(d => d.PayGroup).WithMany(p => p.TblPayGroupDetails)
                .HasForeignKey(d => d.PayGroupId)
                .HasConstraintName("FK_tblPayGroupDetails_tblPayGroup");

            entity.HasOne(d => d.SalaryComponentNavigation).WithMany(p => p.TblPayGroupDetails)
                .HasForeignKey(d => d.SalaryComponent)
                .HasConstraintName("FK_tblPayGroupDetails_tblEmployeeSalaryComponent");
        });

        modelBuilder.Entity<TblPayroll>(entity =>
        {
            entity.ToTable("tblPayroll");

            entity.HasIndex(e => e.EmpId, "NonClusteredIndex-20170103-110856");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblPayrolls)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPayroll_tblEmployee");
        });

        modelBuilder.Entity<TblPayrollDetail>(entity =>
        {
            entity.ToTable("tblPayrollDetails");

            entity.HasIndex(e => new { e.PayrollId, e.ComponentId, e.OrgId }, "NonClusteredIndex-20170103-110911");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasColumnType("money");

            entity.HasOne(d => d.Component).WithMany(p => p.TblPayrollDetails)
                .HasForeignKey(d => d.ComponentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPayrollDetails_tblEmployeeSalaryComponent");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPayrollDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPayrollDetails_tblOrg");

            entity.HasOne(d => d.Payroll).WithMany(p => p.TblPayrollDetails)
                .HasForeignKey(d => d.PayrollId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPayrollDetails_tblPayroll");
        });

        modelBuilder.Entity<TblPermissionValueDetail>(entity =>
        {
            entity.ToTable("tblPermissionValueDetails");

            entity.HasIndex(e => e.StartValue, "NonClusteredIndex-20161108-221251").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblPettyCashCategory>(entity =>
        {
            entity.ToTable("tblPettyCashCategory");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblPettyCashCategories)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPettyCashCategory_tblOrg");
        });

        modelBuilder.Entity<TblPettyCashDetail>(entity =>
        {
            entity.ToTable("tblPettyCashDetails");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.ExpenseName).IsUnicode(false);
            entity.Property(e => e.GrandTotal).HasColumnType("money");
            entity.Property(e => e.Guid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GUId");
            entity.Property(e => e.Rate).HasColumnType("money");
            entity.Property(e => e.Value).HasColumnType("money");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.TblPettyCashDetails)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_tblPettyCashDetails_tblPettyCashCategory");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPettyCashDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPettyCashDetails_tblOrg");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TblPettyCashDetails)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_tblPettyCashDetails_tblVendor");
        });

        modelBuilder.Entity<TblPettyCashDoc>(entity =>
        {
            entity.ToTable("tblPettyCashDocs");

            entity.Property(e => e.Guid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GUId");
            entity.Property(e => e.PettyCashFileName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblPettyCashDocs)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPettyCashDocs_tblOrg");
        });

        modelBuilder.Entity<TblPettyCashMaster>(entity =>
        {
            entity.ToTable("tblPettyCashMaster");

            entity.Property(e => e.CashSpent).HasColumnType("money");
            entity.Property(e => e.ClosingBalance).HasColumnType("money");
            entity.Property(e => e.FromDate).HasColumnType("date");
            entity.Property(e => e.ToDate).HasColumnType("date");
            entity.Property(e => e.TotalAmount).HasColumnType("money");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPettyCashMasters)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPettyCashMaster_tblOrg");
        });

        modelBuilder.Entity<TblPostDatedPayment>(entity =>
        {
            entity.ToTable("tblPostDatedPayment");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("date");
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PostedDate).HasColumnType("date");
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.SubReceiptNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BankNavigation).WithMany(p => p.TblPostDatedPayments)
                .HasForeignKey(d => d.Bank)
                .HasConstraintName("FK_tblPostDatedPayment_tblBankDetails");

            entity.HasOne(d => d.FeeHeader).WithMany(p => p.TblPostDatedPayments)
                .HasForeignKey(d => d.FeeHeaderId)
                .HasConstraintName("FK_tblPostDatedPayment_tblStudentFeePaidHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPostDatedPayments)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPostDatedPayment_tblOrg");

            entity.HasOne(d => d.PaidForPeriodNavigation).WithMany(p => p.TblPostDatedPayments)
                .HasForeignKey(d => d.PaidForPeriod)
                .HasConstraintName("FK_tblPostDatedPayment_tblFeeDescription");

            entity.HasOne(d => d.PaymentModeNavigation).WithMany(p => p.TblPostDatedPayments)
                .HasForeignKey(d => d.PaymentMode)
                .HasConstraintName("FK_tblPostDatedPayment_tblFeePaymentMode");

            entity.HasOne(d => d.Student).WithMany(p => p.TblPostDatedPayments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblPostDatedPayment_tblStudent");
        });

        modelBuilder.Entity<TblPrincipalMonthlyReport>(entity =>
        {
            entity.ToTable("tblPrincipalMonthlyReport");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPrincipalMonthlyReports)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblPrincipalMonthlyReport_tblOrg");

            entity.HasOne(d => d.Principal).WithMany(p => p.TblPrincipalMonthlyReports)
                .HasForeignKey(d => d.PrincipalId)
                .HasConstraintName("FK_tblPrincipalMonthlyReport_tblEmployee");
        });

        modelBuilder.Entity<TblProformaInvoiceDetail>(entity =>
        {
            entity.ToTable("tblProforma_InvoiceDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<TblProformaInvoiceHeader>(entity =>
        {
            entity.ToTable("tblProforma_InvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate)
                .HasColumnType("date")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.TinOrCst).HasColumnName("TinOrCST");
        });

        modelBuilder.Entity<TblProformaServiceInvoiceDetail>(entity =>
        {
            entity.ToTable("tblProforma_ServiceInvoiceDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<TblProformaServiceInvoiceHeader>(entity =>
        {
            entity.ToTable("tblProforma_ServiceInvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate)
                .HasColumnType("date")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.TinOrCst).HasColumnName("TinOrCST");
        });

        modelBuilder.Entity<TblProformaTaxInvoiceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProforma_TaxInvoiceDetail");
        });

        modelBuilder.Entity<TblProformaTaxInvoiceHeader>(entity =>
        {
            entity.ToTable("tblProforma_TaxInvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate).HasColumnName("PODate");
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.TinOrCst).HasColumnName("TinOrCST");
        });

        modelBuilder.Entity<TblPurchaseOrderDetail>(entity =>
        {
            entity.ToTable("tblPurchaseOrderDetail");

            entity.HasIndex(e => new { e.HeaderId, e.ItemCode, e.Item, e.OrgId }, "NonClusteredIndex-20170103-110956");

            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PricePerUnit).HasColumnType("money");
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Header).WithMany(p => p.TblPurchaseOrderDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPurchaseOrderDetail_tblPurchaseOrderHeader");

            entity.HasOne(d => d.ItemNavigation).WithMany(p => p.TblPurchaseOrderDetails)
                .HasForeignKey(d => d.Item)
                .HasConstraintName("FK_tblPurchaseOrderDetail_tblStockItem");

            entity.HasOne(d => d.ItemCodeNavigation).WithMany(p => p.TblPurchaseOrderDetails)
                .HasForeignKey(d => d.ItemCode)
                .HasConstraintName("FK_tblPurchaseOrderDetail_tblStockGroup");

            entity.HasOne(d => d.Org).WithMany(p => p.TblPurchaseOrderDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPurchaseOrderDetail_tblOrg");
        });

        modelBuilder.Entity<TblPurchaseOrderHeader>(entity =>
        {
            entity.ToTable("tblPurchaseOrderHeader");

            entity.HasIndex(e => new { e.VendorId, e.OrgId }, "NonClusteredIndex-20170103-111016");

            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.OrderDate).HasColumnType("date");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PONumber");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.VendorAddress).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblPurchaseOrderHeaders)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPurchaseOrderHeader_tblOrg");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TblPurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPurchaseOrderHeader_tblVendor");
        });

        modelBuilder.Entity<TblQuestionBank>(entity =>
        {
            entity.HasKey(e => e.QbankId);

            entity.ToTable("tblQuestionBank");

            entity.HasIndex(e => new { e.TopicId, e.OrgId }, "NonClusteredIndex-20170103-111032");

            entity.Property(e => e.QbankId).HasColumnName("QBankId");
            entity.Property(e => e.AnswerHtml)
                .IsUnicode(false)
                .HasColumnName("AnswerHTML");
            entity.Property(e => e.QuestionHtml)
                .IsUnicode(false)
                .HasColumnName("QuestionHTML");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblQuestionBanks)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblQuestionBank_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblQuestionBanks)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblQuestionBank_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblQuestionBanks)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblQuestionBank_tblOrg");

            entity.HasOne(d => d.Topic).WithMany(p => p.TblQuestionBanks)
                .HasForeignKey(d => d.TopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblQuestionBank_tblTopic");
        });

        modelBuilder.Entity<TblReportCategory>(entity =>
        {
            entity.ToTable("tblReportCategory");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblReportSentDetail>(entity =>
        {
            entity.ToTable("tblReportSentDetails");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.TblReportSentDetails)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_tblReportSentDetails_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblReportSentDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblReportSentDetails_tblOrg");

            entity.HasOne(d => d.ReportCategory).WithMany(p => p.TblReportSentDetails)
                .HasForeignKey(d => d.ReportCategoryId)
                .HasConstraintName("FK_tblReportSentDetails_tblReportCategory");

            entity.HasOne(d => d.Student).WithMany(p => p.TblReportSentDetails)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblReportSentDetails_tblStudent");
        });

        modelBuilder.Entity<TblRetailInvoiceDetail>(entity =>
        {
            entity.ToTable("tblRetail_InvoiceDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<TblRetailInvoiceHeader>(entity =>
        {
            entity.ToTable("tblRetail_InvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate)
                .HasColumnType("date")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.TinOrCst).HasColumnName("TinOrCST");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.ToTable("tblRole");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-111055");

            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblRoles)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRole_tblOrg");
        });

        modelBuilder.Entity<TblRolePermission>(entity =>
        {
            entity.ToTable("tblRolePermission");

            entity.HasIndex(e => new { e.MasterPermissionValue, e.RoleId, e.OrgId }, "NonClusteredIndex-20170103-111108");

            entity.HasOne(d => d.MasterPermissionValueNavigation).WithMany(p => p.TblRolePermissions)
                .HasPrincipalKey(p => p.Value)
                .HasForeignKey(d => d.MasterPermissionValue)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRolePermission_tblMasterPermissionSet");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRolePermissions)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRolePermission_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblRolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRolePermission_tblRole");
        });

        modelBuilder.Entity<TblRoleWidget>(entity =>
        {
            entity.ToTable("tblRoleWidget");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRoleWidgets)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoleWidget_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblRoleWidgets)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblRoleWidget_tblRole");

            entity.HasOne(d => d.Widget).WithMany(p => p.TblRoleWidgets)
                .HasForeignKey(d => d.WidgetId)
                .HasConstraintName("FK_tblRoleWidget_tblWidget");
        });

        modelBuilder.Entity<TblRoute>(entity =>
        {
            entity.ToTable("tblRoute");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-111124");

            entity.Property(e => e.RouteCode).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblRoutes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblRoute_tblOrg");
        });

        modelBuilder.Entity<TblRouteStop>(entity =>
        {
            entity.ToTable("tblRoute$Stops");

            entity.HasIndex(e => new { e.RouteId, e.StopId, e.OrgId }, "NonClusteredIndex-20170103-111140");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRouteStops)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoute$Stops_tblOrg");

            entity.HasOne(d => d.Route).WithMany(p => p.TblRouteStops)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoute$Stops_tblRoute");

            entity.HasOne(d => d.Stop).WithMany(p => p.TblRouteStops)
                .HasForeignKey(d => d.StopId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoute$Stops_tblRouteStops");
        });

        modelBuilder.Entity<TblRouteStop1>(entity =>
        {
            entity.ToTable("tblRouteStops");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-111230");

            entity.Property(e => e.StopName).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblRouteStop1s)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblRouteStops_tblOrg");
        });

        modelBuilder.Entity<TblRouteVehicle>(entity =>
        {
            entity.ToTable("tblRoute$Vehicle");

            entity.HasIndex(e => new { e.RouteId, e.VehicleId, e.DriverId, e.OrgId }, "NonClusteredIndex-20170103-111203");

            entity.HasOne(d => d.Driver).WithMany(p => p.TblRouteVehicles)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("FK_tblRoute$Vehicle_tblDriver");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRouteVehicles)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblRoute$Vehicle_tblOrg");

            entity.HasOne(d => d.Route).WithMany(p => p.TblRouteVehicles)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK_tblRoute$Vehicle_tblRoute");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.TblRouteVehicles)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("FK_tblRoute$Vehicle_tblVehicle");
        });

        modelBuilder.Entity<TblRoyaltyFeeCollection>(entity =>
        {
            entity.ToTable("tblRoyaltyFeeCollection");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Week)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.FranchiseDetails).WithMany(p => p.TblRoyaltyFeeCollections)
                .HasForeignKey(d => d.FranchiseDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoyaltyFeeCollection_tblFranchiseDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRoyaltyFeeCollections)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRoyaltyFeeCollection_tblOrg");
        });

        modelBuilder.Entity<TblRubricsConfiguration>(entity =>
        {
            entity.ToTable("tblRubricsConfiguration");

            entity.Property(e => e.ActorgId).HasColumnName("ACTOrgId");

            entity.HasOne(d => d.Actorg).WithMany(p => p.TblRubricsConfigurationActorgs)
                .HasForeignKey(d => d.ActorgId)
                .HasConstraintName("FK_tblRubricsConfiguration_tblOrg1");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRubricsConfigurationOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblRubricsConfiguration_tblOrg");

            entity.HasOne(d => d.Rubrics).WithMany(p => p.TblRubricsConfigurations)
                .HasForeignKey(d => d.RubricsId)
                .HasConstraintName("FK_tblRubricsConfiguration_tblIndicatorGroup");
        });

        modelBuilder.Entity<TblRubricsRoleConfiguration>(entity =>
        {
            entity.ToTable("tblRubricsRoleConfiguration");

            entity.HasOne(d => d.Org).WithMany(p => p.TblRubricsRoleConfigurationOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblRubricsRoleConfiguration_tblOrg1");

            entity.HasOne(d => d.Role).WithMany(p => p.TblRubricsRoleConfigurations)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblRubricsRoleConfiguration_tblRole");

            entity.HasOne(d => d.RoleOrg).WithMany(p => p.TblRubricsRoleConfigurationRoleOrgs)
                .HasForeignKey(d => d.RoleOrgId)
                .HasConstraintName("FK_tblRubricsRoleConfiguration_tblOrg");

            entity.HasOne(d => d.RubricsHeader).WithMany(p => p.TblRubricsRoleConfigurations)
                .HasForeignKey(d => d.RubricsHeaderId)
                .HasConstraintName("FK_tblRubricsRoleConfiguration_tblIndicatorGroup");
        });

        modelBuilder.Entity<TblSector>(entity =>
        {
            entity.ToTable("tblSector");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSectors)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSector_tblOrg");
        });

        modelBuilder.Entity<TblServiceInvoiceDetail>(entity =>
        {
            entity.ToTable("tblService_InvoiceDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<TblServiceInvoiceHeader>(entity =>
        {
            entity.ToTable("tblService_InvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate)
                .HasColumnType("date")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PONumber");
            entity.Property(e => e.TinOrCst)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TinOrCST");
            entity.Property(e => e.Total).HasColumnType("money");
        });

        modelBuilder.Entity<TblSmsLog>(entity =>
        {
            entity.ToTable("tblSmsLog");

            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSmsLogs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblSmsLog_tblOrg");

            entity.HasOne(d => d.User).WithMany(p => p.TblSmsLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblSmsLog_tblEmployee");
        });

        modelBuilder.Entity<TblSmscredential>(entity =>
        {
            entity.ToTable("tblSMSCredentials");

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SenderId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSmscredentials)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblSMSCredentials_tblOrg");
        });

        modelBuilder.Entity<TblSmstemplate>(entity =>
        {
            entity.ToTable("tblSMSTemplate");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Smscontent).HasColumnName("SMSContent");

            entity.HasOne(d => d.Org).WithMany(p => p.TblSmstemplates)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblSMSTemplate_tblOrg");
        });

        modelBuilder.Entity<TblSsgarchiveClientPayment>(entity =>
        {
            entity.ToTable("tblSSGArchiveClientPayment");

            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Paid).HasColumnType("money");
            entity.Property(e => e.PaidOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ClientPaymentDetail).WithMany(p => p.TblSsgarchiveClientPayments)
                .HasForeignKey(d => d.ClientPaymentDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSSGArchiveClientPayment_tblSSGClientPaymentDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblSsgarchiveClientPayments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSSGArchiveClientPayment_tblOrg");
        });

        modelBuilder.Entity<TblSsgbillingDetail>(entity =>
        {
            entity.ToTable("tblSSGBillingDetails");

            entity.Property(e => e.Cgst)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CGST");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.EmployeeLoginAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FlateRateAmount).HasColumnType("money");
            entity.Property(e => e.NormalCourseBillingRate).HasColumnType("money");
            entity.Property(e => e.OtherCourseBillingRate).HasColumnType("money");
            entity.Property(e => e.ParentLoginAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sgst)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SGST");
            entity.Property(e => e.TermsAndConditions)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSsgbillingDetails)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblSSGBillingDetails_tblOrg");
        });

        modelBuilder.Entity<TblSsgclientPaymentDetail>(entity =>
        {
            entity.ToTable("tblSSGClientPaymentDetails");

            entity.Property(e => e.AmountReceived).HasColumnType("money");
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.InvoiceData).IsUnicode(false);
            entity.Property(e => e.InvoiceGeneratedOn).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Year).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblSsgclientPaymentDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSSGClientPaymentDetails_tblOrg");
        });

        modelBuilder.Entity<TblSsgemployee>(entity =>
        {
            entity.ToTable("tblSSGEmployee");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DateOfJoining).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).IsUnicode(false);
            entity.Property(e => e.LastName).IsUnicode(false);
            entity.Property(e => e.MiddleName).IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.TblSsgemployees)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblSSGEmployee_tblSSGRole");
        });

        modelBuilder.Entity<TblSsgrole>(entity =>
        {
            entity.ToTable("tblSSGRole");

            entity.Property(e => e.RoleDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblStockGroup>(entity =>
        {
            entity.ToTable("tblStockGroup");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-111250");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStockGroups)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStockGroup_tblOrg");
        });

        modelBuilder.Entity<TblStockItem>(entity =>
        {
            entity.ToTable("tblStockItem");

            entity.HasIndex(e => new { e.UnitOfMeasure, e.StockGroup, e.OrgId }, "NonClusteredIndex-20170103-111314");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OpeningStock).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStockItems)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStockItem_tblOrg");

            entity.HasOne(d => d.StockGroupNavigation).WithMany(p => p.TblStockItems)
                .HasForeignKey(d => d.StockGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStockItem_tblStockGroup");

            entity.HasOne(d => d.UnitOfMeasureNavigation).WithMany(p => p.TblStockItems)
                .HasForeignKey(d => d.UnitOfMeasure)
                .HasConstraintName("FK_tblStockItem_tblUnitOfMeasure");
        });

        modelBuilder.Entity<TblStockItemDeliveryDetail>(entity =>
        {
            entity.ToTable("tblStockItemDeliveryDetails");

            entity.HasOne(d => d.DeliveryHeader).WithMany(p => p.TblStockItemDeliveryDetails)
                .HasForeignKey(d => d.DeliveryHeaderId)
                .HasConstraintName("FK_tblStockItemDeliveryDetails_tblStockItemsDeliveryHeader");

            entity.HasOne(d => d.StockItem).WithMany(p => p.TblStockItemDeliveryDetails)
                .HasForeignKey(d => d.StockItemId)
                .HasConstraintName("FK_tblStockItemDeliveryDetails_tblStockItem");
        });

        modelBuilder.Entity<TblStockItemsDeliveryHeader>(entity =>
        {
            entity.ToTable("tblStockItemsDeliveryHeader");

            entity.Property(e => e.DeliveryDate).HasColumnType("date");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblStockItemsDeliveryHeaders)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblStockItemsDeliveryHeader_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblStockItemsDeliveryHeaders)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblStockItemsDeliveryHeader_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStockItemsDeliveryHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblStockItemsDeliveryHeader_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblStockItemsDeliveryHeaders)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblStockItemsDeliveryHeader_tblRole");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStockItemsDeliveryHeaders)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblStockItemsDeliveryHeader_tblStudent");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblStockItemsDeliveryHeaders)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblStockItemsDeliveryHeader_tblEmployee");
        });

        modelBuilder.Entity<TblStream>(entity =>
        {
            entity.ToTable("tblStream");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-111334");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStreams)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStream_tblOrg");
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.ToTable("tblStudent");

            entity.HasIndex(e => new { e.Category, e.DiscountType, e.OrgId }, "NonClusteredIndex-20170103-112747");

            entity.Property(e => e.AadharNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Age).HasMaxLength(50);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentAddress).IsUnicode(false);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.EmergencyContactPerson)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyContactRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherDob)
                .HasColumnType("date")
                .HasColumnName("FatherDOB");
            entity.Property(e => e.FatherEmail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FatherIncome).HasColumnType("money");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherQualification)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FatherTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsConvictedReason).IsUnicode(false);
            entity.Property(e => e.IsPriorExpelledReason).IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadCreationDate).HasColumnType("date");
            entity.Property(e => e.LeadRejectReason).IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherDob)
                .HasColumnType("date")
                .HasColumnName("MotherDOB");
            entity.Property(e => e.MotherEmail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherQualification)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MotherTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentsAnniversary).HasColumnType("date");
            entity.Property(e => e.PassportNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stsnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STSNumber");
            entity.Property(e => e.StudentId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tcissued).HasColumnName("TCIssued");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.TblStudents)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_tblStudent_tblStudentCategory");

            entity.HasOne(d => d.DiscountTypeNavigation).WithMany(p => p.TblStudents)
                .HasForeignKey(d => d.DiscountType)
                .HasConstraintName("FK_tblStudent_tblDiscountType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudents)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudent_tblOrg");
        });

        modelBuilder.Entity<TblStudentActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblStudentActivity_1");

            entity.ToTable("tblStudentActivity");

            entity.Property(e => e.ActivityDate).HasColumnType("date");
            entity.Property(e => e.ActivityTime).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.HowMuch).IsUnicode(false);
            entity.Property(e => e.WhatActivity).IsUnicode(false);

            entity.HasOne(d => d.ActivityType).WithMany(p => p.TblStudentActivities)
                .HasForeignKey(d => d.ActivityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentActivity_tblStudentActivityType");

            entity.HasOne(d => d.Batch).WithMany(p => p.TblStudentActivities)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentActivity_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblStudentActivities)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentActivity_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentActivities)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentActivity_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentActivities)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentActivity_tblStudent");
        });

        modelBuilder.Entity<TblStudentActivityType>(entity =>
        {
            entity.ToTable("tblStudentActivityType");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentActivityTypes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentActivityType_tblOrg");
        });

        modelBuilder.Entity<TblStudentAttachment>(entity =>
        {
            entity.ToTable("tblStudentAttachment");

            entity.HasIndex(e => new { e.StudentId, e.OrgId }, "NonClusteredIndex-20170103-112816");

            entity.Property(e => e.FileName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentAttachments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentAttachment_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentAttachments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentAttachment_tblStudent");
        });

        modelBuilder.Entity<TblStudentCategory>(entity =>
        {
            entity.ToTable("tblStudentCategory");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-112829");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentCategories)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentCategory_tblOrg");
        });

        modelBuilder.Entity<TblStudentCourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblStudent$Course");
        });

        modelBuilder.Entity<TblStudentCustomize>(entity =>
        {
            entity.ToTable("tblStudentCustomize");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-112844");

            entity.Property(e => e.FieldName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FieldType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentCustomizes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentCustomize_tblOrg");
        });

        modelBuilder.Entity<TblStudentCustomizeValue>(entity =>
        {
            entity.ToTable("tblStudentCustomizeValues");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-112856");

            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentCustomizeValues)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentCustomizeValues_tblOrg");
        });

        modelBuilder.Entity<TblStudentDiary>(entity =>
        {
            entity
                .ToTable("tblStudentDiary");

            entity.Property(e => e.DateWritten).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Batch).WithMany()
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentDairy_tblBatch");

            entity.HasOne(d => d.Course).WithMany()
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentDairy_tblCourse");

            entity.HasOne(d => d.Org).WithMany()
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentDairy_tblOrg");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentDairy_tblStudent");
        });

        modelBuilder.Entity<TblStudentFeePaidHeader>(entity =>
        {
            entity.ToTable("tblStudentFeePaidHeader");

            entity.HasIndex(e => new { e.StudentId, e.DatePaid, e.PaidForPeriod, e.Course, e.Batch, e.GrandTotal, e.OrgId }, "NonClusteredIndex-20161121-224436");

            entity.HasIndex(e => new { e.StudentId, e.Bank, e.OrgId }, "NonClusteredIndex-20170103-112908");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.DatePaid).HasColumnType("date");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.GrandTotal).HasColumnType("money");
            entity.Property(e => e.IsBilling).HasColumnName("isBilling");
            entity.Property(e => e.Narration)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PaidForPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDetails)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BankNavigation).WithMany(p => p.TblStudentFeePaidHeaders)
                .HasForeignKey(d => d.Bank)
                .HasConstraintName("FK_tblStudentFeePaidHeader_tblBankDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentFeePaidHeaders)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeePaidHeader_tblOrg");

            entity.HasOne(d => d.PaidForPeriodLinkedNavigation).WithMany(p => p.TblStudentFeePaidHeaders)
                .HasForeignKey(d => d.PaidForPeriodLinked)
                .HasConstraintName("FK_tblStudentFeePaidHeader_tblFeeDescription");

            entity.HasOne(d => d.PaymentModeNavigation).WithMany(p => p.TblStudentFeePaidHeaders)
                .HasForeignKey(d => d.PaymentMode)
                .HasConstraintName("FK_tblStudentFeePaidHeader_tblFeePaymentMode");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentFeePaidHeaders)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeePaidHeader_tblStudent");
        });

        modelBuilder.Entity<TblStudentFeedbackDetail>(entity =>
        {
            entity.ToTable("tblStudentFeedbackDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentFeedbackDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackDetails_tblOrg");

            entity.HasOne(d => d.Questionnaire).WithMany(p => p.TblStudentFeedbackDetails)
                .HasForeignKey(d => d.QuestionnaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackDetails_tblStudentFeedbackQuestionnaire");

            entity.HasOne(d => d.StudentFeedback).WithMany(p => p.TblStudentFeedbackDetails)
                .HasForeignKey(d => d.StudentFeedbackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackDetails_tblStudentFeedbackMain");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblStudentFeedbackDetails)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblStudentFeedbackDetails_tblSubjects");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TblStudentFeedbackDetails)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_tblStudentFeedbackDetails_tblEmployee");
        });

        modelBuilder.Entity<TblStudentFeedbackMain>(entity =>
        {
            entity.ToTable("tblStudentFeedbackMain");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Section).IsUnicode(false);
            entity.Property(e => e.Term).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblStudentFeedbackMains)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackMain_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblStudentFeedbackMains)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackMain_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentFeedbackMains)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackMain_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentFeedbackMains)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentFeedbackMain_tblStudent");
        });

        modelBuilder.Entity<TblStudentFeedbackMobileAppQuestion>(entity =>
        {
            entity.ToTable("tblStudentFeedbackMobileAppQuestions");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Question).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentFeedbackMobileAppQuestions)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblStudentFeedbackMobileAppQuestions_tblOrg");

            entity.HasOne(d => d.Role).WithMany(p => p.TblStudentFeedbackMobileAppQuestions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblStudentFeedbackMobileAppQuestions_tblRole");
        });

        modelBuilder.Entity<TblStudentFeedbackQuestionnaire>(entity =>
        {
            entity.ToTable("tblStudentFeedbackQuestionnaire");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Question).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentFeedbackQuestionnaires)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblStudentFeedbackQuestionnaire_tblOrg");
        });

        modelBuilder.Entity<TblStudentKit>(entity =>
        {
            entity.ToTable("tblStudentKit");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CourseNavigation).WithMany(p => p.TblStudentKits)
                .HasForeignKey(d => d.Course)
                .HasConstraintName("FK_tblStudentKit_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentKits)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblStudentKit_tblOrg");
        });

        modelBuilder.Entity<TblStudentKitItem>(entity =>
        {
            entity.ToTable("tblStudentKitItems");

            entity.HasOne(d => d.ItemNavigation).WithMany(p => p.TblStudentKitItems)
                .HasForeignKey(d => d.Item)
                .HasConstraintName("FK_tblStudentKitItems_tblStockItem");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentKitItems)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblStudentKitItems_tblOrg");

            entity.HasOne(d => d.StudentKit).WithMany(p => p.TblStudentKitItems)
                .HasForeignKey(d => d.StudentKitId)
                .HasConstraintName("FK_tblStudentKitItems_tblStudentKit");
        });

        modelBuilder.Entity<TblStudentMedicine>(entity =>
        {
            entity.ToTable("tblStudentMedicine");

            entity.HasIndex(e => new { e.MedicineId, e.OrgId }, "NonClusteredIndex-20170103-112924");

            entity.Property(e => e.AdministeredDate).HasColumnType("datetime");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");

            entity.HasOne(d => d.Medicine).WithMany(p => p.TblStudentMedicines)
                .HasForeignKey(d => d.MedicineId)
                .HasConstraintName("FK_tblStudentMedicine_tblMedicineDetails");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentMedicines)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentMedicine_tblOrg");
        });

        modelBuilder.Entity<TblStudentPrevQualificationReason>(entity =>
        {
            entity.ToTable("tblStudentPrevQualificationReason");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-112939");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentPrevQualificationReasons)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentPrevQualificationReason_tblOrg");
        });

        modelBuilder.Entity<TblStudentQualification>(entity =>
        {
            entity.ToTable("tblStudentQualifications");

            entity.HasIndex(e => new { e.StudentId, e.OrgId }, "NonClusteredIndex-20170103-112951");

            entity.Property(e => e.ClassOrCourse).IsUnicode(false);
            entity.Property(e => e.SchoolName).IsUnicode(false);
            entity.Property(e => e.YearPassed).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentQualifications)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentQualifications_tblOrg");

            entity.HasOne(d => d.ReasonForExitNavigation).WithMany(p => p.TblStudentQualifications)
                .HasForeignKey(d => d.ReasonForExit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentQualifications_tblStudentPrevQualificationReason");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentQualifications)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblStudentQualifications_tblStudent");
        });

        modelBuilder.Entity<TblStudentRegistration>(entity =>
        {
            entity.ToTable("tblStudentRegistration");

            entity.HasIndex(e => new { e.StudentId, e.AdmissionStatus, e.OrgId }, "NonClusteredIndex-20170103-113005");

            entity.Property(e => e.LeadNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate).HasColumnType("date");
            entity.Property(e => e.Section)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.AdmissionStatusNavigation).WithMany(p => p.TblStudentRegistrations)
                .HasForeignKey(d => d.AdmissionStatus)
                .HasConstraintName("FK_tblStudentRegistration_tblAdmissionStatusType");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentRegistrations)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentRegistration_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentRegistrations)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_tblStudentRegistration_tblStudent");
        });

        modelBuilder.Entity<TblStudentResultsCce>(entity =>
        {
            entity.ToTable("tblStudentResultsCCE");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113031");

            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Said).HasColumnName("SAId");

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentResultsCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentResultsCCE_tblOrg");
        });

        modelBuilder.Entity<TblStudentValue>(entity =>
        {
            entity.ToTable("tblStudentValues");

            entity.HasIndex(e => new { e.StudentId, e.OrgId }, "NonClusteredIndex-20170103-113043");

            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblStudentValues)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentValues_tblOrg");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentValues)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStudentValues_tblStudent");
        });

        modelBuilder.Entity<TblSubBlockCce>(entity =>
        {
            entity.ToTable("tblSubBlockCCE");

            entity.HasIndex(e => new { e.BlockId, e.OrgId }, "NonClusteredIndex-20170103-113058");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Block).WithMany(p => p.TblSubBlockCces)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSubBlockCCE_tblBlockCCE");

            entity.HasOne(d => d.Org).WithMany(p => p.TblSubBlockCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSubBlockCCE_tblOrg");
        });

        modelBuilder.Entity<TblSubCaste>(entity =>
        {
            entity.ToTable("tblSubCaste");

            entity.HasIndex(e => new { e.ParentCaste, e.OrgId }, "NonClusteredIndex-20170103-113112");

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSubCastes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSubCaste_tblOrg");

            entity.HasOne(d => d.ParentCasteNavigation).WithMany(p => p.TblSubCastes)
                .HasForeignKey(d => d.ParentCaste)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSubCaste_tblCaste");
        });

        modelBuilder.Entity<TblSubComponentAttribute>(entity =>
        {
            entity.ToTable("tblSubComponentAttributes");

            entity.Property(e => e.AttributeName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSubComponentAttributes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblSubComponentAttributes_tblOrg");

            entity.HasOne(d => d.SubComp).WithMany(p => p.TblSubComponentAttributes)
                .HasForeignKey(d => d.SubCompId)
                .HasConstraintName("FK_tblSubComponentAttributes_tblSubjectSubComponents");
        });

        modelBuilder.Entity<TblSubject>(entity =>
        {
            entity.ToTable("tblSubjects");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113148");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSubjects)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSubjects_tblOrg");
        });

        modelBuilder.Entity<TblSubjectSubComponent>(entity =>
        {
            entity.ToTable("tblSubjectSubComponents");

            entity.Property(e => e.SubComponentName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSubjectSubComponents)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblSubjectSubComponents_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblSubjectSubComponents)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_tblSubjectSubComponents_tblSubjects");
        });

        modelBuilder.Entity<TblSummativeAssessmentCce>(entity =>
        {
            entity.ToTable("tblSummativeAssessmentCCE");

            entity.HasIndex(e => new { e.TermId, e.OrgId }, "NonClusteredIndex-20170103-113202");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblSummativeAssessmentCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSummativeAssessmentCCE_tblOrg");

            entity.HasOne(d => d.Term).WithMany(p => p.TblSummativeAssessmentCces)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSummativeAssessmentCCE_tblTermCCE");
        });

        modelBuilder.Entity<TblTaxDetail>(entity =>
        {
            entity.ToTable("tblTaxDetails");

            entity.HasIndex(e => new { e.TaxTypeId, e.OrgId }, "NonClusteredIndex-20170103-113223");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblTaxDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTaxDetails_tblOrg");

            entity.HasOne(d => d.TaxType).WithMany(p => p.TblTaxDetails)
                .HasForeignKey(d => d.TaxTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTaxDetails_tblTaxType");
        });

        modelBuilder.Entity<TblTaxInvoiceDetail>(entity =>
        {
            entity.ToTable("tblTax_InvoiceDetail");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DiscountAmount).HasColumnType("money");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<TblTaxInvoiceHeader>(entity =>
        {
            entity.ToTable("tblTax_InvoiceHeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.Podate)
                .HasColumnType("date")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PONumber");
        });

        modelBuilder.Entity<TblTaxType>(entity =>
        {
            entity.ToTable("tblTaxType");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113236");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTaxTypes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTaxType_tblOrg");
        });

        modelBuilder.Entity<TblTerm>(entity =>
        {
            entity.ToTable("tblTerm");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TermName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblTerms)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblTerm_tblOrg");
        });

        modelBuilder.Entity<TblTermCce>(entity =>
        {
            entity.ToTable("tblTermCCE");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113249");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblTermCces)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTermCCE_tblOrg");
        });

        modelBuilder.Entity<TblThemeAol>(entity =>
        {
            entity.ToTable("tblThemeAOL");

            entity.Property(e => e.Aol).HasColumnName("AOL");
            entity.Property(e => e.Name).IsUnicode(false);

            entity.HasOne(d => d.AolNavigation).WithMany(p => p.TblThemeAols)
                .HasForeignKey(d => d.Aol)
                .HasConstraintName("FK_tblThemeAOL_tblAreaOfLearning");

            entity.HasOne(d => d.Org).WithMany(p => p.TblThemeAols)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblThemeAOL_tblOrg");
        });

        modelBuilder.Entity<TblTimeTable>(entity =>
        {
            entity.ToTable("tblTimeTable");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113301");

            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ClassTeacher).WithMany(p => p.TblTimeTables)
                .HasForeignKey(d => d.ClassTeacherId)
                .HasConstraintName("FK_tblTimeTable_tblOrg");
        });

        modelBuilder.Entity<TblTimeTableDetail>(entity =>
        {
            entity.ToTable("tblTimeTableDetails");

            entity.HasIndex(e => new { e.TimeTableId, e.OrgId }, "NonClusteredIndex-20170103-113327");

            entity.Property(e => e.EndTime).HasColumnName("EndTIme");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTimeTableDetails)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTimeTableDetails_tblOrg");

            entity.HasOne(d => d.Photo).WithMany(p => p.TblTimeTableDetails)
                .HasForeignKey(d => d.PhotoId)
                .HasConstraintName("FK_tblTimeTableDetails_tblVisualTimeTablePhotoType");

            entity.HasOne(d => d.TimeTable).WithMany(p => p.TblTimeTableDetails)
                .HasForeignKey(d => d.TimeTableId)
                .HasConstraintName("FK_tblTimeTableDetails_tblTimeTable");
        });

        modelBuilder.Entity<TblTimetableWorkingDay>(entity =>
        {
            entity.ToTable("tblTimetable_workingDays");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113313");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTimetableWorkingDays)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTimetable_workingDays_tblOrg");
        });

        modelBuilder.Entity<TblTopic>(entity =>
        {
            entity.HasKey(e => e.TopicId);

            entity.ToTable("tblTopic");

            entity.HasIndex(e => new { e.SubjectId, e.OrgId }, "NonClusteredIndex-20170103-113343");

            entity.Property(e => e.TopicName).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblTopics)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblTopic_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblTopics)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblTopic_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTopics)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTopic_tblOrg");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblTopics)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTopic_tblSubjects");
        });

        modelBuilder.Entity<TblTrainingAttendance>(entity =>
        {
            entity.ToTable("tblTrainingAttendance");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblTrainingAttendances)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTrainingAttendance_tblEmployee");

            entity.HasOne(d => d.TrainingHeader).WithMany(p => p.TblTrainingAttendances)
                .HasForeignKey(d => d.TrainingHeaderId)
                .HasConstraintName("FK_tblTrainingAttendance_tblTrainingHeader");
        });

        modelBuilder.Entity<TblTrainingFeedbackQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblFeedbackTrainingQuestion");

            entity.ToTable("tblTrainingFeedbackQuestion");

            entity.Property(e => e.Question).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblTrainingFeedbackQuestions)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblFeedbackTrainingQuestion_tblOrg");
        });

        modelBuilder.Entity<TblTrainingHeader>(entity =>
        {
            entity.ToTable("tblTrainingHeader");

            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTrainingReportReview>(entity =>
        {
            entity.ToTable("tblTrainingReportReview");

            entity.Property(e => e.Annexure).IsUnicode(false);
            entity.Property(e => e.FindUsefulAndInteresting).IsUnicode(false);
            entity.Property(e => e.GroupDynamics).IsUnicode(false);
            entity.Property(e => e.Implementation).IsUnicode(false);
            entity.Property(e => e.Introduction).IsUnicode(false);
            entity.Property(e => e.IrrelavantOrNotMuchUseful).IsUnicode(false);
            entity.Property(e => e.KeyLearningFromProgramme).IsUnicode(false);
            entity.Property(e => e.Methodology).IsUnicode(false);
            entity.Property(e => e.Objective).IsUnicode(false);
            entity.Property(e => e.Reflection).IsUnicode(false);
            entity.Property(e => e.SuggestionsForImprovements).IsUnicode(false);
            entity.Property(e => e.TrainingAssignment).IsUnicode(false);
            entity.Property(e => e.TrainingContent).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblTrainingReportReviews)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblTrainingReportReview_tblOrg");

            entity.HasOne(d => d.TrainingName).WithMany(p => p.TblTrainingReportReviews)
                .HasForeignKey(d => d.TrainingNameId)
                .HasConstraintName("FK_tblTrainingReportReview_tblTrainingHeader");
        });

        modelBuilder.Entity<TblTrainingScheduleHeader>(entity =>
        {
            entity.ToTable("tblTrainingScheduleHeader");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTrainingScheduleHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblTrainingScheduleHeader_tblOrg");

            entity.HasOne(d => d.TrainingName).WithMany(p => p.TblTrainingScheduleHeaders)
                .HasForeignKey(d => d.TrainingNameId)
                .HasConstraintName("FK_tblTrainingScheduleHeader_tblTrainingHeader");
        });

        modelBuilder.Entity<TblTrainingSessionDetail>(entity =>
        {
            entity.ToTable("tblTrainingSessionDetails");

            entity.Property(e => e.Content).IsUnicode(false);

            entity.HasOne(d => d.SessionHeader).WithMany(p => p.TblTrainingSessionDetails)
                .HasForeignKey(d => d.SessionHeaderId)
                .HasConstraintName("FK_tblTrainingSessionDetails_tblTrainingSessionHeader");
        });

        modelBuilder.Entity<TblTrainingSessionHeader>(entity =>
        {
            entity.ToTable("tblTrainingSessionHeader");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTrainingSessionHeaders)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblTrainingSessionHeader_tblOrg");

            entity.HasOne(d => d.Training).WithMany(p => p.TblTrainingSessionHeaders)
                .HasForeignKey(d => d.TrainingId)
                .HasConstraintName("FK_tblTrainingSessionHeader_tblTrainingHeader");
        });

        modelBuilder.Entity<TblTraningSchedule>(entity =>
        {
            entity.ToTable("tblTraningSchedule");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblTraningSchedules)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblTraningSchedule_tblEmployee");

            entity.HasOne(d => d.EmpOrg).WithMany(p => p.TblTraningScheduleEmpOrgs)
                .HasForeignKey(d => d.EmpOrgId)
                .HasConstraintName("FK_tblTraningSchedule_tblOrg");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTraningScheduleOrgs)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblTraningSchedule_tblOrg1");

            entity.HasOne(d => d.TraningScheduleHeader).WithMany(p => p.TblTraningSchedules)
                .HasForeignKey(d => d.TraningScheduleHeaderId)
                .HasConstraintName("FK_tblTraningSchedule_tblTrainingScheduleHeader");
        });

        modelBuilder.Entity<TblTransportPayment>(entity =>
        {
            entity.ToTable("tblTransportPayment");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113358");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTransportPayments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransportPayment_tblOrg");
        });

        modelBuilder.Entity<TblTransportTripSheet>(entity =>
        {
            entity.ToTable("tblTransportTripSheet");

            entity.HasIndex(e => new { e.RouteId, e.StudentId, e.OrgId }, "NonClusteredIndex-20170103-113410");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTransportTripSheets)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransportTripSheet_tblOrg");

            entity.HasOne(d => d.Route).WithMany(p => p.TblTransportTripSheets)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransportTripSheet_tblRoute");

            entity.HasOne(d => d.Student).WithMany(p => p.TblTransportTripSheets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransportTripSheet_tblStudent");
        });

        modelBuilder.Entity<TblTripParticipant>(entity =>
        {
            entity.ToTable("tblTripParticipants");

            entity.HasIndex(e => new { e.TripSheetId, e.OrgId }, "NonClusteredIndex-20170103-113428");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTripParticipants)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTripParticipants_tblOrg");

            entity.HasOne(d => d.TripSheet).WithMany(p => p.TblTripParticipants)
                .HasForeignKey(d => d.TripSheetId)
                .HasConstraintName("FK_tblTripParticipants_tblTripSheet");
        });

        modelBuilder.Entity<TblTripSheet>(entity =>
        {
            entity.ToTable("tblTripSheet");

            entity.HasIndex(e => new { e.RouteVehicleId, e.OrgId }, "NonClusteredIndex-20170103-113442");

            entity.HasOne(d => d.Org).WithMany(p => p.TblTripSheets)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTripSheet_tblOrg");

            entity.HasOne(d => d.RouteVehicle).WithMany(p => p.TblTripSheets)
                .HasForeignKey(d => d.RouteVehicleId)
                .HasConstraintName("FK_tblTripSheet_tblRoute$Vehicle");
        });

        modelBuilder.Entity<TblUnitOfMeasure>(entity =>
        {
            entity.ToTable("tblUnitOfMeasure");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113457");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblUnitOfMeasures)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUnitOfMeasure_tblOrg");
        });

        modelBuilder.Entity<TblVehicle>(entity =>
        {
            entity.ToTable("tblVehicle");

            entity.HasIndex(e => new { e.TypeId, e.OrgId }, "NonClusteredIndex-20170103-113511");

            entity.Property(e => e.ChassisNumber).IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.InsuranceNo).IsUnicode(false);
            entity.Property(e => e.InsuranceRenewalDate).HasColumnType("date");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Rcnumber)
                .IsUnicode(false)
                .HasColumnName("RCNumber");
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Device).WithMany(p => p.TblVehicles)
                .HasForeignKey(d => d.DeviceId)
                .HasConstraintName("FK_tblVehicle_tblVehicleDevice");

            entity.HasOne(d => d.Org).WithMany(p => p.TblVehicles)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVehicle");

            entity.HasOne(d => d.Type).WithMany(p => p.TblVehicles)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVehicle_tblVehicleType");
        });

        modelBuilder.Entity<TblVehicleAttachment>(entity =>
        {
            entity.ToTable("tblVehicleAttachments");

            entity.Property(e => e.FileName)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblVehicleAttachments)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVehicleAttachments_tblOrg");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.TblVehicleAttachments)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVehicleAttachments_tblVehicle");
        });

        modelBuilder.Entity<TblVehicleDevice>(entity =>
        {
            entity.ToTable("tblVehicleDevice");

            entity.Property(e => e.DeviceName).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblVehicleDevices)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVehicleDevice_tblOrg");
        });

        modelBuilder.Entity<TblVehicleType>(entity =>
        {
            entity.ToTable("tblVehicleType");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113526");

            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblVehicleTypes)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVehicleType_tblOrg");
        });

        modelBuilder.Entity<TblVendor>(entity =>
        {
            entity.ToTable("tblVendor");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113541");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BalanceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cstnumber).HasColumnName("CSTNumber");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.OpeningBalance).HasColumnType("money");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblVendors)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVendor_tblOrg");
        });

        modelBuilder.Entity<TblVideoGallery>(entity =>
        {
            entity.ToTable("tblVideoGallery");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Title).IsUnicode(false);
            entity.Property(e => e.Url).IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblVideoGalleries)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblVideoGallery_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblVideoGalleries)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblVideoGallery_tblCourse");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblVideoGalleries)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblVideoGallery_tblEmployee");

            entity.HasOne(d => d.Org).WithMany(p => p.TblVideoGalleries)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblVideoGallery_tblOrg");
        });

        modelBuilder.Entity<TblVisitor>(entity =>
        {
            entity.ToTable("tblVisitors");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-20170103-113611");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Mobile).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.VehicleNumber).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblVisitors)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVisitors_tblOrg");
        });

        modelBuilder.Entity<TblVisitorMaterial>(entity =>
        {
            entity.ToTable("tblVisitorMaterials");

            entity.HasIndex(e => new { e.VisitorId, e.OrgId }, "NonClusteredIndex-20170103-113556");

            entity.Property(e => e.MaterialName).IsUnicode(false);

            entity.HasOne(d => d.Org).WithMany(p => p.TblVisitorMaterials)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVisitorMaterials_tblOrg");

            entity.HasOne(d => d.Visitor).WithMany(p => p.TblVisitorMaterials)
                .HasForeignKey(d => d.VisitorId)
                .HasConstraintName("FK_tblVisitorMaterials_tblVisitors");
        });

        modelBuilder.Entity<TblVisualTimeTablePhotoType>(entity =>
        {
            entity.ToTable("tblVisualTimeTablePhotoType");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Batch).WithMany(p => p.TblVisualTimeTablePhotoTypes)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_tblVisualTimeTablePhotoType_tblBatch");

            entity.HasOne(d => d.Course).WithMany(p => p.TblVisualTimeTablePhotoTypes)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblVisualTimeTablePhotoType_tblCourse");

            entity.HasOne(d => d.Org).WithMany(p => p.TblVisualTimeTablePhotoTypes)
                .HasForeignKey(d => d.OrgId)
                .HasConstraintName("FK_tblVisualTimeTablePhotoType_tblOrg");

            entity.HasOne(d => d.OtherProgram).WithMany(p => p.TblVisualTimeTablePhotoTypes)
                .HasForeignKey(d => d.OtherProgramId)
                .HasConstraintName("FK_tblVisualTimeTablePhotoType_tblOtherPrograms");
        });

        modelBuilder.Entity<TblVoucherList>(entity =>
        {
            entity.ToTable("tblVoucherList");

            entity.HasIndex(e => new { e.MasterVoucherId, e.OrgId }, "NonClusteredIndex-20170103-113631");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.MasterVoucher).WithMany(p => p.TblVoucherLists)
                .HasForeignKey(d => d.MasterVoucherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVoucherList_tblMasterVoucherList");

            entity.HasOne(d => d.Org).WithMany(p => p.TblVoucherLists)
                .HasForeignKey(d => d.OrgId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVoucherList_tblOrg");
        });

        modelBuilder.Entity<TblWidget>(entity =>
        {
            entity.ToTable("tblWidget");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WidgetName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<View>(entity =>
        {
            entity.ToTable("View");

            entity.Property(e => e.ViewContent).IsUnicode(false);
            entity.Property(e => e.ViewName).IsUnicode(false);
            entity.Property(e => e.ViewPath).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
