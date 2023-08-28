using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaatashalaApi.Models;
using System.Drawing;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public GalleryController(WebSchoolContext _db)
        {
            db = _db;
        }
        [HttpPut("UploadImage")]
        public async Task<IActionResult> UploadImage(long BatchId, long CourseId, long EmpId, long OrgId)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        var bytes = memoryStream.ToArray();
                        var size = file.Length;

                        var image = new TblImageGallery
                        {
                            Batch = BatchId,
                            Course = CourseId,
                            EmpId = EmpId,
                            OrgId = OrgId,
                            ImageSize = size,
                            ImageName = file.FileName,
                            ImageData = bytes,
                        };

                        db.TblImageGalleries.Add(image);
                        await db.SaveChangesAsync();
                    }
                }

                return Ok(new { status = true, count = files.Count });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { status = false, message = e.ToString() });
            }
        }
        [HttpGet("ImageList")]
        public async Task<JsonResult> ImageList(long BatchId, long CourseId, long OrgId)

        {
            var ImageId = db.TblImageGalleries.Where(x => x.OrgId == OrgId && x.Batch == BatchId &&
            x.Course == CourseId).Select(y => new { y.Id }).ToList();
            return new JsonResult(ImageId);
        }
        [HttpGet("DownloadImage")]
        public async Task<FileStreamResult> DownloadImage(long Id, bool? IsThumbnail)

        {
            try
            {
                var img = db.TblImageGalleries.Find(Id);
                if (img != null)
                {
                    if ((IsThumbnail ?? false))
                    {
                        Image imgttt = Image.FromStream(new MemoryStream((img.ImageData), true));
                        Image thumb = imgttt.GetThumbnailImage(250, (int)((250 / (float)imgttt.Width) * imgttt.Height), () => false, IntPtr.Zero);
                        var stream = new MemoryStream();
                        thumb.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        stream.Position = 0;
                        return new FileStreamResult(stream, "image/jpeg");
                    }
                    else
                    {
                        return new FileStreamResult(new MemoryStream(/*Encoding.ASCII.GetBytes*/(img.ImageData), true), "image/jpeg");
                    }
                }
                return new FileStreamResult(new FileStream(@"~\Resources\Image\student.png", FileMode.Open), "image/jpeg");
            }
            catch
            {
                return null;
            }
        }
        [HttpDelete("DeleteImage")]
        public async Task<JsonResult> DeleteImage(List<long> PhotoId, long OrgId)

        {
            List<long> errorList = new List<long>();
            foreach (var temp in PhotoId)
            {
                try
                {
                    var DeletePhoto = db.TblImageGalleries.Where(x => x.OrgId == OrgId && x.Id == temp).FirstOrDefault();
                    db.TblImageGalleries.Remove(DeletePhoto);
                   await   db.SaveChangesAsync();
                }
                catch
                {
                    errorList.Add(temp);
                }
            }
            return new JsonResult(errorList);
        }
        [HttpPost("ImageListNew")]
        public async Task<JsonResult> ImageListNew(ImgageParam Data)

        {
            var ImageId = db.TblImageGalleries.Where(x => x.OrgId == Data.OrgId && x.Batch == Data.Batch &&
            x.Course == Data.Course).Select(y => new { y.Id }).ToList();
            return new JsonResult(ImageId);
        }
        public class ImgageParam
        {
            public long? Batch { get; set; }
            public long? Course { get; set; }
            public long? OrgId { get; set; }
        }
    }
}
