using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly WebSchoolContext db;
        public BatchController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetAllByOrg")]
        public async Task<JsonResult> GetAllByOrg(long OrgId)
        {
            try
            {
                var Course = (from tb in db.TblBatches
                              where tb.OrgId == OrgId
                              select new { tb.Id, tb.Name }).ToList();
                return new JsonResult(Course);
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString());
            }
        }
    }
}
