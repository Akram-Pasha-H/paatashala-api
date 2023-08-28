using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public FeedbackController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpPost("AddFeedBack")]
        public async Task<JsonResult> AddFeedBack(string FeedbackText, long? EmployeeId, long? StudentId, long OrgId)
        {
            //tblFeedback tblFeedbackObj = new tblFeedback();
            //tblFeedbackObj.EmployeeId = EmployeeId;
            //tblFeedbackObj.FeedbackText = FeedbackText;
            //tblFeedbackObj.OrgId = OrgId;
            //tblFeedbackObj.ReceivedDate = DateTime.UtcNow;
            //tblFeedbackObj.StudentId = StudentId;
            //db.tblFeedbacks.Add(tblFeedbackObj);
            //db.SaveChanges();
            return new JsonResult(new { status = true });
        }
    }
}
