using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.LocationUtils;
using FindABand.Models;
using LiveTunes.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FindABand.Controllers
{
    public class BandController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static HttpClient client;
        public BandController(ApplicationDbContext context)
        {
            client = new HttpClient();
            _context = context;
        }
            
        public ActionResult Index()
        {
            return View();
        }


        public async Task<List<Band>> BandsInDistance(Coordinates coordinates, double distance)
        {
            return await _context.Bands.Where(x => CoordinatesDistanceExtensions.DistanceTo(coordinates, new Coordinates(x.Latitude, x.Longitude)) < distance).ToListAsync();
        }



        public ActionResult MyDetails()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var MyBand = _context.Bands.Where(x => x.UserId == userId).FirstOrDefault();
            return View(MyBand);
        }

        public ActionResult Details(int id)
        {
            Band band = _context.Bands.Where(x => x.BandId == id).FirstOrDefault();
            return View(band);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        // POST: Band/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Band band)
        {
            Band addBand = new Band();
            addBand.City = band.City;
            addBand.State = band.State;
            addBand.Name = band.Name;
            addBand.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            addBand.Description = band.Description;
            var result = await client.GetStringAsync($"https://maps.googleapis.com/maps/api/geocode/json?address={addBand.City}+{addBand.State}&key={GoogleMapsApiKey.Token}");
            var data = JsonConvert.DeserializeObject<JObject>(result);
            double lat = (double)data["results"][0]["geometry"]["location"]["lat"];
            double lon = (double)data["results"][0]["geometry"]["location"]["lng"];
            addBand.Latitude = lat;
            addBand.Longitude = lon;
            _context.Bands.Add(addBand);
            _context.SaveChanges();

            try
            {
               

                return RedirectToAction("Create", "BandSongSample");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Band/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}