using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeDetailController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public FeeDetailController(WebSchoolContext _db)
        {
            db = _db;
        }

        [HttpGet("GetByStudent")]
        public async Task<JsonResult> GetByStudent(long StudentId)
        {
            try
            {
                var feeDetails = await (from tablefee in db.TblStudentFeePaidHeaders
                                        join tableFeePaidDetails in db.TblFeePaymentDetails on tablefee.Id equals tableFeePaidDetails.FeeHeaderId
                                        join tablePaymentMode in db.TblFeePaymentModes on tableFeePaidDetails.PaymentMode equals tablePaymentMode.Id into joinMode
                                        from tablePaymentMode in joinMode.DefaultIfEmpty()
                                        join tableFeeDesc in db.TblFeeDescriptions on tableFeePaidDetails.PaidForPeriodLinked equals tableFeeDesc.Id
                                        where tablefee.StudentId == StudentId
                                        select new
                                        {
                                            DatePaid = tablefee.DatePaid,
                                            tablefee.GrandTotal,
                                            PaidForPeriod = tableFeeDesc.Name,
                                            PaymentMode = tablePaymentMode.Name,
                                            tableFeePaidDetails.AmountPaid
                                        })
                                        .ToListAsync();

                var formattedFeeDetails = feeDetails.Select(m => new
                {
                    DatePaid = m.DatePaid.ToString(),
                    m.GrandTotal,
                    m.PaidForPeriod,
                    m.PaymentMode,
                    m.AmountPaid
                }).OrderByDescending(o => o.DatePaid);

                return new JsonResult(new { feeDetails = formattedFeeDetails });
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetStudentFeeDetails")]
        public async Task<JsonResult> GetStudentFeeDetails(long StudentId)
        {
            try
            {
                var feeDetails = await (from tablefee in db.TblStudentFeePaidHeaders
                                        join tableFeePaidDetails in db.TblFeePaymentDetails on tablefee.Id equals tableFeePaidDetails.FeeHeaderId
                                        join tablePaymentMode in db.TblFeePaymentModes on tableFeePaidDetails.PaymentMode equals tablePaymentMode.Id into joinMode
                                        from tablePaymentMode in joinMode.DefaultIfEmpty()
                                        join tableFeeDesc in db.TblFeeDescriptions on tableFeePaidDetails.PaidForPeriodLinked equals tableFeeDesc.Id
                                        where tablefee.StudentId == StudentId
                                        select new
                                        {
                                            DatePaid = tablefee.DatePaid,
                                            tablefee.GrandTotal,
                                            PaidForPeriod = tableFeeDesc.Name,
                                            PaymentMode = tablePaymentMode.Name,
                                            tableFeePaidDetails.AmountPaid
                                        })
                                        .ToListAsync();

                var formattedFeeDetails = feeDetails.Select(m => new
                {
                    DatePaid = m.DatePaid.ToString(),
                    m.GrandTotal,
                    m.PaidForPeriod,
                    m.PaymentMode,
                    m.AmountPaid
                }).OrderByDescending(o => o.DatePaid);

                return new JsonResult(formattedFeeDetails);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }

}
