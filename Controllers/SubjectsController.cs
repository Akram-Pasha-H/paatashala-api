using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public SubjectsController(WebSchoolContext _db)
        {
            db = _db;
        }
        Subject SubjectObj = new Subject();

        [HttpGet("GetAllByStudent")]
        public async Task<JsonResult> GetAllByStudent(long StudentId)
        {
            try
            {
                var SubjectsData = await (from tableSubject in db.TblSubjects
                                          join tableCourseSubjects in db.TblCourseSubjects on tableSubject.Id equals tableCourseSubjects.SubjectId
                                          join tableBatchAdmission in db.TblBatchAdmissions on tableCourseSubjects.CourseId equals tableBatchAdmission.CourseId
                                          join tableTimeTableDetail in db.TblTimeTableDetails on tableSubject.Id equals tableTimeTableDetail.SubjectId
                                          join tabletimetable in db.TblTimeTables on tableTimeTableDetail.TimeTableId equals tabletimetable.Id
                                          join tableEmployee in db.TblEmployees on tableTimeTableDetail.FacultyId equals tableEmployee.Id
                                          where tableBatchAdmission.StudentId == StudentId && tabletimetable.IsActive == true
                                          select new { tableSubject.Id, tableSubject.Name, tableEmployee.FirstName }).ToListAsync();

                SubjectObj.subjectsList = SubjectsData.Select(item => new Subjects
                {
                    Id = item.Id,
                    SubjectName = item.Name,
                    EmployeeName = item.FirstName
                }).ToList();

                return new JsonResult(SubjectObj);
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString());
            }
        }
    }
}
