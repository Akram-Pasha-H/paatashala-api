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
    public class EmployeeAttendanceController : ControllerBase
    {
        public readonly WebSchoolContext db;

        public long OrgId { get; private set; }

        public EmployeeAttendanceController(WebSchoolContext _db)
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

        [HttpGet("GetRoloes")]
        public async Task<JsonResult> GetRoloes(long OrgId)
        {
            try
            {
                List<dynamic> dynamicList = new List<dynamic>();
                var Roles = await db.TblRoles
                    .Where(x => x.OrgId == OrgId)
                    .Select(y => new { y.Id, y.RoleName })
                    .ToListAsync();
                dynamicList.Add(new { Id = "0", Name = "All Employee" });
                foreach (var Temp in Roles)
                {
                    dynamicList.Add(new { Id = Temp.Id, Name = Temp.RoleName });
                }
                return new JsonResult(dynamicList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("GetEmpsOnRole")]

        public async Task<JsonResult> GetEmpsOnRole(EmpBasedOnRole EmpObj)
        {
            try
            {
                DateTime DateAttendace = OnlyDateConvertToDateTime(EmpObj.AttendanceDate);

                var Employees = db.TblEmployees.Where(x => x.OrgId == EmpObj.OrgId).Select(y => new { y.Id, y.FirstName, y.MiddleName, y.LastName }).ToList().
                    Select(s => new { Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });

                if (EmpObj.RoleId != 0)
                {
                    Employees = db.TblEmployees.Where(x => x.OrgId == EmpObj.OrgId && x.RoleId == EmpObj.RoleId).Select(y => new { y.Id, y.FirstName, y.MiddleName, y.LastName }).ToList().
                   Select(s => new { Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });
                }

                List<EmpManualAttendace> AttendanceDateWiseModelObjList = new List<EmpManualAttendace>();
                foreach (var item in Employees)
                {
                    EmpManualAttendace EmpManualAttendaceObj = new EmpManualAttendace();
                    EmpManualAttendaceObj.Id = item.Id;
                    EmpManualAttendaceObj.Name = item.Name;
                    var IsPresent = db.TblEmployeeAttendances.Where(i => i.EmpId == item.Id && i.OrgId == EmpObj.OrgId && i.IsPresent == true && i.Date.Month == DateAttendace.Month && i.Date.Year == DateAttendace.Year && i.Date.Day == DateAttendace.Day).ToList().Count();
                    if (IsPresent > 0)
                    {
                        EmpManualAttendaceObj.isPresent = true;
                    }
                    else
                    {
                        EmpManualAttendaceObj.isPresent = false;
                    }
                    AttendanceDateWiseModelObjList.Add(EmpManualAttendaceObj);
                }
                return new JsonResult(AttendanceDateWiseModelObjList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet("GetEmployeesOnRole")]
        public async Task<JsonResult> GetEmployeesOnRole(long RoleId, long OrgId, string AttendanceDate)
        {
            try
            {
                DateTime DateAttendace = OnlyDateConvertToDateTime(AttendanceDate);

                var Employees = db.TblEmployees.Where(x => x.OrgId == OrgId).Select(y => new { y.Id, y.FirstName, y.MiddleName, y.LastName }).ToList().
                    Select(s => new { Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });

                if (RoleId != 0)
                {
                    Employees = db.TblEmployees.Where(x => x.OrgId == OrgId && x.RoleId == RoleId).Select(y => new { y.Id, y.FirstName, y.MiddleName, y.LastName }).ToList().
                   Select(s => new { Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });
                }

                List<EmpManualAttendace> AttendanceDateWiseModelObjList = new List<EmpManualAttendace>();
                foreach (var item in Employees)
                {
                    EmpManualAttendace EmpManualAttendaceObj = new EmpManualAttendace();
                    EmpManualAttendaceObj.Id = item.Id;
                    EmpManualAttendaceObj.Name = item.Name;
                    var IsPresent = db.TblEmployeeAttendances.Where(i => i.EmpId == item.Id && i.OrgId == OrgId && i.IsPresent == true && i.Date.Month == DateAttendace.Month && i.Date.Year == DateAttendace.Year && i.Date.Day == DateAttendace.Day).ToList().Count();
                    if (IsPresent > 0)
                    {
                        EmpManualAttendaceObj.isPresent = true;
                    }
                    else
                    {
                        EmpManualAttendaceObj.isPresent = false;
                    }
                    AttendanceDateWiseModelObjList.Add(EmpManualAttendaceObj);
                }
                return new JsonResult(AttendanceDateWiseModelObjList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("EmpManualAttendance")]
        public async Task<JsonResult> EmpManualAttendance(EmpManualAttendance EmpAttendanceManual)
        {
            try
            {
                DateTime AttendanceDate = OnlyDateConvertToDateTime(EmpAttendanceManual.dateAttendance);
                foreach (var temp in EmpAttendanceManual.AttendaceObj)
                {
                    var Duplicate = await db.TblEmployeeAttendances.Where(i => i.EmpId == temp.Id && i.OrgId == EmpAttendanceManual.OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i).FirstOrDefaultAsync();
                    if (Duplicate == null)
                    {
                        db.TblEmployeeAttendances.Add(new TblEmployeeAttendance()
                        {
                            EmpId = temp.Id,
                            Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                            IsPresent = temp.isPresent,
                            OrgId = EmpAttendanceManual.OrgId
                        });
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        Duplicate.IsPresent = temp.isPresent;
                        db.Entry(Duplicate).State = EntityState.Modified;
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
        [HttpPost("AddManualEmployeeAttendance")]

        public async Task<JsonResult> AddManualEmployeeAttendance(List<EmpManualAttendace> AttendaceObj, string dateAttendance, long OrgId)
        {
            try
            {
                DateTime AttendanceDate = OnlyDateConvertToDateTime(dateAttendance);
                foreach (var temp in AttendaceObj)
                {
                    var Duplicate = await db.TblEmployeeAttendances.Where(i => i.EmpId == temp.Id && i.OrgId == OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i).FirstOrDefaultAsync();
                    if (Duplicate == null)
                    {
                        db.TblEmployeeAttendances.Add(new TblEmployeeAttendance()
                        {
                            EmpId = temp.Id,
                            Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                            IsPresent = temp.isPresent,
                            OrgId = OrgId
                        });
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        Duplicate.IsPresent = temp.isPresent;
                        db.Entry(Duplicate).State = EntityState.Modified;
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

    }

}

