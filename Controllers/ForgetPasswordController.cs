using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using PaatashalaApi.Utility;
using System.Runtime.InteropServices;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgetPasswordController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public ForgetPasswordController(WebSchoolContext _db)
        {
            db = _db;
        }

        [HttpGet("GetPassword")]
        public async Task<JsonResult> GetPassword(string Email)
        {
            try
            {
                string message = string.Empty;
                var Password = "";

                var User = await db.TblAppLogins
            .Where(x => x.Email == Email)
            .Select(x => x)
            .SingleOrDefaultAsync();
                if (User != null)
                {
                    Password = SMSDataformatter.DecryptText(User.Password);
                    string Body = "<html><body> Hi there! <br /><br /> Your Password is:" + Password + "</body></html>";
                    string subject = "Password";

                    await EmailHelper.TrySendEmailAsync(subject, Body, Email);

                    message = string.Format("Password Sent to Your Email!");
                    return new JsonResult(new ErrorMessageDto { Status = true, Message = message });
                }
                else
                {
                    message = string.Format("Email Does Not Exist!");
                    return new JsonResult(new ErrorMessageDto { Status = false, Message = message });
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new ErrorMessageDto { Status = false, Message = ex.ToString() });
            }
        }
        private async Task<OrgIdNameDto?> GetOrgDetailsAsync(string orgName)
        {
            OrgIdNameDto? data = await db.TblOrgs
                .Where(x => x.OrgName.ToLower() == orgName)
                .Select(x => new OrgIdNameDto { OrgId = x.Id, OrgName = x.OrgName })
                .SingleOrDefaultAsync();
            return data;
        }

        [HttpGet("GetEmployeePassword")]
        public async Task<JsonResult> GetEmployeePassword(string Email, string OrgName)
        {
            try
            {
                OrgIdNameDto? orgDetails = await GetOrgDetailsAsync(OrgName.Trim().ToLower());

                if (orgDetails != null)
                {
                    long loggedUserOrgid = orgDetails.OrgId;

                    var loggedUser = await db.TblLogins
                        .Where(x => x.UserName.ToLower() == Email.ToLower() && x.OrgId == loggedUserOrgid)
                        .FirstOrDefaultAsync();

                    if (loggedUser != null)
                    {
                        var decryptedPassword = SMSDataformatter.DecryptText(loggedUser.Password);
                        string body = $"<html><body> Hi there! <br /><br /> Your Password is: {decryptedPassword} </body></html>";
                        string subject = "Password";

                        await EmailHelper.TrySendEmailAsync(subject, body, Email);

                        string message = "Password Sent to Your Email!";
                        return new JsonResult(new { status = true, Message = message });
                    }
                    else
                    {
                        string message = "Email Not Exist!";
                        return new JsonResult(new { status = false, Message = message });
                    }
                }
                else
                {
                    string message = "OrgName Not Exist!";
                    return new JsonResult(new { status = false, Message = message });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(500, new { status = false, message = "An error occurred while processing the request." });
            }
        }
        [HttpPost("GetEmployeePasswordNew")]
        public async Task<JsonResult> GetEmployeePasswordNew(EmpPassCredential cred)
        {
            try
            {
                var Password = "";
                string message = string.Empty;

                OrgIdNameDto? OrgDetails = await GetOrgDetailsAsync(cred.OrgName.Trim().ToLower());
                if (OrgDetails != null)
                {
                    long loggedUserOrgid = OrgDetails.OrgId;

                    var loggedUser = await db.TblLogins
                        .Where(x => x.UserName.ToLower() == cred.Email.ToLower() && x.OrgId == loggedUserOrgid)
                        .Select(x => x)
                        .SingleOrDefaultAsync();

                    if (loggedUser != null)
                    {
                        Password = SMSDataformatter.DecryptText(loggedUser.Password);
                        string Body = $"<html><body> Hi there! <br /><br /> Your Password is: {Password}</body></html>";
                        string subject = "Password";

                        await EmailHelper.TrySendEmailAsync(subject, Body, cred.Email);

                        message = string.Format("Password Sent to Your Email!");
                        return new JsonResult(new { status = true, Message = message });
                    }
                    else
                    {
                        message = string.Format("Email Not Exist!");
                        return new JsonResult(new { status = false, Message = message });
                    }
                }
                else
                {
                    message = string.Format("OrgName Not Exist!");
                    return new JsonResult(new { status = false, Message = message });
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }
}
