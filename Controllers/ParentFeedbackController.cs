using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentFeedbackController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public ParentFeedbackController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetFeedbackQuestions")]
        public async Task<JsonResult> GetFeedbackQuestions(long OrgId, long StudentId)
        {
            try
            {
                var IsStudentIdPresent = db.TblParentFeedbackHeaders.Where(x => x.StudentId == StudentId && x.OrgId == OrgId).Select(y => y).SingleOrDefault();
                if (IsStudentIdPresent == null)
                {
                    var GetQuestions = db.TblStudentFeedbackMobileAppQuestions.Where(x => x.OrgId == OrgId).Select(y => new { QuestionId = y.Id, y.Question }).ToList();
                    var Comments = "";
                    return new JsonResult(new { GetQuestions, Comments });
                }
                else
                {
                    var GetQuestions = await (from i in db.TblParentFeedbackDetails
                                              join j in db.TblParentFeedbackHeaders on i.HeaderId equals j.Id
                                              join k in db.TblStudentFeedbackMobileAppQuestions on i.QuestionId equals k.Id
                                              where j.OrgId == OrgId && j.StudentId == StudentId
                                              select new
                                              {
                                                  Question = k.Question,
                                                  value = i.Answer,
                                                  QuestionId = k.Id
                                              })
                                     .ToListAsync();

                    var Comments = IsStudentIdPresent.Comments;
                    return new JsonResult(new { GetQuestions, Comments });
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("SaveParentFeedback")]
        public async Task<JsonResult> SaveParentFeedback(long StudentId, long OrgId, string Comments, List<FeedbackResult> FeedbackResult)
        {
            try
            {
                var IsPresent = await db.TblParentFeedbackHeaders
                    .Where(x => x.StudentId == StudentId && x.OrgId == OrgId)
                    .SingleOrDefaultAsync();

                if (IsPresent == null)
                {
                    TblParentFeedbackHeader tblParentFeedbackHeaderObj = new TblParentFeedbackHeader
                    {
                        OrgId = OrgId,
                        StudentId = StudentId,
                        Date = DateTime.Today,
                        Comments = Comments
                    };

                    db.TblParentFeedbackHeaders.Add(tblParentFeedbackHeaderObj);
                    await db.SaveChangesAsync();

                    foreach (var items in FeedbackResult)
                    {
                        db.TblParentFeedbackDetails.Add(new TblParentFeedbackDetail
                        {
                            HeaderId = tblParentFeedbackHeaderObj.Id,
                            QuestionId = items.QuestionId,
                            Answer = items.value
                        });

                        await db.SaveChangesAsync();
                    }
                }
                else
                {
                    IsPresent.Comments = Comments;
                    IsPresent.Date = DateTime.Today;

                    db.Entry(IsPresent).State = EntityState.Modified;
                    await db.SaveChangesAsync();

                    foreach (var records in FeedbackResult)
                    {
                        var IsPresentAnswer = await db.TblParentFeedbackDetails
                            .Where(x => x.HeaderId == IsPresent.Id && x.QuestionId == records.QuestionId)
                            .SingleOrDefaultAsync();

                        IsPresentAnswer.Answer = records.value;
                        db.Entry(IsPresentAnswer).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                }

                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, message = e.ToString() });
            }
        }

    }
}

