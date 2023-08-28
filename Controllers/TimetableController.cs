using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimetableController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public TimetableController(WebSchoolContext _db) 
        {
            db = _db;
        }
        [HttpGet("GetByCourse")]
        public async Task<JsonResult> GetByCourse(long BatchId, long CourseId, long OrgId)
        {
            try
            {
                TimeTableStructure structureObj = new TimeTableStructure();
                var timeTable = await db.TblTimeTables.Where(t => t.Batch == BatchId && t.Course == CourseId && t.IsActive == true && t.OrgId == OrgId).FirstOrDefaultAsync();
                var timetableWorkingDays = await (from tt in db.TblTimeTables
                                                  join tw in db.TblTimetableWorkingDays on tt.Id equals tw.TimetableId
                                                  where tt.Course == CourseId && tt.Batch == BatchId && tt.OrgId == OrgId && tt.IsActive == true
                                                  select tw).FirstOrDefaultAsync();

                if (timetableWorkingDays != null)
                {
                    structureObj.Name = timeTable.Name;
                    structureObj.Id = timeTable.Id;
                    await AddTimeTableStructureAsync(timeTable.Id, structureObj, timetableWorkingDays); // Wait for the asynchronous operation to complete
                    return new JsonResult(structureObj);
                }
                else
                {
                    return new JsonResult("Working days not set.");
                }
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString());
            }
        }

        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        private async Task AddTimeTableStructureAsync(long id, TimeTableStructure structureObj, TblTimetableWorkingDay timetableWorkingDays)
        {
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.SUNDAY).First().Visible = timetableWorkingDays.Sunday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.MONDAY).First().Visible = timetableWorkingDays.Monday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.TUESDAY).First().Visible = timetableWorkingDays.Tuesday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.WEDNESDAY).First().Visible = timetableWorkingDays.Wednesday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.THURSDAY).First().Visible = timetableWorkingDays.Thrusday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.FRIDAY).First().Visible = timetableWorkingDays.Friday ?? false;
            structureObj.WeekdayTimeTables.Where(w => w.WeekdayName == Weekday.SATARDAY).First().Visible = timetableWorkingDays.Saturday ?? false;

            var periods = await (from td in db.TblTimeTableDetails
                                 join tt in db.TblTimeTables on td.TimeTableId equals tt.Id
                                 where tt.Id == id
                                 select td).ToListAsync();

            foreach (var item in periods)
            {
                var f = await db.TblEmployees.Where(e => e.Id == item.FacultyId).FirstOrDefaultAsync();
                var subject = await db.TblSubjects.Where(s => s.Id == item.SubjectId).FirstOrDefaultAsync();
                structureObj.WeekdayTimeTables.Where(w => (int)w.WeekdayName == (int)item.WorkingDays).First().Periods.Add(new Period()
                {
                    Subject = subject != null ? new TimeTableSubject() { Name = subject.Name, Id = subject.Id } : new TimeTableSubject() { Name = "BREAK", Id = 0 },
                    StartTime = ConvertToJavascriptDate(new DateTime(1970, 1, 1, item.StartTime.Value.Hours, item.StartTime.Value.Minutes, item.StartTime.Value.Seconds)),
                    EndTime = ConvertToJavascriptDate(new DateTime(1970, 1, 1, item.EndTime.Value.Hours, item.EndTime.Value.Minutes, item.EndTime.Value.Seconds)),
                    Id = item.Id,
                    FacultyName = f.FirstName + " " + f.LastName,
                    FacultyId = f.Id
                });
            }
        }

    }
}
