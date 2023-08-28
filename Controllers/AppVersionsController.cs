using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaatashalaApi.Models;
using System.Net;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppVersionsController : ControllerBase
    {
        private readonly WebSchoolContext db;
        public AppVersionsController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("Details")]

        public async Task<IActionResult> Details(long? id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest("No file uploaded.");
                }
                TblAppVersion tblAppVersion = await db.TblAppVersions.FindAsync(id);
                if (tblAppVersion == null)
                {
                    return NotFound();
                } 
                return new  JsonResult(tblAppVersion);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("Create")]
        public async Task<JsonResult> Create([FromBody] TblAppVersion tblAppVersion)
        {
            try
            {

                if (ModelState.IsValid)
                {
                  await  db.TblAppVersions.AddAsync(tblAppVersion);
                    db.SaveChanges();
                    
                }

                return new JsonResult(tblAppVersion);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
