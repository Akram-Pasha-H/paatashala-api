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
    public class EmpAttandanceController : ControllerBase
    {
        public readonly WebSchoolContext db;
        private long orgId;

        public EmpAttandanceController(WebSchoolContext _db)
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
        [HttpGet("GetEmployeesList")]
        public async Task<JsonResult> GetEmployeesList(long OrgId)
        {
            try
            {
                var employeeList = await db.TblEmployees
                .Where(x => x.OrgId == OrgId)
                .Select(y => new
                {
                    y.Id,
                    y.EmpId,
                    y.FirstName,
                    y.MiddleName,
                    y.LastName
                })
                .ToListAsync();
                var formattedEmployeeList = employeeList.Select(s => new
                {
                    Name = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                    s.Id,
                    s.EmpId
                }).ToList();

                return new JsonResult(formattedEmployeeList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        [HttpPost("SaveEmployeeAttendance")]

        public async Task<JsonResult> SaveEmployeeAttendance(long OrgId, List<long> EmpId, string scanDateTime, bool IsCheckIn)
        {
            try
            {
                DateTime AttendanceDate =  OnlyDateConvertToDateTime(scanDateTime);
                foreach (var i in EmpId)
                {
                    db.TblEmployeeAttendances.Add(new TblEmployeeAttendance()
                    {
                        EmpId = i,
                        IsPresent = true,
                        //Time = new TimeSpan(AttendanceDate.Hour, AttendanceDate.Minute, AttendanceDate.Second),
                        Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                        OrgId = OrgId
                    });
                  await db.SaveChangesAsync();
                }
                return new JsonResult(new { status = true });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { status = false, message = ex.ToString() });
            }
        }


        [HttpPut("SaveEmployeeAttendanceNew")]
         
        public async Task<JsonResult> SaveEmployeeAttendanceNew(EmployeeBCAttendanceData emp)
        {
            try
            {
                DateTime AttendanceDate = OnlyDateConvertToDateTime(emp.scanDateTime);
                foreach (var i in emp.EmpId)
                {
                    db.TblEmployeeAttendances.Add(new TblEmployeeAttendance()
                    {
                        EmpId = i,
                        IsPresent = true,
                        Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                        OrgId = emp.OrgId
                    });
                   await db.SaveChangesAsync();
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

