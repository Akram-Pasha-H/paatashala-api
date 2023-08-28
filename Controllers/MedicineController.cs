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
    public class MedicineController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public MedicineController(WebSchoolContext _db)
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
        [HttpGet("GetStudents")]

        public async Task<JsonResult> GetStudents(long OrgId, long CourseId, long BatchId)
        {
            try
            {
                var Students = await (from batchAdmission in db.TblBatchAdmissions
                                      join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                      where batchAdmission.OrgId == OrgId && batchAdmission.CourseId == CourseId &&
                                            batchAdmission.BatchId == BatchId
                                      select new
                                      {
                                          FirstName = student.FirstName,
                                          MiddleName = student.MiddleName,
                                          LastName = student.LastName,
                                          student.Id
                                      }).ToListAsync();
                var formattedStudents = Students.Select(s => new { StudentName = $"{s.FirstName} {s.MiddleName} {s.LastName}", s.Id });
                return new JsonResult(new { Students });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetStudentsNew")]
        public async Task<JsonResult> GetStudentsNew(long OrgId, long CourseId, long BatchId)
        {
            try
            {

                var Students = await (from batchAdmission in db.TblBatchAdmissions
                                      join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                      where batchAdmission.OrgId == OrgId && batchAdmission.CourseId == CourseId &&
                                            batchAdmission.BatchId == BatchId
                                      select new
                                      {
                                          StudentName = $"{student.FirstName} {student.MiddleName} {student.LastName}",
                                          student.Id
                                      }).ToListAsync();

                return new JsonResult(Students);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPost("AddMedicine")]
        public async Task<JsonResult> AddMedicine(Medicine medicine)
        {
            try
            {
                db.TblMedicineDetails.Add(new TblMedicineDetail()
                {
                    Name = medicine.Name,
                    Description = medicine.Description,
                    OrgId = medicine.OrgId,
                    Company = medicine.Company
                });
                await db.SaveChangesAsync();
                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, message = e.ToString() });
            }
        }
        [HttpPost("AddMedicineType")]
        public async Task<JsonResult> AddMedicineType(string Name, string Description, long OrgId, string Company)
        {
            try
            {
                db.TblMedicineDetails.Add(new TblMedicineDetail()
                {
                    Name = Name,
                    Description = Description,
                    OrgId = OrgId,
                    Company = Company
                });
                await db.SaveChangesAsync();
                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, message = e.ToString() });
            }
        }
        [HttpGet("GetMedicineType")]
        public async Task<JsonResult> GetMedicineType(long OrgId) 
        {
            try
            {
                var medicineTypes = await db.TblMedicineDetails
           .Where(x => x.OrgId == OrgId)
           .Select(y => new { y.Id, y.Name })
           .ToListAsync();
                return new JsonResult(new { MedicineType = medicineTypes });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetMedicineTypeNew")]
        public async Task<JsonResult> GetMedicineTypeNew(long OrgId)
        {
            try
            {
                var MedicineTypes = await  db.TblMedicineDetails
                    .Where(x => x.OrgId == OrgId)
                    . Select(y => new { y.Id, y.Name })
                    .ToListAsync();
                return new JsonResult(MedicineTypes);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpPut("SaveStudentMedicine")]

        public async Task<JsonResult> SaveStudentMedicine(long StudentId, string Date, long OrgId, long MedicineId, string Dosage, string Time)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(Date);
                var MedicineTime = OnlyDateConvertToDateTime(Time);

                db.TblStudentMedicines.Add(new TblStudentMedicine()
                {
                    AdministeredDate = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day, MedicineTime.Hour, MedicineTime.Minute, MedicineTime.Second),
                    MedicineId = MedicineId,
                    Uom = Dosage,
                    StudentId = StudentId,
                    OrgId = OrgId,

                });
               await    db.SaveChangesAsync();
                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, message = e.ToString() });
            }
        }
        [HttpPost("GetStudentList")]
        public async Task<JsonResult>GetStudentList(Studentinfo studentObj)
        {
            try
            {
                var Students = await (from batchAdmission in db.TblBatchAdmissions
                                      join student in db.TblStudents on batchAdmission.StudentId equals student.Id
                                      where batchAdmission.OrgId == studentObj.OrgId && batchAdmission.CourseId == studentObj.CourseId &&
                                            batchAdmission.BatchId == studentObj.BatchId
                                      select new
                                      {
                                          StudentName = student.FirstName + " " + student.MiddleName + " " + student.LastName,
                                          student.Id
                                      }).ToListAsync();
                return new JsonResult(Students);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        
        [HttpPost("SaveStudMedic")]

        public async Task<JsonResult> SaveStudMedic(StudentMedinfo studmed)
        {
            try
            {
                var AttendanceDate = OnlyDateConvertToDateTime(studmed.Date);
                var MedicineTime = OnlyDateConvertToDateTime(studmed.Time);

                db.TblStudentMedicines.Add(new TblStudentMedicine()
                {
                    AdministeredDate = new DateTime(AttendanceDate.Year, AttendanceDate.Month, AttendanceDate.Day, MedicineTime.Hour, MedicineTime.Minute, MedicineTime.Second),
                    MedicineId = studmed.MedicineId,
                    Uom = studmed.Dosage,
                    StudentId = studmed.StudentId,
                    OrgId = studmed.OrgId,

                });
               await db.SaveChangesAsync();
                return new JsonResult(new { status = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { status = false, message = e.ToString() });
            }
        }
            
    }
}
