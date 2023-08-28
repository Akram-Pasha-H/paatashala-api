using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using PaatashalaApi.Utility;
using System.Text;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentRegistrationController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public ParentRegistrationController(WebSchoolContext _db)
        {
            db = _db;
        }
        TblAppLogin tblAppLoginobj = new TblAppLogin();

        [HttpGet("SendEmailVerificationCode")]
        public async Task<JsonResult> SendEmailVerificationCode(string Email)
        {
            try
            {
                string message = string.Empty;
                var HasStudent = await db.TblStudents
                    .Where(x => x.FatherEmail == Email || x.MotherEmail == Email)
                    .Select(u => u.StudentId)
                    .ToListAsync();
                if (HasStudent.Count != 0)
                {
                    var HasDuplicate = await db.TblAppLogins
                       .Where(x => x.Email == Email && x.IsRegistered == true)
                       .Select(x => new { x.Email })
                       .SingleOrDefaultAsync();

                    if (HasDuplicate == null)
                    {
                        var Duplicate = await db.TblAppLogins
                            .Where(x => x.Email == Email)
                             .SingleOrDefaultAsync();
                        if (Duplicate == null)
                        {
                            tblAppLoginobj.Email = Email;
                            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            Random rand = new Random();
                            int size = 6;
                            StringBuilder Passcode = new StringBuilder();
                            char[] chars = new char[size];
                            for (int i = 0; i < size; i++)
                            {
                                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
                                Passcode.Append(chars[i]);
                            }
                            tblAppLoginobj.IsRegistered = false;
                            tblAppLoginobj.Passcode = Passcode.ToString();

                            db.TblAppLogins.Add(tblAppLoginobj);
                            await db.SaveChangesAsync();

                            string Body = "<html><body> Hi there! <br /><br /> Your Verification Code is:" + Passcode + "</body></html>";
                            string subject = "Verification Code";
                            await EmailHelper.TrySendEmailAsync(subject, Body, Email);
                            return new JsonResult(new { status = true });
                        }
                        else
                        {
                            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            Random rand = new Random();
                            int size = 6;
                            StringBuilder Passcode = new StringBuilder();
                            char[] chars = new char[size];

                            for (int i = 0; i < size; i++)
                            {
                                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
                                Passcode.Append(chars[i]);
                            }

                            tblAppLoginobj.IsRegistered = false;
                            Duplicate.Passcode = Passcode.ToString();
                            tblAppLoginobj.Passcode = Passcode.ToString();

                            db.Entry(Duplicate).State = EntityState.Modified;
                            await db.SaveChangesAsync();

                            string Body = "<html><body> Hi there! <br /><br /> Your Verification Code is:" + Passcode + "</body></html>";
                            string subject = "Verification Code";
                            //await EmailHelper.TrySendEmailAsync(subject, Body, Email);
                            return new JsonResult(new { status = true });
                        }

                    }
                    else
                    {
                        message = string.Format("Already Registered!");
                        return new JsonResult(new { status = false, Message = message });
                    }
                }
                else
                {
                    message = string.Format("Email Not Saved As Parents Email");
                    return new JsonResult(new { status = false, Message = message });
                }

            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, Message = e.ToString() });
            }
        }
        [HttpGet("VerifyCode")]
        public async Task<JsonResult> VerifyCode(string Passcode, string Email)
        {
            try
            {
                string message = string.Empty;
                var Code = await db.TblAppLogins
                    .Where(tableAppLogin => tableAppLogin.Email == Email && tableAppLogin.Passcode == Passcode)
                    .SingleOrDefaultAsync();

                if (Code != null)
                {
                    return new JsonResult(new { status = true });
                }
                else
                {
                    message = "Passcode is Not Valid";
                    return new JsonResult(new { status = false, Message = message });
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }


        [HttpPost("SavePassword")]
        public async Task<JsonResult> SavePassword(string Email, string Password)
        {
            try
            {
                var User = await db.TblAppLogins
                    .Where(tableAppLogin => tableAppLogin.Email == Email)
                    .FirstOrDefaultAsync();

                if (User != null)
                {
                    User.Password = SMSDataformatter.EncryptText(Password);
                    User.IsRegistered = true;
                    db.Entry(User).State = EntityState.Modified;
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
    }


}
