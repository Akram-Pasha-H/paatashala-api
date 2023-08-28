using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageBoxController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public MessageBoxController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetStudentMessage")]
        public async Task<JsonResult> GetStudentMessage(long StudentId, long OrgId, long? Index, long? Count)
        {
            try
            {
                var Messages = await (from a in db.TblAppParentMessageContents
                                      join b in db.TblParentMessageBoxes on a.Id equals b.MessageId
                                      where b.OrgId == OrgId && b.StudentId == StudentId
                                      orderby a.CreatedOn descending
                                      select new { a, b })
                                              .Skip((int)Index)
                                              .Take((int)Count)
                                              .ToListAsync();

                var formattedMessages = Messages.Select(m => new
                {
                    CreatedOn = (m.a.CreatedOn ?? DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"),
                    m.b.Id,
                    m.a.Contents,
                    m.a.Type,
                    m.b.Response,
                    Options = db.TblParentMessageOptions
                        .Where(pmo => pmo.ParentMessageOptions.MessageId == m.a.Id)
                        .Select(pmo => new { pmo.Id, pmo.ParentMessageOptions.OptionValue })
                        .ToList()
                }).ToList();
                return new JsonResult(Messages);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("SaveMessageBoxResponse")]
        public async Task<JsonResult> SaveMessageBoxResponse(long MessageId, string Response)
        {
            try
            {
                var message = await db.TblParentMessageBoxes.FirstOrDefaultAsync(f => f.Id == MessageId);
                if (message != null)
                {
                    message.Response = Response;
                    db.TblParentMessageBoxes.Update(message);
                    await db.SaveChangesAsync();
                    return new JsonResult(new { Status = true, Message = "Response Saved" });
                }
                else
                {
                    return new JsonResult(new { Status = false, Message = "Message not found" });
                }
            }
            catch (Exception e)
            {
                return new JsonResult(new { Status = false, Message = e.ToString() });
            }
        }
        [HttpPost("GetStudentMessageNew")]
        public async Task<JsonResult> GetStudentMessageNew(LoadMessageObj Obj)
        {
            try
            {
                Obj.Index = Obj.Index ?? 0;
                Obj.Count = Obj.Count ?? 10;

                var Messages = await (from a in db.TblAppParentMessageContents
                                      join b in db.TblParentMessageBoxes on a.Id equals b.MessageId
                                      where b.OrgId == Obj.OrgId && b.StudentId == Obj.StudentId
                                      select new { a, b })
                            .OrderByDescending(o => o.a.CreatedOn)
                            .Skip((int)Obj.Index)
                            .Take((int)Obj.Count)
                            .ToListAsync();

                var formattedMessages = Messages.Select(m => new
                {
                    CreatedOn = (m.a.CreatedOn ?? DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"),
                    m.b.Id,
                    m.a.Contents,
                    m.a.Type,
                    m.b.Response,
                    Options = (from pmo in db.TblParentMessageOptions
                               join pmom in db.TblAppParentMessageContents on pmo.ParentMessageOptions.MessageId equals pmom.Id
                               where pmom.Id == m.a.Id
                               select new { pmo.Id, pmo.ParentMessageOptions.OptionValue }).ToList()
                }).ToList();
                return new JsonResult(formattedMessages);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }
}
