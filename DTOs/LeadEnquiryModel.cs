using PaatashalaApi.Models;

namespace PaatashalaApi.DTOs
{
    public class LeadEnquiryModel
    {
        public TblStudent Student { get; set; }
        public TblStudentRegistration Registration { get; set; }
        public TblLeadFollowUp LeadFollowUp { get; set; }
        public long OrgId { get; set; }
        public long EmployeeId { get; set; }
    }
}
