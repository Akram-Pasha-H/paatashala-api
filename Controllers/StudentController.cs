using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public StudentController(WebSchoolContext _db)
        {
            db = _db;
        }

        [HttpGet("GetStudents")]
        public async Task<JsonResult> GetStudents(long batchId, long courseId, long OrgId)
        {
            try
            {
                var students = await (from ba in db.TblBatchAdmissions
                                      join b in db.TblBatches on ba.BatchId equals b.Id
                                      join c in db.TblCourses on ba.CourseId equals c.Id
                                      join s in db.TblStudents on ba.StudentId equals s.Id
                                      where ba.OrgId == OrgId && ba.CourseId == courseId && ba.BatchId == batchId
                                      select new { s.Id, Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.FatherName, s.Sex, s.DateOfBirth, ba.BatchId, ba.CourseId }).ToListAsync();
                return new JsonResult(students);
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString());
            }
        }
        [HttpGet("StudentImage")]
        public async Task<FileStreamResult> StudentImage(long Id)
        {
            try
            {
                var student = await db.TblStudents.FindAsync(Id);
                if (student != null)
                {
                    return new FileStreamResult(new MemoryStream(student.Photo, true), "image/jpeg");
                }
                return new FileStreamResult(new FileStream(@"~\Resources\Image\student.png", FileMode.Open), "image/jpeg");
            }
            catch
            {
                return null;
            }
        }
    }
}
