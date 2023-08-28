using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public FacultyController(WebSchoolContext _db)
        {
            db = _db;
        }
        Faculty Facultyobj = new Faculty();

        [HttpGet("GetFaculty")]
        public async Task<JsonResult> GetFaculty(long StudentId)
        {


            try
            {
                var facultyData = await (from tableSubject in db.TblSubjects
                                         join tableCourseSubjects in db.TblCourseSubjects on tableSubject.Id equals tableCourseSubjects.SubjectId
                                         join tableBatchAdmission in db.TblBatchAdmissions on tableCourseSubjects.CourseId equals tableBatchAdmission.CourseId
                                         join tableTimeTable in db.TblTimeTableDetails on tableSubject.Id equals tableTimeTable.SubjectId
                                         join timetable in db.TblTimeTables on tableTimeTable.TimeTableId equals timetable.Id
                                         join tableEmployee in db.TblEmployees on tableTimeTable.FacultyId equals tableEmployee.Id
                                         where tableBatchAdmission.StudentId == StudentId && timetable.IsActive == true
                                         select new { tableSubject.Name, FirstName = tableEmployee.FirstName, MiddleName = tableEmployee.MiddleName, LastName = tableEmployee.LastName })
                                         .Distinct()
                                         .ToListAsync();

                var facultyList = facultyData.Select(item => new Faculties
                {
                    EmployeeName = item.FirstName + " " + item.MiddleName + " " + item.LastName,
                    SubjectName = item.Name
                }).ToList();

                var facultyObj = new Faculty
                {
                    FacultyList = facultyList
                };

                return new JsonResult(facultyObj);
            }
            catch (Exception e)
                {
                    return new JsonResult(e.ToString());
                }

            }
        }

    }

