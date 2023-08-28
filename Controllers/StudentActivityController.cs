using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentActivityController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public StudentActivityController(WebSchoolContext _db)
        {
            db = _db;
        }
        private DateTime OnlyDateConvertToDateTime(string input)
        {
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return DateTime.UtcNow;
        }
        [HttpGet("GetStudents")]
        public async Task<JsonResult> GetStudents (long OrgId, long CourseId, long BatchId)
        {
            try
            {
                var students = await (from batchAdmission in db.TblBatchAdmissions
                                      join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                      where batchAdmission.OrgId == OrgId && batchAdmission.CourseId == CourseId &&
                                      batchAdmission.BatchId == BatchId
                                      select new
                                      {
                                          FirstName = student.FirstName,
                                          MiddleName = student.MiddleName,
                                          LastName = student.LastName,
                                          student.Id
                                      }).ToListAsync();

                var formattedStudents = students.Select(s => new { StudentName = $"{s.FirstName} {s.MiddleName} {s.LastName}", s.Id });
                return new JsonResult(formattedStudents);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("SaveActivityType")]
        public async Task<JsonResult> SaveActivityType(string Name, string Description, long OrgId)
        {
            try
            {
                db.TblStudentActivityTypes.Add(new TblStudentActivityType()
                {
                    Name = Name,
                    Description = Description,
                    OrgId = OrgId
                });
               await db.SaveChangesAsync();
                return new JsonResult(new { status = true });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetActivityType")]
        public async Task<JsonResult> GetActivityType(long OrgId)
        {
            try
            {
                var activityTypes = await db.TblStudentActivityTypes.Where(x => x.OrgId == OrgId)
            .Select(y => new { y.Id, y.Name }).ToListAsync();

                return new JsonResult(new { ActivityTypes = activityTypes });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetActivityTypeNew")]
        public async Task<JsonResult> GetActivityTypeNew(long OrgId)
        {
            try
            {
                if (OrgId != 0)
                {
                    var activityTypes = await db.TblStudentActivityTypes.Where(x => x.OrgId == OrgId)
                        .Select(y => new { y.Id, y.Name }).ToListAsync();

                    return new JsonResult(activityTypes);
                }
                else
                {
                    return new JsonResult(new { status = false });
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("SaveStudentActivity")]

        public async Task<JsonResult> SaveStudentActivity(List<ActivityReportDto> StudentListObj, string ActivityDate, long OrgId, long BatchId, long CourseId, long ActivityId, string WhatDid, string Comments, string When, string HowMuch)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(ActivityDate);
                foreach (var temp in StudentListObj)
                {
                    if (temp.isPresent == true)
                    {
                        db.TblStudentActivities.Add(new TblStudentActivity()
                        {
                            ActivityDate = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                            BatchId = BatchId,
                            CourseId = CourseId,
                            StudentId = temp.Id,
                            ActivityTime = When,
                            WhatActivity = WhatDid,
                            HowMuch = HowMuch,
                            Comments = Comments,
                            ActivityTypeId = ActivityId,
                            OrgId = OrgId
                        });
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
        [HttpPost("SaveActivityTypes")]
        public async Task<JsonResult> SaveActivityTypes(ActType actType)
        {
            try
            {
                if (actType.OrgId != 0)
                {
                    db.TblStudentActivityTypes.Add(new TblStudentActivityType()
                    {
                        Name = actType.Name,
                        Description = actType.Description,
                        OrgId = actType.OrgId
                    });
                   await db.SaveChangesAsync();
                    return new JsonResult(new { status = true });
                }
                else
                {
                    return new JsonResult(new { status = false });

                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("GetStudent")]
        public async Task<JsonResult> GetStudent(Studentinfo studinfo)
        {
            try
            {
                var Students = await (from batchAdmission in db.TblBatchAdmissions
                                      join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                      where batchAdmission.OrgId == studinfo.OrgId && batchAdmission.CourseId == studinfo.CourseId &&
                                            batchAdmission.BatchId == studinfo.BatchId
                                      select new
                                      {
                                          StudentName = student.FirstName + ' ' + student.MiddleName + ' ' + student.LastName,
                                          student.Id
                                      }).ToListAsync();

                return new JsonResult(Students);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("SaveStudentActivities")]
        public async Task<JsonResult> SaveStudentActivities(studentActReport report)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(report.ActivityDate);
                foreach (var temp in report.StudentListObj)
                {
                    if (temp.isPresent == true)
                    {
                        db.TblStudentActivities.Add(new TblStudentActivity()
                        {
                            ActivityDate = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                            BatchId = report.BatchId,
                            CourseId = report.CourseId,
                            StudentId = temp.Id,
                            ActivityTime = report.When,
                            WhatActivity = report.WhatDid,
                            HowMuch = report.HowMuch,
                            Comments = report.Comments,
                            ActivityTypeId = report.ActivityId,
                            OrgId = report.OrgId
                        });
                      await  db.SaveChangesAsync();
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
