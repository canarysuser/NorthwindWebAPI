using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostFormData(/*List<IFormFile> files*/)
        {
            var files = Request.Form.Files; 

            long size = files.Sum(f => f.Length);
            string fileName = string.Empty;
            //Request.Form["file"]
            foreach (var formFile in files)
            {
                fileName = formFile.FileName;
                if (formFile.Length > 0)
                {
                    var filePath = "./UploadedFiles/"+formFile.FileName;

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return Ok(new { size = size, fileName} );
        }
    }
}
