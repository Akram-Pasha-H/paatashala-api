using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using System.Runtime.InteropServices;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoLocationController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public GeoLocationController(WebSchoolContext _db)
        {
            db = _db; 
        }
        private DateTime ConvertToDateTime(string input)
        {
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return DateTime.Now;
        }
        [HttpGet("GetRouteCode")]
        public async Task<JsonResult> GetRouteCode(long OrgId)
        {
            try
            {
                var routes = await db.TblRoutes
                    .Where(x => x.OrgId == OrgId)
                    .Select(x => new { x.Id, x.RouteCode })
                    .ToListAsync();

                return new JsonResult(routes);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet("GetOrgBasedRouteCode")]
        public async Task<JsonResult> GetOrgBasedRouteCode(long OrgId)
        {
            try
            {
                var Routes = await db.TblRoutes
                    .Where(x => x.OrgId == OrgId)
                    .Select(x => new { x.Id, x.RouteCode })
                    .ToListAsync();
                return new JsonResult(Routes);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPut("UpdateSelectedRouteLocation")]
        public async Task<JsonResult> UpdateSelectedRouteLocation([FromBody] TrackLocation obj)
        {
            try
            {
                var datee = DateTime.Now;
                db.TblGpsdata.Add(new TblGpsdatum()
                {
                    RouteCode = obj.Routecode,
                    OrgId = obj.OrgId,
                    Latitude = float.Parse(obj.Latitude),
                    Longitude = float.Parse(obj.Longitude),
                    Time = new DateTime(datee.Year, datee.Month, datee.Day, datee.Hour, datee.Minute, datee.Second)
                });
                 await db.SaveChangesAsync();
                return new JsonResult("Saved Successfully");
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString() );
            }
        }
        [HttpPut("UpdateRouteLocation")]
        public async Task<JsonResult> UpdateRouteLocation(long Routecode, long OrgId, string Lattitude, string Longitude)
        {
            try
            {
                var datee = DateTime.Now;
                db.TblGpsdata.Add(new TblGpsdatum()
                {
                    RouteCode = Routecode,
                    OrgId = OrgId,
                    Latitude = float.Parse(Lattitude),
                    Longitude = float.Parse(Longitude),
                    Time = new DateTime(datee.Year, datee.Month, datee.Day, datee.Hour, datee.Minute, datee.Second)
                });
               await db.SaveChangesAsync();
                return new JsonResult("Saved Successfully");
            }
            catch (Exception e)
            {
                return new JsonResult(e.ToString());
            }
        }
        [HttpGet("GetStrLocation")]
        public async Task<JsonResult> GetStrLocation(string Routecode, string OrgId, string Lattitude, string Longitude, string nowDateTime)
        {
            try
            {
                var datee = ConvertToDateTime(nowDateTime);
                db.TblGpsdata.Add(new TblGpsdatum()
                {
                    RouteCode = Convert.ToInt64(Routecode),
                    OrgId = Convert.ToInt64(OrgId),
                    Latitude = float.Parse(Lattitude),
                    Longitude = float.Parse(Longitude),
                    Time = new DateTime(datee.Year, datee.Month, datee.Day, datee.Hour, datee.Minute, datee.Second)
                });
              await    db.SaveChangesAsync();
                return new JsonResult("Saved Successfully");
            }
            catch (Exception e)
            {
                return new  JsonResult(e.ToString());
            }
        }
        [HttpGet("ShowLocation")]
        public async Task<JsonResult> ShowLocation(long Routecode, long OrgId)
        {
            try
            {
                var ExactLocation = await  db.TblGpsdata
                    .Where(x => x.OrgId == OrgId && x.RouteCode == Routecode)
                    .OrderByDescending(o => o.Time).Take(1)
                    .Select(x => new { x.Latitude, x.Longitude })
                    .FirstOrDefaultAsync();
                return new JsonResult(ExactLocation);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet("GetRouteCodeNew")]
        public async Task<JsonResult> GetRouteCodeNew(long OrgId)
        {
            try
            {
                var Routes = await db.TblRoutes
                    .Where(x => x.OrgId == OrgId)
                    .Select(x => new { x.Id, x.RouteCode })
                    .ToListAsync();
                return new JsonResult(Routes);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost("ShowLocationNew")]
        public async Task<JsonResult> ShowLocationNew(ShowLocationObj loc)
        {
            try
            {
                var ExactLocation =await  db.TblGpsdata
                    .Where(x => x.OrgId == loc.OrgId && x.RouteCode == loc.Routecode)
                    .OrderByDescending(o => o.Time).Take(1)
                    .Select(x => new { x.Latitude, x.Longitude })
                    .FirstOrDefaultAsync();
                return new JsonResult (ExactLocation);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
