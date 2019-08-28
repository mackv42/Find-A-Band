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
    public class UserAccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static HttpClient client;
        public UserAccountController(ApplicationDbContext context)
        {
            client = new HttpClient();
            _context = context;
        }

        // GET: UserAccount
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Find()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var UserList = UsersInDistance(new Coordinates(userAccount.Latitude, userAccount.Longitude), 30);
            return View(UserList);
        }


        //
        public async Task<ActionResult> SearchByInstrument(int instrumentId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var InDistance = UsersInDistance(new Coordinates(userAccount.Latitude, userAccount.Longitude), 30);
            var UserList = InDistance.Where(x => PlaysInstrument(x, instrumentId)).ToList();
            return View("Find", UserList);
        }

        // GET: UserAccount/Details/5
        public ActionResult Details(int id)
        {
            UserAccount user = _context.UserAccounts.Where(x => x.ProfileId == id).FirstOrDefault();
            user.instrumentsPlayed = _context.TalentByInstruments.Where(x => x.UserId == user.UserId).ToList();
            user.Songs = _context.Songs.Where(x => x.UserId == user.UserId).ToList();
            return View(user);
        }

        public ActionResult MyDetails()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var instrumentsPlayed = _context.TalentByInstruments.Where(x => x.UserId == userId).ToList();
            userAccount.instrumentsPlayed = instrumentsPlayed;


            return View(userAccount);
        }

        // GET: UserAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserAccount/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserAccount account)
        {
            var addAccount = new UserAccount();
            addAccount.FirstName = account.FirstName;
            addAccount.LastName = account.LastName;
            addAccount.Address = account.Address;
            addAccount.City = account.City;
            addAccount.State = account.State;
            addAccount.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await client.GetStringAsync($"https://maps.googleapis.com/maps/api/geocode/json?address={addAccount.City}+{addAccount.State}&key={GoogleMapsApiKey.Token}");
            var data = JsonConvert.DeserializeObject<JObject>(result);
            double lat = (double)data["results"][0]["geometry"]["location"]["lat"];
            double lon = (double)data["results"][0]["geometry"]["location"]["lng"];
            addAccount.Latitude = lat;
            addAccount.Longitude = lon;

            try
            {
                _context.UserAccounts.Add(addAccount);
                _context.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Create", "TalentByInstrument");
            }
            catch
            {
                return View();
            }
        }

        private bool PlaysInstrument(UserAccount userAccount, int instrumentId)
        {
            var instruments = _context.TalentByInstruments.Where(x => x.UserId == userAccount.UserId);
            foreach (var instrument in instruments)
            {
                if (instrument.InstrumentId == instrumentId)
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<UserAccount> UsersInDistance(Coordinates coordinates, double distance)
        {
            return _context.UserAccounts.Where(x => CoordinatesDistanceExtensions.DistanceTo(coordinates, new Coordinates(x.Latitude, x.Longitude)) < distance);
        }

        public async Task<ActionResult> Search( int SearchQuery )
        {
            SearchUserAccountViewModel m = new SearchUserAccountViewModel();
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var users = UsersInDistance(new Coordinates(userAccount.Latitude, userAccount.Longitude), 40);
            users = users.Where(x => PlaysInstrument(x, SearchQuery));
            m.userAccounts = users.ToList();



            m.SearchQuery = SearchQuery;
            
            return View(m);
        }
    }
}