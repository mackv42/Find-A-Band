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

        // GET: UserAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: UserAccount/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: UserAccount/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserAccount userAccount)
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

        public async Task<List<UserAccount>> UsersInDistance(Coordinates coordinates, double distance)
        {
            return await _context.UserAccounts.Where(x => CoordinatesDistanceExtensions.DistanceTo(coordinates, new Coordinates(x.Latitude, x.Longitude)) < distance).ToListAsync();
        }
    }
}