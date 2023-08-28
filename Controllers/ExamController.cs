using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using System.Security.Cryptography;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public ExamController(WebSchoolContext _db)
        {
            db = _db;
        }

        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        Exam Examobj = new Exam();
        private long? batchId;
        private long? courseId;

        [HttpGet("GetByCourse")]
        public async Task<JsonResult> GetByCourse(long BatchId, long CourseId, long OrgId)
        {
            try
            {
                var examDetails = await db.TblExamSchedules
                 .Where(tableExamSchedule => tableExamSchedule.BatchId == batchId &&
                 tableExamSchedule.CourseId == CourseId &&
                 tableExamSchedule.OrgId == OrgId)
                 .Join(db.TblExamTypes,
                       tableExamSchedule => tableExamSchedule.ExamType,
                       tableExamType => tableExamType.Id,
                       (tableExamSchedule, tableExamType) => new { ExamSchedule = tableExamSchedule, ExamType = tableExamType })
                 .Join(db.TblSubjects,
                       combined => combined.ExamSchedule.SubjectId,
                       tableSubjects => tableSubjects.Id,
                       (combined, tableSubjects) => new
                       {
                           combined.ExamType.Name,
                           SubjectName = tableSubjects.Name,
                           Date = combined.ExamSchedule.Date.ToString(),
                           Duration = combined.ExamSchedule.Duration.ToString(),
                           StartTime = combined.ExamSchedule.StartTime.ToString()
                       })
                 .ToListAsync();

                var orderedExamDetails = examDetails.OrderByDescending(D => D.Date);

                return new JsonResult(new { ExamDetails = orderedExamDetails });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }
}
