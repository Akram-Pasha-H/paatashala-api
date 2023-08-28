using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.HelperObject;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public UserController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpPost("Login")]
        public async Task<JsonResult> Login([FromForm] ParentLoginDto parentLogin)
        {
            string message = string.Empty;
            try
            {

                var data = (from tableLogin in db.TblAppLogins
                            where tableLogin.Email == parentLogin.Username && tableLogin.IsRegistered == true
                            select new { Password = tableLogin.Password, Username = tableLogin.Email, tableLogin.Id, OrgId = tableLogin }).SingleOrDefault();
                if (data != null)
                {

                    var Pwd = SMSDataformatter.DecryptText(data.Password);
                    if (SMSDataformatter.DecryptText(data.Password) == parentLogin.Password)
                    {
                        var HasStudents = (from StudentTable in db.TblStudents
                                           join StudentRegistration in db.TblStudentRegistrations on StudentTable.Id equals StudentRegistration.StudentId
                                           where StudentTable.FatherEmail == parentLogin.Username || StudentTable.MotherEmail == parentLogin.Username
                                           select new
                                           {
                                               StudentTable.Id,
                                               StudentTable.FirstName,
                                               StudentTable.MiddleName,
                                               StudentTable.LastName,
                                               StudentRegistration.RegistrationCode,
                                               StudentRegistration.Course,
                                               StudentRegistration.Batch,
                                               StudentTable.OrgId,
                                               StudentTable.FatherName,
                                               StudentTable.Sex
                                           }).ToList().Select(s => new { Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id, s.Batch, s.Course, s.FatherName, s.RegistrationCode, s.OrgId, s.Sex });

                        //var token = TokenHelper.GenerateToken(data.Username, data.Password, DateTime.UtcNow.Ticks);
                        var token = "";

                        return new JsonResult(new { Status = true, Token = token, User = new { Username = data.Username, UserId = data.Id, OrgId = HasStudents.Count() > 0 ? HasStudents.First().OrgId : 0 }, HasStudents });
                    }
                    else
                    {
                        message = string.Format("Password wrong!", parentLogin.Username);
                        return new JsonResult(new { Status = false, Message = message });
                    }
                }
                else
                {
                    message = string.Format("{0} not exists!", parentLogin.Username);
                    return new JsonResult(new { Status = false, Message = message });
                }
            }
            catch (Exception e)
            {
                return  new JsonResult(new { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("EmployeeLogin")]
        public async Task<JsonResult> EmployeeLogin([FromForm] EmployeeLoginDto employee)

        {
            string message = string.Empty;
            try
            {
                var OrgDetails = GetOrgDetails(employee.OrgName.Trim().ToLower()).Result;
                if (OrgDetails != null)
                {
                    long loggedUserOrgid = OrgDetails.OrgId;
                    var loggedUser = db.TblLogins.Where(x => x.UserName.ToLower() == employee.Username.ToLower() &&
                        x.OrgId == loggedUserOrgid && x.IsActive == true).Select(x => x).SingleOrDefault();
                    var EmployeeRole = (from role in db.TblRoles
                                        join EmployeeTable in db.TblEmployees on role.Id equals EmployeeTable.RoleId
                                        where EmployeeTable.Id == loggedUser.UserId
                                        select role.RoleName).FirstOrDefault();
                    if (loggedUser != null)
                    {
                        if (SMSDataformatter.DecryptText(loggedUser.Password) == employee.Password)
                        {
                            var token = TokenHelper.GenerateToken(loggedUser.UserName, loggedUser.Password, DateTime.UtcNow.Ticks);

                            return new JsonResult(new { Status = true, Token = token, User = new { Username = loggedUser.UserName, OrgId = loggedUser.OrgId, UserId = loggedUser.UserId, Role = EmployeeRole } });
                        }
                        else
                        {
                            message = string.Format("Password wrong!", employee.Username);
                            return new JsonResult(new { Status = false, Message = message });
                        }
                    }
                    else
                    {
                        message = string.Format("{0} not exists!", employee.Username);
                        return new JsonResult(new { Status = false, Message = message });
                    }
                }
                else
                {
                    message = string.Format("Organiztion Name not exists!");
                    return new JsonResult(new { Status = false, Message = message });
                }
            }
            catch (Exception e)
            {
                return new JsonResult(new { message = e.ToString(), status = false });
            }

        }
        [HttpGet("GetOrgDetails")]
        public async Task<OrgIdNameDto?> GetOrgDetails(string orgName)
        {
            try
            {

                OrgIdNameDto? abc = db.TblOrgs.Where(x => x.OrgName.ToLower() == orgName && x.OrgType == 1).Select(x => new OrgIdNameDto { OrgId = x.Id, OrgName = x.OrgName }).SingleOrDefault();
                return abc;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet("TMFEmployeeLogin")]
        public async Task<JsonResult> TMFEmployeeLogin(string Username, string Password, string OrgName)
        {
            {
                string message = string.Empty;
                try
                {
                    var OrgDetails = GetTMFOrgDetails(OrgName.Trim().ToLower());
                    if (OrgDetails != null)
                    {
                        long loggedUserOrgid = Convert.ToInt64(OrgDetails.GetType().GetProperty("OrgId").GetValue(OrgDetails, null));
                        var loggedUser = db.TblLogins.Where(x => x.UserName.ToLower() == Username.ToLower() &&
                            x.OrgId == loggedUserOrgid && x.IsActive == true).Select(x => x).SingleOrDefault();
                        var EmployeeRole = (from role in db.TblRoles
                                            join EmployeeTable in db.TblEmployees on role.Id equals EmployeeTable.RoleId
                                            where EmployeeTable.Id == loggedUser.UserId
                                            select role.RoleName).FirstOrDefault();
                        if (loggedUser != null)
                        {
                            if (SMSDataformatter.DecryptText(loggedUser.Password) == Password)
                            {
                                var token = TokenHelper.GenerateToken(loggedUser.UserName, loggedUser.Password, DateTime.UtcNow.Ticks);

                                return new JsonResult(new { Status = true, Token = token, User = new { Username = loggedUser.UserName, OrgId = loggedUser.OrgId, UserId = loggedUser.UserId, Role = EmployeeRole } });
                            }
                            else
                            {
                                message = string.Format("Password wrong!", Username);
                                return new(new { Status = false, Message = message });
                            }
                        }
                        else
                        {
                            message = string.Format("{0} not exists!", Username);
                            return new JsonResult(new { Status = false, Message = message });
                        }
                    }
                    else
                    {
                        message = string.Format("Organiztion Name not exists!");
                        return new JsonResult(new { Status = false, Message = message });
                    }
                }
                catch (Exception e)
                {
                    return new JsonResult(new { message = e.ToString(), status = false });
                }
            }
        }
        [HttpGet("GetTMFOrgDetails")]
        public async Task<JsonResult> GetTMFOrgDetails(string orgName)
        {
            try
            {

                {
                   
                    return new JsonResult(db.TblOrgs.Where(x => x.OrgName.ToLower() == orgName && x.OrgType == 3).Select(x => new { OrgId = x.Id, OrgName = x.OrgName }).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet("ERPEmployeeLogin")]
        public async Task<JsonResult> ERPEmployeeLogin(string Username, string Password, string OrgName)
        {
            try
            {

                {
                    string message = string.Empty;
                    try
                    {
                        var OrgDetails = GetERPOrgDetails(OrgName.Trim().ToLower());
                        if (OrgDetails != null)
                        {
                            long loggedUserOrgid = Convert.ToInt64(OrgDetails.GetType().GetProperty("OrgId").GetValue(OrgDetails, null));
                            var loggedUser = db.TblLogins.Where(x => x.UserName.ToLower() == Username.ToLower() &&
                                x.OrgId == loggedUserOrgid && x.IsActive == true).Select(x => x).SingleOrDefault();
                            var EmployeeRole = (from role in db.TblRoles
                                                join EmployeeTable in db.TblEmployees on role.Id equals EmployeeTable.RoleId
                                                where EmployeeTable.Id == loggedUser.UserId
                                                select role.RoleName).FirstOrDefault();
                            if (loggedUser != null)
                            {
                                if (SMSDataformatter.DecryptText(loggedUser.Password) == Password)
                                {
                                    var token = TokenHelper.GenerateToken(loggedUser.UserName, loggedUser.Password, DateTime.UtcNow.Ticks);

                                    return new JsonResult(new { Status = true, Token = token, User = new { Username = loggedUser.UserName, OrgId = loggedUser.OrgId, UserId = loggedUser.UserId, Role = EmployeeRole } });
                                }
                                else
                                {
                                    message = string.Format("Password wrong!", Username);
                                    return new JsonResult(new { Status = false, Message = message });
                                }
                            }
                            else
                            {
                                message = string.Format("{0} not exists!", Username);
                                return new JsonResult(new { Status = false, Message = message });
                            }
                        }
                        else
                        {
                            message = string.Format("Organiztion Name not exists!");
                            return new JsonResult(new { Status = false, Message = message });
                        }
                    }
                    catch (Exception e)
                    {
                        return new JsonResult(new { message = e.ToString(), status = false });
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private object GetERPOrgDetails(string orgName)
        {
           
            return db.TblOrgs.Where(x => x.OrgName.ToLower() == orgName && x.OrgType == 2).Select(x => new { OrgId = x.Id, OrgName = x.OrgName }).SingleOrDefault();
        }
        [HttpPost("UpdateToken")]
        public async Task<JsonResult> UpdateToken(long UserId, string SenderId)
        {
            try
            {
                var User = db.TblAppLogins.Where(x => x.Id == UserId).Select(y => y).SingleOrDefault();
                User.SenderId = SenderId;
                db.Entry(User).State = EntityState.Modified;
                db.SaveChanges();
                return new JsonResult(new { status = true });
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
    

    
}
