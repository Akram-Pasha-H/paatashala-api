using PaatashalaApi.Models;

namespace PaatashalaApi.DTOs
{
    public class AddNewLeadDto
    {
        public TblStudent tblStudent { get; set; }
        public TblStudentRegistration tblStudentRegistration { get; set; }
        public TblLeadFollowUp tblLeadFollowUp { get; set; }
    }
}
