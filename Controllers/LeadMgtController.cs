using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadMgtController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public LeadMgtController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetLeadDetails")]
        public async Task<JsonResult> GetLeadDetails(long OrgId)
        {
            try
            {
                var AdmStatus = await db.TblAdmissionStatusTypes
                    .Where(x => x.IsLead == true)
                    .Select(y => new { y.Id, y.Name })
                    .ToListAsync();
                var Streams = await db.TblStreams
                   .Where(u => u.OrgId == OrgId)
                   .Select(i => new { i.Id, i.Name })
                   .ToListAsync();
                var OtherPrograms = await db.TblOtherPrograms
                    .Where(o => o.OrgId == OrgId)
                    .Select(p => new { p.Id, p.Name })
                    .ToListAsync();

                var EmployeesList = await db.TblEmployees
                    .Where(e => e.OrgId == OrgId)
                    .Select(m => new { m.Id, m.FirstName, m.MiddleName, m.LastName })
                    .ToListAsync();
                var formattedEmployeesList = EmployeesList
                   .Select(s => new { Name = $"{s.FirstName} {s.MiddleName} {s.LastName}", s.Id });
               
                //var AssignTo = await db.TblLeadFollowUps
                //    .Where(e => e.OrgId == OrgId)  
                //    .Select(m => new { m.Id, m.AssignTo })  
                //    .ToListAsync();

                return new JsonResult(new { AdmStatus, Streams, OtherPrograms, EmployeesList = formattedEmployeesList });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }

        [HttpPost("SaveEnquiry")]
        public async Task<JsonResult> SaveEnquiry(EnquiryModelDto enquiryModelDto)
        {
            EnquiryModel enquiryModel = new EnquiryModel()
            {
                student = new TblStudent()
                {
                    IsLead = true,
                    OrgId = enquiryModelDto.OrgId,
                    CurrentAddress = enquiryModelDto.student.CurrentAddress,
                    DateOfBirth = enquiryModelDto.student.DateOfBirth,
                    FatherContactNo = enquiryModelDto.student.FatherContactNo,
                    FatherEmail = enquiryModelDto.student.FatherEmail,
                    FatherName = enquiryModelDto.student.FatherName,
                    FirstName = enquiryModelDto.student.FirstName,
                    LastName = enquiryModelDto.student.LastName,
                    MotherContactNo = enquiryModelDto.student.MotherContactNo,
                    MotherEmail = enquiryModelDto.student.MotherEmail,
                    MotherName = enquiryModelDto.student.MotherName,
                    Sex = enquiryModelDto.student.Sex
                },
                registration = new TblStudentRegistration()
                {
                    AdmissionStatus = enquiryModelDto.registration.AdmissionStatus,
                    Batch = enquiryModelDto.registration.Batch,
                    Course = enquiryModelDto.registration.Course,
                    Stream = enquiryModelDto.registration.Stream
                },
                LeadFollowUp = new TblLeadFollowUp()
                {
                    AssignTo = enquiryModelDto.LeadFollowUp.AssignTo,
                    Channel = enquiryModelDto.LeadFollowUp.Channel,
                    FollowupTime = enquiryModelDto.LeadFollowUp.FollowupTime
                },
                OrgId = enquiryModelDto.OrgId,
                EmployeeId = enquiryModelDto.EmployeeId
            };
            try
            {
                using var transaction = db.Database.BeginTransaction();

                enquiryModel.student.IsLead = true;
                enquiryModel.student.OrgId = enquiryModel.OrgId;
                db.TblStudents.Add(enquiryModel.student);
                await db.SaveChangesAsync();

                enquiryModel.registration.StudentId = enquiryModel.student.Id;
                enquiryModel.registration.OrgId = enquiryModel.OrgId;
                enquiryModel.registration.RegistrationDate = DateTime.Now.Date;
                enquiryModel.registration.RegistrationNo = await db.TblStudentRegistrations
                    .Where(x => x.OrgId == enquiryModel.OrgId)
                    .CountAsync() + 1;

                int leadNumAsPerCourse = await (from studentTable in db.TblStudents
                                                join studentRegTable in db.TblStudentRegistrations on studentTable.Id equals studentRegTable.StudentId
                                                where studentTable.IsLead == true && studentTable.OrgId == enquiryModel.OrgId && studentRegTable.Course == enquiryModel.registration.Course
                                                select studentTable)
                                               .CountAsync() + 1;
                enquiryModel.registration.LeadNumber = "LD" + DateTime.Now.ToString("yyyyMM") + leadNumAsPerCourse;

                var courseCode = await db.TblCourses
                    .Where(x => x.Id == enquiryModel.registration.Course)
                    .Select(y => y.CourseCode)
                    .FirstOrDefaultAsync();

                enquiryModel.registration.RegistrationCode = (courseCode ?? "") + enquiryModel.registration.RegistrationNo;

                db.TblStudentRegistrations.Add(enquiryModel.registration);
                await db.SaveChangesAsync();

                var leadFollowUpObj = new TblLeadFollowUp
                {
                    AssignTo = enquiryModel.LeadFollowUp.AssignTo,
                    CreatedBy = enquiryModel.EmployeeId,
                    Explanation = enquiryModel.LeadFollowUp.Explanation,
                    Channel = enquiryModel.LeadFollowUp.Channel,
                    FollowupTime = enquiryModel.LeadFollowUp.FollowupTime,
                    OrgId = enquiryModel.OrgId,
                    Remarks = enquiryModel.LeadFollowUp.Remarks,
                    StudentId = enquiryModel.student.Id,
                    IsDismissed = true,
                    AdmissionStatus = enquiryModel.registration.AdmissionStatus
                };

                db.TblLeadFollowUps.Add(leadFollowUpObj);
                await db.SaveChangesAsync();

                transaction.Commit();

                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(500, new { status = false, message = "An error occurred while saving the enquiry." });
            }
        }



        
        
        [HttpPost("AddNewLead")]
       
        public async Task<JsonResult> AddNewLead(AddNewLeadDto addNewLeadDto, long OrgId, long EmployeeId)
        {
            //tblStudent student, tblStudentRegistration registration, tblLeadFollowUp LeadFollowUp
            TblStudent student = addNewLeadDto.tblStudent;
            TblStudentRegistration registration = addNewLeadDto.tblStudentRegistration;
            TblLeadFollowUp LeadFollowUp = addNewLeadDto.tblLeadFollowUp;
           try
                {
                    student.IsLead = true;
                    student.OrgId = OrgId;
                    db.TblStudents.Add(student);
                     await db.SaveChangesAsync();

                    registration.StudentId = student.Id;
                    registration.OrgId = OrgId;
                    registration.RegistrationDate = DateTime.Now.Date;
                    registration.RegistrationNo = db.TblStudentRegistrations.Where(x => x.OrgId == OrgId).Count() + 1;
                    int LeadNumAsPerCourse = await (from studentTable in db.TblStudents
                                              join studentRegTable in db.TblStudentRegistrations on studentTable.Id equals studentRegTable.StudentId
                                              where studentTable.IsLead == true && studentTable.OrgId == OrgId && studentRegTable.Course == registration.Course
                                              select studentTable).CountAsync() + 1;
                    registration.LeadNumber = "LD" + DateTime.Now.ToString("yyyyMM") + LeadNumAsPerCourse;
                    registration.RegistrationCode = (db.TblCourses.Where(x => x.Id == registration.Course).Select(y => new { y.CourseCode }).FirstOrDefault().CourseCode ?? "") + registration.RegistrationNo;
                    db.TblStudentRegistrations.Add(registration);
                    db.SaveChanges();

                    TblLeadFollowUp LeadFollowUpObj = new TblLeadFollowUp();
                    LeadFollowUpObj.AssignTo = LeadFollowUp.AssignTo;
                    LeadFollowUpObj.CreatedBy = EmployeeId;
                    LeadFollowUpObj.Explanation = LeadFollowUp.Explanation;
                    LeadFollowUpObj.Channel = LeadFollowUp.Channel;
                    LeadFollowUpObj.FollowupTime = LeadFollowUp.FollowupTime;
                    LeadFollowUpObj.OrgId = OrgId;
                    LeadFollowUpObj.Remarks = LeadFollowUp.Remarks;
                    LeadFollowUpObj.StudentId = student.Id;
                    LeadFollowUpObj.IsDismissed = true;
                    LeadFollowUpObj.AdmissionStatus = registration.AdmissionStatus;
                    db.TblLeadFollowUps.Add(LeadFollowUpObj);
                    db.SaveChanges();

                    return new JsonResult(new { status = true });
                }
                catch (Exception e)
                {
                    return new JsonResult(new { status = false, message = e.ToString() });
                }

            
          
        }
    }
    }

