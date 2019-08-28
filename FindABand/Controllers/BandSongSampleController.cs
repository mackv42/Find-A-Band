using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindABand.Controllers
{
    public class BandSongSampleController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BandSongSampleController(ApplicationDbContext context)
        {
            _context = context;

        }

        public ActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int userId = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            var newFileName = string.Empty;
            BandSongSample addSong = new BandSongSample();

            if (HttpContext.Request.Form.Files != null)
            {
                //var fileName = string.Empty;
                string PathDB = string.Empty;

                //var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        //Getting FileName


                        //Assigning Unique Filename (Guid)
                        //var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                        //Getting file Extension
                        var FileExtension = Path.GetExtension(file.FileName);

                        // concating  FileName + FileExtension
                        newFileName = userId.ToString() + "_" + file.FileName;

                        // Combines two strings into a path.


                        // if you want to store path of folder in database
                        PathDB = "wwwroot/BandSongs/" + newFileName;

                        addSong.FileName = "BandSongs/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(PathDB))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }

            addSong.UserId = id;
            await _context.BandSongSamples.AddAsync(addSong);
            await _context.SaveChangesAsync();

            return RedirectToAction("Create", "BandSongSample");
        }
    }
}