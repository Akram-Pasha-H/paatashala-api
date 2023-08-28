using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssesmentReportController : ControllerBase
    {
        private readonly WebSchoolContext db;
        Assesment Assesmentobj = new Assesment();
        public AssesmentReportController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetByStudent")]
        public async Task<JsonResult> GetByStudent(long StudentId, long OrgId)
        {
            try
            {

                WebSchoolContext db =  new WebSchoolContext();
                var ReportDetail = await (from tableMarks in db.TblExamMarks
                                    join tableSubjects in db.TblSubjects on tableMarks.SubjectId equals tableSubjects.Id
                                    join tableExamSchedule in db.TblExamSchedules on tableMarks.ExamSchdeduleId equals tableExamSchedule.Id
                                    join tableExamtype in db.TblExamTypes on tableExamSchedule.ExamType equals tableExamtype.Id
                                    where tableMarks.StudentId == StudentId && tableMarks.OrgId == OrgId
                                    select new { tableExamtype.Name, SubjectName = tableSubjects.Name, tableMarks.Marks }).ToListAsync();

                Assesmentobj.Reports = ReportDetail.Select(item => new AssesmentList
            {
                Examtype = item.Name,
                SubjectName = item.SubjectName,
                Marks = item.Marks
            }).ToList();

            return new JsonResult(Assesmentobj);
        }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
