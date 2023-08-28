using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public TransportController(WebSchoolContext _db)
        {
            db = _db;
        }
        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
       
        [HttpGet("GetAllByStudent")]
        public async Task<JsonResult> GetAllByStudent(long StudentId, long OrgId)
        {
            try
            {
                string PickupTime;
                string DropTime;
                var Transport = await (from tableTransport in db.TblTransportTripSheets
                                       join tableRoute in db.TblRoutes on tableTransport.RouteId equals tableRoute.Id
                                       join tableRouteStops in db.TblRouteStops on tableRoute.RouteStart equals tableRouteStops.Id
                                       join temptableRouteStops in db.TblRouteStops on tableRoute.RouteEnd equals temptableRouteStops.Id
                                       where tableTransport.StudentId == StudentId && tableTransport.OrgId == OrgId
                                       select new { tableTransport.PickTime, tableTransport.DropTime, tableRouteStops.Stop.StopName, Endpoint = temptableRouteStops.Stop.StopName }).FirstOrDefaultAsync();

                //PickupTime = ConvertToJavascriptDate(new DateTime(Transport.PickTime.Year, Transport.PickTime.Month, Transport.PickTime.Day, Transport.PickTime.Hour, Transport.PickTime.Minute, Transport.PickTime.Second));
                //DropTime = ConvertToJavascriptDate(new DateTime(Transport.DropTime.Year, Transport.DropTime.Month, Transport.DropTime.Day, Transport.DropTime.Hour, Transport.DropTime.Minute, Transport.DropTime.Second));
                PickupTime = ConvertToJavascriptDate(DateTime.Now) + Transport.PickTime;
                DropTime = PickupTime + Transport.DropTime;
                return new JsonResult(new { Transport, PickupTime, DropTime });
            }
            catch (Exception ex)
            {
                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }

    }
}
