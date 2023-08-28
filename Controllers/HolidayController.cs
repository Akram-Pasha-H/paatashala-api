using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using System.Globalization;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public HolidayController(WebSchoolContext _db)
        {
            db = _db;
        }
        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }

        [HttpGet("GetAll")]
        public async Task<JsonResult> GetAll(long OrgId)
        {
            try
            {
                Holiday Holidayobj = new Holiday();
                var Year = DateTime.Now.Year;



                var holidays = await db.TblHolidayLists
                    .Where(tableHoliday => tableHoliday.Date.Value.Year == Year && tableHoliday.OrgId == OrgId)
                    .Select(tableHoliday => new { Date = tableHoliday.Date, tableHoliday.Name })
                    .ToListAsync();
                var formattedHolidays = holidays
                   .Select(s => new { Date = s.Date.Value.ToString("yyyy-MM-dd"), s.Name })
                   .OrderBy(o => o.Date)
                   .ToList();
                return new JsonResult(new { Holidays = formattedHolidays });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetEmployeeHolidays")]
        public async Task<JsonResult> GetEmployeeHolidays(long OrgId)
        {
            try
            {
                var year = DateTime.Now.Year;

                var holidays = await db.TblHolidayLists
                    .Where(tableHoliday => tableHoliday.Date.Value.Year == year && tableHoliday.OrgId == OrgId)
                    .Select(tableHoliday => new { Date = tableHoliday.Date, tableHoliday.Name })
                    .ToListAsync();

                var formattedHolidays = holidays
                    .Select(s => new { Date = s.Date.Value.ToString("yyyy-MM-dd"), s.Name })
                    .OrderBy(o => o.Date)
                    .ToList();

                return new JsonResult(new { Holidays = formattedHolidays });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetEmployeeHolidaysNew")]
        public async Task<JsonResult> GetEmployeeHolidaysNew(long OrgId)
        {
            try
            {

                //var year = DateTime.Now.Year;

                var holidays = await db.TblHolidayLists
                    .Where(tableHoliday =>  tableHoliday.OrgId == OrgId && tableHoliday.Date != null)
                    .Select(tableHoliday => new { Date = tableHoliday.Date, tableHoliday.Name })
                    .ToListAsync();

                List<HolidaysList> holidayList = new List<HolidaysList>();

                foreach (var item in holidays)
                {
                    HolidaysList HolidaysListobj = new HolidaysList();
                    var i = item.Date.Value.Month;

                    HolidaysListobj.MonthName = Enum.GetName(typeof(Months), i);
                    HolidaysListobj.HolidayName = item.Name;
                    HolidaysListobj.Date = item.Date.Value.ToString("dd-MM-yyyy");

                    holidayList.Add(HolidaysListobj);
                }

                return new JsonResult(holidayList);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        private enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        [HttpGet("GetAllNew")]
        public async Task<JsonResult> GetAllNew(long OrgId)
        {
            try
            {
                
                var holidays = await db.TblHolidayLists
                    .Where(tableHoliday => tableHoliday.OrgId == OrgId && tableHoliday.Date != null)
                    .OrderBy(tableHoliday => tableHoliday.Date.Value.Month)
                    .Select(item => new { Date = item.Date, item.Name })
                    .ToListAsync();

                var holidayList = new List<HolidaysList>();
                foreach (var item in holidays)
                {
                    var month = item.Date.Value.Month;
                    var holidaysListObj = new HolidaysList
                    {
                        MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month),
                        HolidayName = item.Name,
                        Date = item.Date.Value.ToString("dd-MM-yyyy")
                    };
                    holidayList.Add(holidaysListObj);
                }
                return new JsonResult(holidayList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
    public class HolidaysList
    {
        public string MonthName { get; set; }
        public string HolidayName { get; set; }
        public string Date { get; set; }
    }
}

