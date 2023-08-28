using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using System.Text;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public ReportController(WebSchoolContext _db)
        {
            db = _db;
        }
        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        [HttpGet("GetReportBaseDetails")]
        public async Task<JsonResult> GetReportBaseDetails(long StudentId, long OrgId)
        {
            try
            {
                var BaseDetails = await (from r in db.TblReportSentDetails
                                         join b in db.TblReportCategories on r.ReportCategoryId equals b.Id
                                         where r.StudentId == StudentId && r.OrgId == OrgId
                                         select new
                                         {
                                             CategoryName = b.Name,
                                             r.Id,
                                             r.Type,
                                             r.CreatedOn,
                                             r.StartDateTime,
                                             r.EndDateTime
                                         }).ToListAsync();

                var formattedBaseDetails = BaseDetails.Select(x => new
                {
                    x.Id,
                    x.CategoryName,
                    x.Type,
                    createdOn = ConvertToJavascriptDate(x.CreatedOn),
                    StartTime = ConvertToJavascriptDate(x.StartDateTime.Value),
                    EndTime = ConvertToJavascriptDate(x.EndDateTime.Value)
                }).ToList();

                return new JsonResult(formattedBaseDetails);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetReportEntireDetails")]
        public async Task<JsonResult> GetReportEntireDetails(long Id, long OrgId)
        {
            try
            {
                //String strHTML = GenerateReport(Id, OrgId);
                //string Filename = GetFineName(Id, OrgId);
                //byte[] pdfFile = Utility.SampleUtility.ConvertHtmlToPDFwithCSS(strHTML);
                //return File(pdfFile, System.Net.Mime.MediaTypeNames.Application.Pdf, Filename + ".pdf");
                return new JsonResult("");
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetFineName")]
        public async Task<JsonResult> GetFineName(long Id, long OrgId)
        {
            try
            {
                string Filename = string.Empty;
                var BaseDetails = db.TblReportSentDetails.Where(x => x.Id == Id).Select(c => c).FirstOrDefault();
                if (BaseDetails.ReportCategoryId == 1)
                {
                    if (BaseDetails.Type != "Daily")
                    {
                        Filename = "Activity Report (" + BaseDetails.StartDateTime.Value.ToString("dd-MM-yyyy") + " - " + BaseDetails.EndDateTime.Value.ToString("dd-MM-yyyy") + ")";
                    }
                    else
                    {
                        Filename = "Activity Report (" + BaseDetails.StartDateTime.Value.ToString("dd-MM-yyyy") + ")";
                    }
                    return new JsonResult(Filename);
                }
                else if (BaseDetails.ReportCategoryId == 2)
                {
                    if (BaseDetails.Type != "Daily")
                    {
                        Filename = "Medicine Report (" + BaseDetails.StartDateTime.Value.ToString("dd-MM-yyyy") + " - " + BaseDetails.EndDateTime.Value.ToString("dd-MM-yyyy") + ")";
                    }
                    else
                    {
                        Filename = "Medicine Report (" + BaseDetails.StartDateTime.Value.ToString("dd-MM-yyyy") + ")";
                    }
                    return new JsonResult(Filename);
                }
                else if (BaseDetails.ReportCategoryId == 3)
                {
                    Filename = "Holiday Report (" + BaseDetails.StartDateTime.Value.ToString("dd-MM-yyyy") + " - " + BaseDetails.EndDateTime.Value.ToString("dd-MM-yyyy") + ")";
                    return new JsonResult(Filename);
                }
                else if (BaseDetails.ReportCategoryId == 4)
                {
                    Filename = "Event Report (" + BaseDetails.StartDateTime.Value.ToString("dd-MM-yyyy") + " - " + BaseDetails.EndDateTime.Value.ToString("dd-MM-yyyy") + ")";
                    return new JsonResult(Filename);
                }
                else
                {
                    return new JsonResult(Filename);
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }

        [HttpGet("GenerateReport")]
        public async Task<string> GenerateReport(long Id, long OrgId)
        {
            try
            {
                var schoolAddress = await db.TblOrgs.FirstOrDefaultAsync(x => x.Id == OrgId);
                var baseDetails = await db.TblReportSentDetails.FirstOrDefaultAsync(x => x.Id == Id);

                var studentDetails = await (from s in db.TblStudents
                                            join a in db.TblBatchAdmissions on s.Id equals a.StudentId
                                            join b in db.TblBatches on a.BatchId equals b.Id
                                            join c in db.TblCourses on a.CourseId equals c.Id
                                            where a.OrgId == OrgId && a.StudentId == baseDetails.StudentId
                                            select new { s.FirstName, s.MiddleName, s.LastName, b.Name, Course = c.Name })
                                            .FirstOrDefaultAsync();

                StudentActivity studentActivityObj = new StudentActivity();
                // ... Rest of your code
                // (Note: Since the code is extensive, I'm providing suggestions for improving the initial part)

                if (baseDetails.ReportCategoryId == 1)
                {
                    TimeSpan ts = new TimeSpan(00, 00, 0);
                    TimeSpan ts2 = new TimeSpan(23, 59, 0);

                    DateTime? startDate = baseDetails.StartDateTime.Value.Date + ts;
                    DateTime? endDate = baseDetails.EndDateTime.Value.Date + ts2;

                    var listOfDayCareActivitydetails = await (from activitydetails in db.TblStudentActivities
                                                              join activitytype in db.TblStudentActivityTypes on activitydetails.ActivityTypeId equals activitytype.Id
                                                              join batch in db.TblBatches on activitydetails.BatchId equals batch.Id
                                                              join course in db.TblCourses on activitydetails.CourseId equals course.Id
                                                              join stud in db.TblStudents on activitydetails.StudentId equals stud.Id
                                                              where activitydetails.StudentId == baseDetails.StudentId &&
                                                                    activitydetails.ActivityDate >= startDate && activitydetails.ActivityDate <= endDate
                                                              select new { activitydetails.ActivityDate })
                                                              .OrderBy(x => x.ActivityDate).ToListAsync();

                    if (listOfDayCareActivitydetails.Count != 0)
                    {
                        foreach (var item in listOfDayCareActivitydetails)
                        {
                            // ... Rest of your code
                            // (Note: Continue implementing the rest of your logic for generating the report)
                        }
                    }
                }
                // ... Rest of your code for handling other report categories

                return "success";


            }
            catch (Exception ex)
            {
                throw;
            }
        //[HttpGet("RenderPartialToString")]
        //public string RenderPartialToString(string partialViewName, object model)
        //{
        //    InvalidateControllerContext();
        //    IView view = ViewEngines.Engines.FindPartialView(ControllerContext, partialViewName).View;
        //    string result = RenderViewToString(view, model);
        //    return result;
        //}
        //[HttpGet("RenderViewToString")]
        //public string RenderViewToString(string viewName, object model)


            //{
            //    InvalidateControllerContext();
            //    IView view = ViewEngines.Engines.FindView(ControllerContext, viewName, null).View;
            //    string result = RenderViewToString(view, model);
            //    return result;
            //}
            //[HttpGet("RenderViewToString")]
            //public string RenderViewToString(IView view, object model)


            //{
            //    InvalidateControllerContext();
            //    string result = null;
            //    if (view != null)
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        using (StringWriter writer = new StringWriter(sb))
            //        {
            //            ViewContext viewContext = new ViewContext(ControllerContext, view, new ViewDataDictionary(model), new TempDataDictionary(), writer);
            //            view.Render(viewContext, writer);
            //            writer.Flush();


            //        }
            //        result = sb.ToString();
            //    }
            //    return result;
            //}
            //[HttpGet("InvalidateControllerContext")]
            //private void InvalidateControllerContext()
            //{
            //    if (ControllerContext == null)
            //    {
            //        ControllerContext context = new ControllerContext(System.Web.HttpContext.Current.Request.RequestContext, this);
            //        ControllerContext = context;
            //    }
            //}

        }
    }
}

