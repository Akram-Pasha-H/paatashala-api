using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttandanceController : ControllerBase
    {
        private readonly WebSchoolContext db;
        private long orgId;

        public AttandanceController(WebSchoolContext _db)
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

        private DateTime ConvertToDateTime(string input)
        {
            DateTime dateTime;
            DateTime dt = DateTime.ParseExact(input.Substring(0, 24),
                              "ddd MMM dd yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return dt;
        }

        [HttpGet("GetStudentsList")]
        public async Task<JsonResult> GetStudentsList(long OrgId)
        {
            try
            {
                var AdmStudents = await (from tableStudent in db.TblStudents
                                         join tableBatchAdmission in db.TblBatchAdmissions on tableStudent.Id equals tableBatchAdmission.StudentId
                                         where tableBatchAdmission.OrgId == OrgId && tableStudent.IsLead == false
                                         select new
                                         {
                                             tableStudent.FirstName,
                                             tableStudent.MiddleName,
                                             tableStudent.LastName,
                                             tableStudent.Id,
                                             tableStudent.StudentId
                                         })
                                                .ToListAsync();
                var studentList = AdmStudents.Select(s => new
                {
                    Name = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                    s.Id,
                    s.StudentId
                }).ToList();
                return new JsonResult(new { AdmStudents = studentList });
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("GetStudentsListNew")]
        public async Task<JsonResult> getStudentsListNew(long OrgId)
        {
            var AdmStudents = (from tableStudent in db.TblStudents
                               join tableBatchAdmission in db.TblBatchAdmissions on tableStudent.Id equals tableBatchAdmission.StudentId
                               where tableBatchAdmission.OrgId == OrgId && tableStudent.IsLead == false
                               select new
                               {
                                   FirstName = tableStudent.FirstName,
                                   MiddleName = tableStudent.MiddleName,
                                   LastName = tableStudent.LastName,
                                   tableStudent.Id,
                                   tableStudent.StudentId
                               }).ToList()
                               .Select(s => new { Name = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id, s.StudentId });
            return new JsonResult(AdmStudents);
        }
        [HttpGet("SaveAttendance")]
        public async Task<JsonResult> SaveAttendance(long OrgId, string StudentId, string scanDateTime, bool IsCheckIn)
        {

            {
                try
                {
                    DuplicateAttendance DuplicateAttendanceObj = new DuplicateAttendance();
                    var datee = ConvertToDateTime(scanDateTime);
                    var NowDate = new DateTime(datee.Year, datee.Month, datee.Day);
                    string[] arrlong = null;
                    if (StudentId.Contains(','))
                    {
                        arrlong = StudentId.Split(',');
                    }
                    else
                    {
                        arrlong = new string[] { StudentId };
                    }
                    DuplicateAttendanceObj.DuplicatesList = new List<Dupicates>();

                    if (IsCheckIn == true)
                    {
                        foreach (var temp in arrlong)
                        {
                            long StudId = Convert.ToInt64(temp);
                            var DuplicateCheckIn = db.TblAttendanceHourlies.Where(x => x.OrgId == OrgId && x.StudentId == StudId && x.Date == NowDate && x.IsAttendance == true).OrderByDescending(x => x.Time).Take(1).Select(y => y).FirstOrDefault();
                            if (DuplicateCheckIn == null || DuplicateCheckIn.IsPickUp == false)
                            {
                                db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                                {
                                    StudentId = Convert.ToInt64(temp),
                                    IsPickUp = IsCheckIn,
                                    IsAttendance = true,
                                    Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                                    Date = new DateTime(datee.Year, datee.Month, datee.Day),
                                    OrgId = OrgId
                                });
                                db.SaveChanges();
                            }
                            else
                            {
                                var StudnetDuplicate = new Dupicates();
                                DuplicateAttendanceObj.DuplicatesList.Add(StudnetDuplicate);
                                StudnetDuplicate.StudentId = Convert.ToInt64(temp);
                                DuplicateAttendanceObj.ReasonDuplicate = "Already Checked In";
                            }
                        }
                        return new JsonResult(new  { Status = true, DuplicateAttendanceObj });
                    }
                    else
                    {
                        foreach (var temp in arrlong)
                        {
                            long StudId = Convert.ToInt64(temp);
                            var Dup = db.TblAttendanceHourlies.Where(x => x.OrgId == OrgId && x.StudentId == StudId && x.Date == NowDate && x.IsAttendance == true && x.IsPickUp == true).OrderByDescending(x => x.Time).Take(1).Select(y => y).FirstOrDefault();
                            if (Dup != null)
                            {
                                var d = new TimeSpan(Dup.Time.Hours, Dup.Time.Minutes, Dup.Time.Seconds);
                                var e = new TimeSpan(datee.Hour, datee.Minute, datee.Second);
                                TimeSpan f = e.Subtract(d);
                                if (f.Hours >= 2)
                                {
                                    db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                                    {
                                        StudentId = Convert.ToInt64(temp),
                                        IsPickUp = IsCheckIn,
                                        IsAttendance = true,
                                        Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                                        Date = new DateTime(datee.Year, datee.Month, datee.Day),
                                        OrgId = OrgId
                                    });
                                    db.SaveChanges();
                                }
                                else
                                {
                                    var StudnetDuplicate = new Dupicates();
                                    DuplicateAttendanceObj.DuplicatesList.Add(StudnetDuplicate);
                                    StudnetDuplicate.StudentId = Convert.ToInt64(temp);
                                    DuplicateAttendanceObj.ReasonDuplicate = "Below 2 Hrs Checkin";
                                }
                            }
                            else
                            {
                                var StudnetDuplicate = new Dupicates();
                                DuplicateAttendanceObj.DuplicatesList.Add(StudnetDuplicate);
                                StudnetDuplicate.StudentId = Convert.ToInt64(temp);
                                DuplicateAttendanceObj.ReasonDuplicate = "Not Checkin can't CheckOut";
                            }
                        }
                        return new JsonResult(new { status = true, DuplicateAttendanceObj });
                    }

                }
                catch (Exception e)
                {
                    return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
                }

            }
        }

        [HttpGet("SaveTransport")]
        public async Task<JsonResult> SaveTransport(long OrgId, string StudentId, string scanDateTime, bool IsPickUp, string Position)
        {
            string Status = "";
            try
            {
                var datee = ConvertToDateTime(scanDateTime);
                string[] arrlong = null;
                if (StudentId.Contains(','))
                {
                    arrlong = StudentId.Split(',');
                }
                else
                {
                    arrlong = new string[] { StudentId };
                }

                foreach (var temp in arrlong)
                {
                    db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                    {
                        StudentId = Convert.ToInt64(temp),
                        IsPickUp = IsPickUp,
                        Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                        Date = new DateTime(datee.Year, datee.Month, datee.Day),
                        IsAttendance = false,
                        OrgId = OrgId
                    });
                    await db.SaveChangesAsync();

                    var SId = Convert.ToInt64(temp);
                    var Student = await db.TblStudents.Where(x => x.Id == SId).Select(y => y).FirstOrDefaultAsync();
                    string Number = "+91" + Student.FatherContactNo;
                    string Username = "sftg-softserve";
                    string Password = "soft123";
                    string Source = "SSGBLR";
                    if (Position == "School")
                    {
                        if (IsPickUp == true)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has boarded the vehicle for school.";
                        }
                        else if (IsPickUp == false)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has reached the school.";
                        }
                    }
                    else if (Position == "Home")
                    {
                        if (IsPickUp == true)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has boarded the vehicle for home.";
                        }
                        else if (IsPickUp == false)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has reached the home.";
                        }
                    }
                    string Content = Status;
                    string strUrl = "http://103.16.101.52:8080/sendsms/bulksms?username=" + Username + "&password=" + Password + "&type=0&dlr=1&destination=" + Number + "&source=" + Source + "&message=" + Content;
                    HttpWebRequest _createRequest = (HttpWebRequest)WebRequest.Create(strUrl);
                    HttpWebResponse response = (HttpWebResponse)_createRequest.GetResponse();
                    Stream s = (Stream)response.GetResponseStream();
                    StreamReader readStream = new StreamReader(s);
                    string dataString = readStream.ReadToEnd();
                    response.Close();
                    s.Close();
                    readStream.Close();
                }
                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("GetTransportStudentsBasedOnFilter")]
        public async Task<JsonResult> GetTransportStudentsBasedOnFilter(TransportStudentsAttendanceDto TransportStudentObj)
        {
            try
            {
                var DateAttendace = OnlyDateConvertToDateTime(TransportStudentObj.AttendanceDate);
                var Students = (from batchAdmission in db.TblBatchAdmissions
                                join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                where batchAdmission.OrgId == TransportStudentObj.OrgId && batchAdmission.CourseId == TransportStudentObj.CourseId &&
                                batchAdmission.BatchId == TransportStudentObj.BatchId
                                select new
                                {
                                    FirstName = student.FirstName,
                                    MiddleName = student.MiddleName,
                                    LastName = student.LastName,
                                    student.Id
                                }).ToList().
                                 Select(s => new { StudentName = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });
                List<DailyAttendanceDto> AttendanceDateWiseModelObjList = new List<DailyAttendanceDto>();
                if (TransportStudentObj.Choice == true)
                {
                    foreach (var StuObj in Students)
                    {
                        DailyAttendanceDto AttendanceDateWiseModelObj = new DailyAttendanceDto();
                        AttendanceDateWiseModelObj.Id = StuObj.Id;
                        AttendanceDateWiseModelObj.StudentName = StuObj.StudentName;

                        var IsPresent = db.TblAttendanceHourlies.Where(i => i.StudentId == StuObj.Id && i.OrgId == TransportStudentObj.OrgId && i.IsAttendance == false && i.Date.Year == DateAttendace.Year && i.Date.Month == DateAttendace.Month && i.Date.Day == DateAttendace.Day && i.IsPickUp == TransportStudentObj.Choice).ToList().Count();
                        if (IsPresent > 0)
                        {
                            AttendanceDateWiseModelObj.isPresent = true;
                        }
                        else
                        {
                            AttendanceDateWiseModelObj.isPresent = false;
                        }
                        AttendanceDateWiseModelObjList.Add(AttendanceDateWiseModelObj);
                    }
                }
                else
                {
                    foreach (var StuObj in Students)
                    {
                        DailyAttendanceDto AttendanceDateWiseModelObj = new DailyAttendanceDto();
                        AttendanceDateWiseModelObj.Id = StuObj.Id;
                        AttendanceDateWiseModelObj.StudentName = StuObj.StudentName;

                        var IsPresent = db.TblAttendanceHourlies.Where(i => i.StudentId == StuObj.Id && i.OrgId == TransportStudentObj.OrgId && i.IsAttendance == false && i.Date.Year == DateAttendace.Year && i.Date.Month == DateAttendace.Month && i.Date.Day == DateAttendace.Day && i.IsPickUp == TransportStudentObj.Choice).ToList().Count();
                        if (IsPresent > 0)
                        {
                            AttendanceDateWiseModelObj.isPresent = true;
                        }
                        else
                        {
                            AttendanceDateWiseModelObj.isPresent = false;
                        }
                        AttendanceDateWiseModelObjList.Add(AttendanceDateWiseModelObj);
                    }
                }
                return new JsonResult(AttendanceDateWiseModelObjList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("GetTransportStudentsBasedOnFiler")]
        public async Task<JsonResult> GetTransportStudentsBasedOnFiler(long CourseId, long BatchId, long OrgId, string AttendanceDate, bool Choice)
        {
            try
            {
                var DateAttendace = OnlyDateConvertToDateTime(AttendanceDate);
                var Students = (from batchAdmission in db.TblBatchAdmissions
                                join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                where batchAdmission.OrgId == OrgId && batchAdmission.CourseId == CourseId &&
                                batchAdmission.BatchId == BatchId
                                select new
                                {
                                    FirstName = student.FirstName,
                                    MiddleName = student.MiddleName,
                                    LastName = student.LastName,
                                    student.Id
                                }).ToList().
                                 Select(s => new { StudentName = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });
                List<DailyAttendanceDto> AttendanceDateWiseModelObjList = new List<DailyAttendanceDto>();
                if (Choice == true)
                {
                    foreach (var StuObj in Students)
                    {
                        DailyAttendanceDto AttendanceDateWiseModelObj = new DailyAttendanceDto();
                        AttendanceDateWiseModelObj.Id = StuObj.Id;
                        AttendanceDateWiseModelObj.StudentName = StuObj.StudentName;

                        var IsPresent = db.TblAttendanceHourlies.Where(i => i.StudentId == StuObj.Id && i.OrgId == OrgId && i.IsAttendance == false && i.Date.Year == DateAttendace.Year && i.Date.Month == DateAttendace.Month && i.Date.Day == DateAttendace.Day && i.IsPickUp == Choice).ToList().Count();
                        if (IsPresent > 0)
                        {
                            AttendanceDateWiseModelObj.isPresent = true;
                        }
                        else
                        {
                            AttendanceDateWiseModelObj.isPresent = false;
                        }
                        AttendanceDateWiseModelObjList.Add(AttendanceDateWiseModelObj);
                    }
                }
                else
                {
                    foreach (var StuObj in Students)
                    {
                        DailyAttendanceDto AttendanceDateWiseModelObj = new DailyAttendanceDto();
                        AttendanceDateWiseModelObj.Id = StuObj.Id;
                        AttendanceDateWiseModelObj.StudentName = StuObj.StudentName;

                        var IsPresent = db.TblAttendanceHourlies.Where(i => i.StudentId == StuObj.Id && i.OrgId == OrgId && i.IsAttendance == false && i.Date.Year == DateAttendace.Year && i.Date.Month == DateAttendace.Month && i.Date.Day == DateAttendace.Day && i.IsPickUp == Choice).ToList().Count();
                        if (IsPresent > 0)
                        {
                            AttendanceDateWiseModelObj.isPresent = true;
                        }
                        else
                        {
                            AttendanceDateWiseModelObj.isPresent = false;
                        }
                        AttendanceDateWiseModelObjList.Add(AttendanceDateWiseModelObj);
                    }
                }
                return new JsonResult(AttendanceDateWiseModelObjList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("SaveStudTransportAttendanceManual")]
        public async Task<JsonResult> SaveStudTransportAttendanceManual(SaveStudTransportAttendanceMDto TransportObject)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(TransportObject.dateAttendance);
                // var AttendanceDate = DateTime.Now;
                foreach (var temp in TransportObject.DailyTransportAttendanceObj)
                {
                    if (temp.isPresent == true)
                    {
                        if (TransportObject.Choice == true)
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = true,
                                IsAttendance = false,
                                //Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                Time = new TimeSpan(AttendanceDate.Hour, AttendanceDate.Minute, AttendanceDate.Second),
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = TransportObject.OrgId
                            });
                            await db.SaveChangesAsync();
                        }
                        else
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = false,
                                IsAttendance = false,
                                // Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                Time = new TimeSpan(AttendanceDate.Hour, AttendanceDate.Minute, AttendanceDate.Second),
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = TransportObject.OrgId
                            });
                            await db.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        var DeleteAttendance = db.TblAttendanceHourlies.Where(i => i.StudentId == temp.Id && i.OrgId == TransportObject.OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i.Id).ToList();
                        foreach (var i in DeleteAttendance)
                        {
                            db.TblAttendanceHourlies.Remove(db.TblAttendanceHourlies.Where(x => x.Id == i).Single());
                            await db.SaveChangesAsync();
                        }
                    }
                }
                return new JsonResult(new ErrorMessageDto { Status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("SaveStudentTransportManualAttendance")]
        public async Task<JsonResult> SaveStudentTransportManualAttendance(List<DailyAttendanceDto> DailyTransportAttendanceObj, string dateAttendance, long OrgId, bool Choice)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(dateAttendance);
                // var AttendanceDate = DateTime.Now;
                foreach (var temp in DailyTransportAttendanceObj)
                {
                    if (temp.isPresent == true)
                    {
                        if (Choice == true)
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = true,
                                IsAttendance = false,
                                //Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                Time = new TimeSpan(AttendanceDate.Hour, AttendanceDate.Minute, AttendanceDate.Second),
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = OrgId
                            });
                             await db.SaveChangesAsync();
                        }
                        else
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = false,
                                IsAttendance = false,
                                // Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                Time = new TimeSpan(AttendanceDate.Hour, AttendanceDate.Minute, AttendanceDate.Second),
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = OrgId
                            });
                            await db.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        var DeleteAttendance = db.TblAttendanceHourlies.Where(i => i.StudentId == temp.Id && i.OrgId == OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i.Id).ToList();
                        foreach (var i in DeleteAttendance)
                        {
                            db.TblAttendanceHourlies.Remove(db.TblAttendanceHourlies.Where(x => x.Id == i).Single());
                            await db.SaveChangesAsync();
                        }
                    }
                }
                return new JsonResult(new ErrorMessageDto { Status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("SaveAttendanceNew")]
        public async Task<JsonResult> SaveAttendanceNew(StudentBCAttendanceDataDto std)
        {
            try
            {
                DuplicateAttendance DuplicateAttendanceObj = new DuplicateAttendance();
                var datee = ConvertToDateTime(std.scanDateTime);
                var NowDate = new DateTime(datee.Year, datee.Month, datee.Day);
                string[] arrlong = null;
                if (std.StudentId.Contains(','))
                {
                    arrlong = std.StudentId.Split(',');
                }
                else
                {
                    arrlong = new string[] { std.StudentId };
                }
                DuplicateAttendanceObj.DuplicatesList = new List<Dupicates>();

                if (std.IsCheckIn == true)
                {
                    foreach (var temp in arrlong)
                    {
                        long StudId = Convert.ToInt64(temp);
                        var DuplicateCheckIn = db.TblAttendanceHourlies.Where(x => x.OrgId == std.OrgId && x.StudentId == StudId && x.Date == NowDate && x.IsAttendance == true).OrderByDescending(x => x.Time).Take(1).Select(y => y).FirstOrDefault();
                        if (DuplicateCheckIn == null || DuplicateCheckIn.IsPickUp == false)
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = Convert.ToInt64(temp),
                                IsPickUp = std.IsCheckIn,
                                IsAttendance = true,
                                Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                                Date = new DateTime(datee.Year, datee.Month, datee.Day),
                                OrgId = std.OrgId
                            });
                           await db.SaveChangesAsync();
                        }
                        else
                        {
                            var StudnetDuplicate = new Dupicates();
                            DuplicateAttendanceObj.DuplicatesList.Add(StudnetDuplicate);
                            StudnetDuplicate.StudentId = Convert.ToInt64(temp);
                            DuplicateAttendanceObj.ReasonDuplicate = "Already Checked In";
                        }
                    }
                    return new JsonResult(new { Status = true, DuplicateAttendanceObj });
                }
                else
                {
                    foreach (var temp in arrlong)
                    {
                        long StudId = Convert.ToInt64(temp);
                        var Dup = db.TblAttendanceHourlies.Where(x => x.OrgId == std.OrgId && x.StudentId == StudId && x.Date == NowDate && x.IsAttendance == true && x.IsPickUp == true).OrderByDescending(x => x.Time).Take(1).Select(y => y).FirstOrDefault();
                        if (Dup != null)
                        {
                            var d = new TimeSpan(Dup.Time.Hours, Dup.Time.Minutes, Dup.Time.Seconds);
                            var e = new TimeSpan(datee.Hour, datee.Minute, datee.Second);
                            TimeSpan f = e.Subtract(d);
                            if (f.Hours >= 2)
                            {
                                db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                                {
                                    StudentId = Convert.ToInt64(temp),
                                    IsPickUp = std.IsCheckIn,
                                    IsAttendance = true,
                                    Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                                    Date = new DateTime(datee.Year, datee.Month, datee.Day),
                                    OrgId = std.OrgId
                                });
                                await db.SaveChangesAsync();
                            }
                            else
                            {
                                var StudnetDuplicate = new Dupicates();
                                DuplicateAttendanceObj.DuplicatesList.Add(StudnetDuplicate);
                                StudnetDuplicate.StudentId = Convert.ToInt64(temp);
                                DuplicateAttendanceObj.ReasonDuplicate = "Below 2 Hrs Checkin";
                            }
                        }
                        else
                        {
                            var StudnetDuplicate = new Dupicates();
                            DuplicateAttendanceObj.DuplicatesList.Add(StudnetDuplicate);
                            StudnetDuplicate.StudentId = Convert.ToInt64(temp);
                            DuplicateAttendanceObj.ReasonDuplicate = "Not Checkin can't CheckOut";
                        }
                    }
                    return new JsonResult(new  { status = true, DuplicateAttendanceObj });
                }

            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("SaveTransportNew")]
        public async Task<JsonResult> SaveTransportNew(TransportAttendanceDataDto std)
        {
            string Status = "";
            try
            {
                var datee = ConvertToDateTime(std.scanDateTime);
                string[] arrlong = null;
                if (std.StudentId.Contains(','))
                {
                    arrlong = std.StudentId.Split(',');
                }
                else
                {
                    arrlong = new string[] { std.StudentId };
                }


                foreach (var temp in arrlong)
                {
                    db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                    {
                        StudentId = Convert.ToInt64(temp),
                        IsPickUp = std.IsPickUp,
                        Time = new TimeSpan(datee.Hour, datee.Minute, datee.Second),
                        Date = new DateTime(datee.Year, datee.Month, datee.Day),
                        IsAttendance = false,
                        OrgId = std.OrgId
                    });
                    await db.SaveChangesAsync();
                    /*
                    var SId = Convert.ToInt64(temp);
                    var Student = DbContext.tblStudents.Where(x => x.Id == SId).Select(y => y).FirstOrDefault();
                    string Number = "+91" + Student.FatherContactNo;
                    string Username = "sftg-softserve";
                    string Password = "soft123";
                    string Source = "SSGBLR";
                    if (std.Position == "School")
                    {
                        if (std.IsPickUp == true)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has boarded the vehicle for school.";
                        }
                        else if (std.IsPickUp == false)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has reached the school.";
                        }
                    }
                    else if (std.Position == "Home")
                    {
                        if (std.IsPickUp == true)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has boarded the vehicle for home.";
                        }
                        else if (std.IsPickUp == false)
                        {
                            Status = "This message is to notify your kid " + Student.FirstName + " " + Student.MiddleName + " " + Student.LastName + "has reached the home.";
                        }
                    }
                    string Content = Status;
                    string strUrl = "http://103.16.101.52:8080/sendsms/bulksms?username=" + Username + "&password=" + Password + "&type=0&dlr=1&destination=" + Number + "&source=" + Source + "&message=" + Content;
                    HttpWebRequest _createRequest = (HttpWebRequest)WebRequest.Create(strUrl);
                    HttpWebResponse response = (HttpWebResponse)_createRequest.GetResponse();
                    Stream s = (Stream)response.GetResponseStream();
                    StreamReader readStream = new StreamReader(s);
                    string dataString = readStream.ReadToEnd();
                    response.Close();
                    s.Close();
                    readStream.Close(); */
                }
                return new JsonResult(new ErrorMessageDto { Status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }

        }

        #region AttendaceModel 
        [HttpGet("GetBatchAndCourse")]
        public async Task<JsonResult> GetBatchAndCourse(long OrgId)
        {
            try
            {
                var Batches = await db.TblBatches.Where(x => x.OrgId == OrgId && x.IsActive == true).
                Select(y => new { y.Id, y.Name }).ToListAsync();
                var Courses = await db.TblCourses.Where(x => x.OrgId == OrgId && x.IsActive == true).
                   Select(y => new { y.Id, y.Name }).ToListAsync();
                return new JsonResult(new { Batches, Courses });
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("StudBasedFilter")]
        public async Task<JsonResult> StudBasedFilter(StudentsBasedOnFilerDto studentDet)
        {
            try
            {
                var DateAttendace = OnlyDateConvertToDateTime(studentDet.AttendanceDate);
                var Students = (from batchAdmission in db.TblBatchAdmissions
                                join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                where batchAdmission.OrgId == studentDet.OrgId && batchAdmission.CourseId == studentDet.CourseId &&
                                batchAdmission.BatchId == studentDet.BatchId
                                select new
                                {
                                    FirstName = student.FirstName,
                                    MiddleName = student.MiddleName,
                                    LastName = student.LastName,
                                    student.Id
                                }).ToList().
                                 Select(s => new { StudentName = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });
                List<DailyAttendanceDto> AttendanceDateWiseModelObjList = new List<DailyAttendanceDto>();
                foreach (var StuObj in Students)
                {
                    DailyAttendanceDto AttendanceDateWiseModelObj = new DailyAttendanceDto();
                    AttendanceDateWiseModelObj.Id = StuObj.Id;
                    AttendanceDateWiseModelObj.StudentName = StuObj.StudentName;

                    var IsPresent = db.TblAttendanceHourlies.Where(i => i.StudentId == StuObj.Id && i.OrgId == studentDet.OrgId && i.IsAttendance == true && i.Date.Year == DateAttendace.Year && i.Date.Month == DateAttendace.Month && i.Date.Day == DateAttendace.Day).ToList().Count();
                    if (IsPresent > 0)
                    {
                        AttendanceDateWiseModelObj.isPresent = true;
                    }
                    else
                    {
                        AttendanceDateWiseModelObj.isPresent = false;
                    }
                    AttendanceDateWiseModelObjList.Add(AttendanceDateWiseModelObj);
                }
                return new JsonResult(AttendanceDateWiseModelObjList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("GetStudentsBasedOnFiler")]
        public async Task<JsonResult> GetStudentsBasedOnFiler(long CourseId, long BatchId, long OrgId, string AttendanceDate)
        {
            try
            {
                var DateAttendace = OnlyDateConvertToDateTime(AttendanceDate);
                var Students = (from batchAdmission in db.TblBatchAdmissions
                                join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                where batchAdmission.OrgId == OrgId && batchAdmission.CourseId == CourseId &&
                                batchAdmission.BatchId == BatchId
                                select new
                                {
                                    FirstName = student.FirstName,
                                    MiddleName = student.MiddleName,
                                    LastName = student.LastName,
                                    student.Id
                                }).ToList().
                                 Select(s => new { StudentName = s.FirstName + " " + s.MiddleName + " " + s.LastName, s.Id });
                List<DailyAttendanceDto> AttendanceDateWiseModelObjList = new List<DailyAttendanceDto>();
                foreach (var StuObj in Students)
                {
                    DailyAttendanceDto AttendanceDateWiseModelObj = new DailyAttendanceDto();
                    AttendanceDateWiseModelObj.Id = StuObj.Id;
                    AttendanceDateWiseModelObj.StudentName = StuObj.StudentName;

                    var IsPresent = db.TblAttendanceHourlies.Where(i => i.StudentId == StuObj.Id && i.OrgId == OrgId && i.IsAttendance == true && i.Date.Year == DateAttendace.Year && i.Date.Month == DateAttendace.Month && i.Date.Day == DateAttendace.Day).ToList().Count();
                    if (IsPresent > 0)
                    {
                        AttendanceDateWiseModelObj.isPresent = true;
                    }
                    else
                    {
                        AttendanceDateWiseModelObj.isPresent = false;
                    }
                    AttendanceDateWiseModelObjList.Add(AttendanceDateWiseModelObj);
                }
                return new JsonResult(AttendanceDateWiseModelObjList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("GetDaycareStudentsAttendance")]
        public async Task<JsonResult> GetDaycareStudentsAttendance(DaycareStudentsAttendanceDto DayCareObject)
        {
            try
            {
                var DateAttendace = OnlyDateConvertToDateTime(DayCareObject.AttendanceDate);
                var allStudents = (from batchAdmission in db.TblBatchAdmissions
                                   join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                   where batchAdmission.OrgId == DayCareObject.OrgId && batchAdmission.CourseId == DayCareObject.CourseId &&
                                   batchAdmission.BatchId == DayCareObject.BatchId
                                   select new
                                   {
                                       StudentName = student.FirstName ?? "" + student.MiddleName ?? "" + student.LastName ?? "",
                                       student.Id
                                   }).ToList();
                List<StudentAttendanceDetailDto> attendanceDetail = new List<StudentAttendanceDetailDto>();
                foreach (var item in allStudents)
                {
                    var studentAttendanceDetail = db.TblAttendanceHourlies.Where(f =>
                    f.Date.Day == DateAttendace.Day && f.Date.Month == DateAttendace.Month && f.Date.Year == DateAttendace.Year &&
                    f.StudentId == item.Id && f.OrgId == DayCareObject.OrgId).ToList();

                    var checkInDetail = studentAttendanceDetail.FirstOrDefault(f => f.IsPickUp == true);
                    var checkOutDetail = studentAttendanceDetail.FirstOrDefault(f => f.IsPickUp == false);

                    attendanceDetail.Add(new StudentAttendanceDetailDto()
                    {
                        Id = item.Id,
                        StudentName = Regex.Replace(item.StudentName, @"\s{2,}", "").Trim(),
                        CheckInTime = checkInDetail == null ? "NOT SET" : new DateTime().Add(checkInDetail.Time).ToString("hh:mm tt"),
                        CheckOutTime = checkOutDetail == null ? "NOT SET" : new DateTime().Add(checkOutDetail.Time).ToString("hh:mm tt")
                    });
                }
                return new JsonResult(attendanceDetail);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("GetStudentsAttendance")]
        public async Task<JsonResult> GetStudentsAttendance(long CourseId, long BatchId, long OrgId, string AttendanceDate)
        {
            try
            {
                var DateAttendace = OnlyDateConvertToDateTime(AttendanceDate);
                var allStudents = (from batchAdmission in db.TblBatchAdmissions
                                   join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                   where batchAdmission.OrgId == OrgId && batchAdmission.CourseId == CourseId &&
                                   batchAdmission.BatchId == BatchId
                                   select new
                                   {
                                       StudentName = student.FirstName ?? "" + student.MiddleName ?? "" + student.LastName ?? "",
                                       student.Id
                                   }).ToList();
                List<StudentAttendanceDetailDto> attendanceDetail = new List<StudentAttendanceDetailDto>();
                foreach (var item in allStudents)
                {
                    var studentAttendanceDetail = db.TblAttendanceHourlies.Where(f =>
                    f.Date.Day == DateAttendace.Day && f.Date.Month == DateAttendace.Month && f.Date.Year == DateAttendace.Year &&
                    f.StudentId == item.Id && f.OrgId == OrgId).ToList();

                    var checkInDetail = studentAttendanceDetail.FirstOrDefault(f => f.IsPickUp == true);
                    var checkOutDetail = studentAttendanceDetail.FirstOrDefault(f => f.IsPickUp == false);

                    attendanceDetail.Add(new StudentAttendanceDetailDto()
                    {
                        Id = item.Id,
                        StudentName = Regex.Replace(item.StudentName, @"\s{2,}", "").Trim(),
                        CheckInTime = checkInDetail == null ? "NOT SET" : new DateTime().Add(checkInDetail.Time).ToString("hh:mm tt"),
                        CheckOutTime = checkOutDetail == null ? "NOT SET" : new DateTime().Add(checkOutDetail.Time).ToString("hh:mm tt")
                    });
                }
                return new JsonResult(attendanceDetail);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region SaveDailyAttendance
        [HttpPost("SaveStudAttendanceDaily")]
        public async Task<JsonResult> SaveStudAttendanceDaily([FromBody] SaveStudAttendanceDto AttendanceData)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(AttendanceData.dateAttendance);
                // var AttendanceDate = DateTime.Now;
                foreach (var temp in AttendanceData.DailyAttendanceObj)
                {
                    if (temp.isPresent == true)
                    {
                        var StudentAttendance = db.TblAttendanceHourlies.Where(i => i.StudentId == temp.Id && i.OrgId == AttendanceData.OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i.Id).ToList();
                        if (StudentAttendance.Count == 0)
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = true,
                                IsAttendance = true,
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = AttendanceData.OrgId
                            });
                            await db.SaveChangesAsync();
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = false,
                                IsAttendance = true,
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = AttendanceData.OrgId
                            });
                            await db.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        var DeleteAttendance = db.TblAttendanceHourlies.Where(i => i.StudentId == temp.Id && i.OrgId == AttendanceData.OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i.Id).ToList();
                        foreach (var i in DeleteAttendance)
                        {
                            db.TblAttendanceHourlies.Remove(db.TblAttendanceHourlies.Where(x => x.Id == i).Single());
                            db.SaveChanges();
                        }
                    }
                }
                return new JsonResult(new ErrorMessageDto { Status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("SaveDailyStudentAttendance")]
        public async Task<JsonResult> saveDailyStudentAttendance(List<DailyAttendanceDto> DailyAttendanceObj, string dateAttendance, long OrgId)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(dateAttendance);
                // var AttendanceDate = DateTime.Now;
                foreach (var temp in DailyAttendanceObj)
                {
                    if (temp.isPresent == true)
                    {
                        var StudentAttendance = db.TblAttendanceHourlies.Where(i => i.StudentId == temp.Id && i.OrgId == OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i.Id).ToList();
                        if (StudentAttendance.Count == 0)
                        {
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = true,
                                IsAttendance = true,
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = OrgId
                            });
                            await db.SaveChangesAsync();
                            db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                            {
                                StudentId = temp.Id,
                                IsPickUp = false,
                                IsAttendance = true,
                                Date = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day),
                                OrgId = OrgId
                            });
                            await db.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        var DeleteAttendance = db.TblAttendanceHourlies.Where(i => i.StudentId == temp.Id && i.OrgId == OrgId && i.Date.Year == AttendanceDate.Year && i.Date.Month == AttendanceDate.Month && i.Date.Day == AttendanceDate.Day).Select(i => i.Id).ToList();
                        foreach (var i in DeleteAttendance)
                        {
                            db.TblAttendanceHourlies.Remove(db.TblAttendanceHourlies.Where(x => x.Id == i).Single());
                            await db.SaveChangesAsync();
                        }
                    }
                }
                return new JsonResult(new ErrorMessageDto { Status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new ErrorMessageDto { Status = false, Message = e.ToString() });
            }
        }

        [HttpPost("SaveDailyStudentAttendanceByTime")]
        public async Task<JsonResult> SaveDailyStudentAttendanceByTime(List<StudentAttendanceDetailDto> attendanceData, string dateAttendance, long OrgId)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(dateAttendance);
                foreach (var item in attendanceData)
                {
                    var studentAttendanceDetail = db.TblAttendanceHourlies.Where(f =>
                    f.Date.Day == AttendanceDate.Day && f.Date.Month == AttendanceDate.Month && f.Date.Year == AttendanceDate.Year &&
                    f.StudentId == item.Id && f.OrgId == OrgId).ToList();

                    var checkInDetail = studentAttendanceDetail.FirstOrDefault(f => f.IsPickUp == true);
                    var checkOutDetail = studentAttendanceDetail.FirstOrDefault(f => f.IsPickUp == false);
                    TimeSpan checkInTimespan;
                    if (checkInDetail == null && ParseOnlyTime(item.CheckInTime, out checkInTimespan))
                    {
                        db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                        {
                            StudentId = item.Id,
                            IsPickUp = true,
                            OrgId = OrgId,
                            Date = AttendanceDate,
                            Time = checkInTimespan,
                            IsAttendance = true
                        });
                        await db.SaveChangesAsync();
                    }
                    else if (checkInDetail != null && ParseOnlyTime(item.CheckInTime, out checkInTimespan))
                    {
                        checkInDetail.Time = checkInTimespan;
                        db.Entry(checkInDetail).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }

                    TimeSpan checkOutTimespan;
                    if (checkOutDetail == null && ParseOnlyTime(item.CheckOutTime, out checkOutTimespan))
                    {
                        db.TblAttendanceHourlies.Add(new TblAttendanceHourly()
                        {
                            StudentId = item.Id,
                            IsPickUp = false,
                            OrgId = OrgId,
                            Date = AttendanceDate,
                            Time = checkOutTimespan,
                            IsAttendance = true
                        });
                        await db.SaveChangesAsync();
                    }
                    else if (checkOutDetail != null && ParseOnlyTime(item.CheckOutTime, out checkOutTimespan))
                    {
                        checkOutDetail.Time = checkOutTimespan;
                        db.Entry(checkOutDetail).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                return new JsonResult("Error while saving attendance.");
            }
            return new JsonResult("Attendance saved successfully.");
        }

        private bool ParseOnlyTime(string checkInTime, out TimeSpan checkInTimespan)
        {
            try
            {
                checkInTimespan = DateTime.Parse("0001/01/01 " + checkInTime) - new DateTime();
                return true;
            }
            catch
            {
                checkInTimespan = new TimeSpan();
                return false;
            }
        }



        #endregion
    }
}
