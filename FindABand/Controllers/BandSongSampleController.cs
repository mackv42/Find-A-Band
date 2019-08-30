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
using Microsoft.EntityFrameworkCore;

namespace FindABand.Controllers
{
    public class BandSongSampleController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BandSongSampleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Delete(int songSampleId)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var song = await _context.BandSongSamples.Where(x => x.SongId == songSampleId).FirstOrDefaultAsync();

            if (song.UserId == id) {
                _context.Remove(song);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("YourBands", "Band");
        }

        public ActionResult Create(int bandId)
        {
            BandSongSample s = new BandSongSample();
            s.BandId = bandId;
            return View(s);
        }

        public async Task<IActionResult> Upload(List<IFormFile> files, int bandId)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int userId = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            var newFileName = string.Empty;
            BandSongSample addSong = new BandSongSample();

            if (HttpContext.Request.Form.Files != null)
            {
                //var fileName = string.Empty;
                string PathDB = string.Empty;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var FileExtension = Path.GetExtension(file.FileName);

                        newFileName = userId.ToString() + "_" + file.FileName;
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
            addSong.BandId = bandId;
            await _context.BandSongSamples.AddAsync(addSong);
            await _context.SaveChangesAsync();

            BandSongSample sample = new BandSongSample();
            sample.BandId = bandId;
            return View("Create", sample); 
        }
    }
}