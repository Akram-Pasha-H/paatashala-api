using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public PersonalDetailController(WebSchoolContext _db)
        {
          db = _db;
        }
        [HttpGet("GetAllDetail")]

        public async Task<JsonResult> GetAllDetail(long StudentId, long OrgId)
        {
            try
            {
                var Details = await (from tableStudent in db.TblStudents
                                     join tableStudentRegistration in db.TblStudentRegistrations on tableStudent.Id equals tableStudentRegistration.StudentId
                                     join tableCourse in db.TblCourses on tableStudentRegistration.Course equals tableCourse.Id
                                     join tableBatch in db.TblBatches on tableStudentRegistration.Batch equals tableBatch.Id
                                     join tableOrg in db.TblOrgs on tableStudent.OrgId equals tableOrg.Id
                                     where tableStudent.Id == StudentId && tableStudent.OrgId == OrgId
                                     select new
                                     {
                                         FirstName = tableStudent.FirstName,
                                         MiddleName = tableStudent.MiddleName,
                                         LastName = tableStudent.LastName,
                                         tableOrg.OrgName,
                                         tableStudentRegistration.RegistrationCode,
                                         Batch = tableBatch.Name,
                                         Course = tableCourse.Name
                                     }).FirstOrDefaultAsync();

                if (Details != null)
                {
                    var formattedDetails = new
                    {
                        Name = $"{Details.FirstName} {Details.MiddleName} {Details.LastName}",
                        Details.OrgName,
                        Details.RegistrationCode,
                        Details.Batch,
                        Details.Course
                    };

                    return new JsonResult(new { Details = formattedDetails });
                }
                return new JsonResult(new { Details });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }

        [HttpGet("GetEmployeeDetail")]
        public async Task<JsonResult> GetEmployeeDetail(long EmployeeId, long OrgId)
        {
            try
            {
                var Data = await (from EmployeeTable in db.TblEmployees
                                  join DesignationTable in db.TblDesignations on EmployeeTable.Designation equals DesignationTable.Id into joinedDesignation
                                  from DesignationTable in joinedDesignation.DefaultIfEmpty()
                                  where EmployeeTable.Id == EmployeeId && EmployeeTable.OrgId == OrgId
                                  select new
                                  {
                                      FirstName = EmployeeTable.FirstName,
                                      MiddleName = EmployeeTable.MiddleName,
                                      LastName = EmployeeTable.LastName,
                                      EmployeeTable.EmpId,
                                      Designation = DesignationTable.Name
                                  }).FirstOrDefaultAsync();

                if (Data != null)
                {
                    var formattedData = new
                    {
                        Name = $"{Data.FirstName} {Data.MiddleName} {Data.LastName}",
                        Data.EmpId,
                        Data.Designation
                    };

                    return new JsonResult(new { Data = formattedData });
                }
                    return new JsonResult(new { Data });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetEmployeeImage")]
        public async Task<FileStreamResult> GetEmployeeImage(long Id)
        {
            try
            {
                TblEmployee? employee = await db.TblEmployees.FindAsync(Id);
                if (employee != null)
                {
                    return new FileStreamResult(new MemoryStream(employee.Photo, true), "image/jpeg");
                }
                return new FileStreamResult(new FileStream(@"~\Resources\Image\student.png", FileMode.Open), "image/jpeg");
            }
            catch
            {
                return  null;
            }
        }
        [HttpPost("GetAllDetailNew")]
        public async Task<JsonResult> GetAllDetailNew(StudentPersonalDetails stud)
        {
            try
            {

                var Details = await (from tableStudent in db.TblStudents
                                     join tableStudentRegistration in db.TblStudentRegistrations on tableStudent.Id equals
                                     tableStudentRegistration.StudentId
                                     join tableCourse in db.TblCourses on tableStudentRegistration.Course equals tableCourse.Id
                                     join tableBatch in db.TblBatches on tableStudentRegistration.Batch equals tableBatch.Id
                                     join tableOrg in db.TblOrgs on tableStudent.OrgId equals tableOrg.Id
                                     where tableStudent.Id == stud.StudentId && tableStudent.OrgId == stud.OrgId
                                     select new
                                     {
                                         FirstName = tableStudent.FirstName,
                                         MiddleName = tableStudent.MiddleName,
                                         LastName = tableStudent.LastName,
                                         tableOrg.OrgName,
                                         tableStudentRegistration.RegistrationCode,
                                         Batch = tableBatch.Name,
                                         Course = tableCourse.Name
                                     }).FirstOrDefaultAsync();
                if (Details != null)
                {
                    var result = new
                    {
                        Name = Details.FirstName + " " + Details.MiddleName + " " + Details.LastName,
                        Details.OrgName,
                        Details.RegistrationCode,
                        Details.Batch,
                        Details.Course
                    };

                    return new JsonResult(result);
                }

                return new JsonResult(Details);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }
}
