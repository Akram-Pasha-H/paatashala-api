using PaatashalaApi.Models;

namespace PaatashalaApi.DTOs
{
    public class EnquiryModelDto
    {
        public TblStudentDto student { get; set; }
        public TblStudentRegistrationDto registration { get; set; }
        public TblLeadFollowUpDto LeadFollowUp { get; set; }
        public long OrgId { get; set; }
        public long EmployeeId { get; set; }
    }
    public class EnquiryModel
    {
        public TblStudent student { get; set; }
        public TblStudentRegistration registration { get; set; }
        public TblLeadFollowUp LeadFollowUp { get; set; }
        public long OrgId { get; set; }
        public long EmployeeId { get; set; }
    }
}
