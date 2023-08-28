using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppMenuController : ControllerBase
    {
        private readonly WebSchoolContext db;
        public AppMenuController(WebSchoolContext _db)
        {
            db = _db;
        }

        [HttpGet("GetMenu")]
        public async Task<JsonResult> GetMenu(long OrgId, string LoginType)
        {
            try
            {
                long LoginTypeId = 0;

                var found = await db.TblRoles.Where(w => w.RoleName == LoginType && w.OrgId == OrgId).FirstOrDefaultAsync();
                if (found != null)
                    LoginTypeId = found.Id;

                var Menu = await (from a in db.TblAppMenuDefinitions
                            join b in db.TblAppMenuNames on a.MenuNameId equals b.Id
                            where a.LoginType == LoginTypeId && a.OrgId == OrgId
                            select new { a.Id, b.MenuName, a.Sequence, b.Url, b.Icon }).Distinct().ToListAsync();
                return new JsonResult(Menu);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new ErrorMessageDto { Status = false, Message = ex.ToString() });
            }
        }
    }
}
