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

            return RedirectToAction("Create", "Song");
        }


            // GET: BandSongSample
        public ActionResult Index()
        {
            return View();
        }

        // GET: BandSongSample/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BandSongSample/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BandSongSample/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BandSongSample/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BandSongSample/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BandSongSample/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BandSongSample/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}