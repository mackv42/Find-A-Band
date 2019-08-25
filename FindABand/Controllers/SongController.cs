using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace FindABand.Controllers
{
    public class SongController : Controller
    {

        private readonly ApplicationDbContext _context;
        private object _environment;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Song
        public ActionResult Index()
        {
            return View();
        }

        // GET: Song/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Song/Create
        public ActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var songList = _context.Songs.Where(x => x.UserId == id).ToList();

            return View(songList);
        }


        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int userId = _context.UserAccounts.Where(x => x.UserId == id).FirstOrDefault().ProfileId;
            var newFileName = string.Empty;
            Song addSong = new Song();

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
                        PathDB = "wwwroot/Songs/" + newFileName;

                        addSong.FileName = "Songs/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(PathDB))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }

            addSong.UserId = id;
            await _context.Songs.AddAsync(addSong);
            await _context.SaveChangesAsync();

            return RedirectToAction("Create", "Song");
        }

        // POST: Song/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Song song)
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

        // GET: Song/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Song/Edit/5
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

        // GET: Song/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Song/Delete/5
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