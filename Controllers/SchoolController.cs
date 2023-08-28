using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        public WebSchoolContext db;
        public SchoolController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetAll")]
        public async Task<JsonResult> GetAll()
        {
            try
            {
                var schoolList = await db.TblOrgs
            .Select(tableSchool => new { tableSchool.Id, tableSchool.OrgName })
            .ToListAsync();

                return new JsonResult(schoolList);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }
}
