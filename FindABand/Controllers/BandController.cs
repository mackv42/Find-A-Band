using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.LocationUtils;
using FindABand.Models;
using FindABand.ViewModels;
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

        public ActionResult MyDetails()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var MyBand = _context.Bands.Where(x => x.UserId == userId).FirstOrDefault();
            return View(MyBand);
        }

        public async Task<ActionResult> Details(int id)
        {
            var user = await _context.UserAccounts.Where(x => x.ProfileId == id).FirstOrDefaultAsync();
            Band band = _context.Bands.Where(x => x.BandId == id).FirstOrDefault();
            band.Songs = new List<BandSongSample>();
            band.Songs = await _context.BandSongSamples.Where(x => x.UserId == user.UserId).ToListAsync();
            BandDetailsViewModel model = new BandDetailsViewModel();

            model.band = band;
            var loggedIn = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = _context.UserAccounts.Where(x => x.UserId == loggedIn).FirstOrDefault().ProfileId;
            var requests = _context.Invites.Where(x => x.RecipientId == userId).ToList();
            int? requestId = null;
            foreach( var request in requests)
            {
                if(request.SenderId == band.BandId)
                {
                    requestId = request.Id;
                    break;
                }
            }

            model.inviteId = requestId;
            return View(model);
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
            addBand.GenreId = band.GenreId;
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

        public async Task<IEnumerable<Band>> BandsInDistance(Coordinates coordinates, double distance)
        {
            return await _context.Bands.Where(x => CoordinatesDistanceExtensions.DistanceTo(coordinates, new Coordinates(x.Latitude, x.Longitude)) < distance).ToListAsync();
        }

        public async Task<ActionResult> Search(int SearchQuery)
        {
            SearchBandViewModel m = new SearchBandViewModel();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var bands = await BandsInDistance(new Coordinates(userAccount.Latitude, userAccount.Longitude), 40);
            bands = bands.Where(x => x.GenreId == SearchQuery);
            m.Bands = bands.ToList();
            m.SearchQuery = SearchQuery;

            return View(m);
        }
    }
}