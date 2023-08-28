using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public long StudentId { get; private set; }
        public DiaryController(WebSchoolContext _db)
        {
            db = _db;
        }
        private DateTime onlyDateConvertToDateTime(string input)
        {
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return DateTime.UtcNow;
        }
        [HttpPost("StudDiary")]
        public async Task<JsonResult> StudDiary([FromBody] StudDiary SaveDairyObject)

        {
            try
            {
                var AttendanceDate = onlyDateConvertToDateTime(SaveDairyObject.dateAttendance);
                foreach (var temp in SaveDairyObject.AttendaceObj)
                {
                    if (temp.isPresent == true)
                    {
                        TblStudentDiary studentDiary = new TblStudentDiary()
                        {
                            StudentId = temp.Id,
                            DateWritten = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                            //DateWritten = new DateTime(),
                            OrgId = SaveDairyObject.OrgId,
                            Comments = SaveDairyObject.Comments,
                            Title = SaveDairyObject.Title,
                            BatchId = SaveDairyObject.BatchId,
                            CourseId = SaveDairyObject.CourseId
                        };
                        db.TblStudentDiaries.Add(studentDiary);
                        db.SaveChanges();
                    }
                }
                return new JsonResult(new ErrorMessageDto { Status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }


        [HttpPost("AddDailyDiaryReport")]
        public async Task<JsonResult> AddDailyDiaryReport([FromBody] List<Dairy> AttendaceObj, string dateAttendance, long OrgId, string Comments, long BatchId, long CourseId, string Title)

        {
            try
            {
                var AttendanceDate = onlyDateConvertToDateTime(dateAttendance);
                foreach (var temp in AttendaceObj)
                {
                    if (temp.isPresent == true)
                    {
                        db.TblStudentDiaries.Add(new TblStudentDiary()
                        {
                            StudentId = temp.Id,
                            DateWritten = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                            //DateWritten = new DateTime(),
                            OrgId = OrgId,
                            Comments = Comments,
                            Title = Title,
                            BatchId = BatchId,
                            CourseId = CourseId
                        });
                        db.SaveChanges();
                    }
                }
                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, message = e.ToString() });
            }
        }


        [HttpGet("GetDiaryReport")]
        public async Task<IActionResult> GetDiaryReport(long BatchId, long CourseId, long OrgId, long StudentId)
        {
            try
            {
                var studentDiary = await (from tableDiaryReport in db.TblStudentDiaries
                                          where tableDiaryReport.BatchId == BatchId && tableDiaryReport.CourseId == CourseId && tableDiaryReport.OrgId == OrgId && tableDiaryReport.StudentId == StudentId
                                          select new
                                          {
                                              Date = tableDiaryReport.DateWritten,
                                              Comments = tableDiaryReport.Comments,
                                              Title = tableDiaryReport.Title
                                          })
                                          .ToListAsync();

                var formattedDiary = studentDiary.Select(s => new
                {
                    Date = s.Date.Value.ToString("yyyy-MM-dd hh:mm:ss tt"),
                    s.Title,
                    s.Comments
                })
                .OrderBy(o => o.Date)
                .ToList();

                return Ok(new { studentDiary = formattedDiary });
            }
            catch (Exception e)
            {
                return BadRequest(new ErrorMessageDto { Message = e.ToString() });
            }
        }



        [HttpPost("GetDiaryReportNew")]
        public async Task<IActionResult> GetDiaryReportNew(DairyData data)
        {
            try
            {
                var studentDiary = await (from tableDiaryReport in db.TblStudentDiaries
                                          where tableDiaryReport.BatchId == data.Batch && tableDiaryReport.CourseId == data.Course && tableDiaryReport.OrgId == data.OrgId && tableDiaryReport.StudentId == data.StudentId
                                          select new
                                          {
                                              Date = tableDiaryReport.DateWritten,
                                              Comments = tableDiaryReport.Comments,
                                              Title = tableDiaryReport.Title
                                          })
                                          .ToListAsync();

                var formattedDiary = studentDiary.Select(s => new
                {
                    Date = s.Date.Value.ToString("yyyy-MM-dd hh:mm:ss tt"),
                    s.Title,
                    s.Comments
                })
                .OrderBy(o => o.Date)
                .ToList();

                return Ok(new { studentDiary = formattedDiary });
            }
            catch (Exception e)
            {
                return BadRequest(new ErrorMessageDto { Message = e.ToString() });
            }

        }
    }
}
