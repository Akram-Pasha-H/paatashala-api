using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly WebSchoolContext db;
        public CourseController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetAllByOrg")]

        public async Task<JsonResult> GetAllByOrg(long OrgId)
        {
            try
            {
                var Course = (from tableCourse in db.TblCourses
                              where tableCourse.OrgId == OrgId
                              select new { tableCourse.Id, tableCourse.Name }).ToList();
                return new JsonResult(Course);
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString());
            }
        }
    }
}
