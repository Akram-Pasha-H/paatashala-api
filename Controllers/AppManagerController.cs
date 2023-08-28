using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppManagerController : ControllerBase
    {
        private readonly WebSchoolContext db;
        public AppManagerController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpGet("GetLatestVersion")]
        public async Task<JsonResult> GetLatestVersion()
        {
            try
            {
                var version = await db.TblAppVersions
                    .Where(x => x.BuidDate.HasValue) 
                    .OrderByDescending(x => x.BuidDate)
                    .Select(x => new
                    {
                        x.VersionId,
                        BuidDate = x.BuidDate.Value.ToString("dd-MMM-yyyy"), 
                        x.Version,
                        x.UpdateMessage,
                        x.Notes
                    })
                    .FirstOrDefaultAsync();

                if (version != null) 
                {
                    return new JsonResult(version);
                }
                else
                {
                    return new JsonResult(404, new ErrorMessageDto { Status = false, Message = "No version found" });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(500, new ErrorMessageDto { Status = false, Message = ex.ToString() });
            }
        }

        [HttpGet("PatashalaApp")]
        public FileStreamResult PatashalaApp()
        {
            try
            {
                // Update the filePath to the actual path of your APK file
                string filePath = "Path/To/Your/Paatashala.apk";

                Stream stream = new FileStream(filePath, FileMode.Open);
                FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/vnd.android.package-archive");
                fileStreamResult.FileDownloadName = "Paatashala.apk";
                return fileStreamResult;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("SaveAPKFile")]
        public async Task<IActionResult> SaveAPKFile(IFormFile file)
        {
            try
            {
                if (file == null || file.Length <= 0)
                {
                    return BadRequest("No file uploaded.");
                }
                string rootPath = Directory.GetCurrentDirectory() + "/Files";
                string filePath = Path.Combine(rootPath, file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return Ok("Successfully Uploded");
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new ErrorMessageDto { Status = false, Message = ex.ToString() });
            }
        }
    }
}
