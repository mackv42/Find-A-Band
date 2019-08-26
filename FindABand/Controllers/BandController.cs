using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindABand.Controllers
{
    public class BandController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BandController(ApplicationDbContext context)
        {
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

        public ActionResult Details(int id)
        {
            return View();
        }

       
        public ActionResult Create()
        {
            return View();
        }

        // POST: Band/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Band band)
        {
            Band addBand = new Band();
            addBand.City = band.City;
            addBand.State = band.State;
            addBand.Name = band.Name;
            addBand.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            addBand.Description = band.Description;
            _context.Bands.Add(addBand);
            _context.SaveChanges();
            try
            {
               

                return RedirectToAction("Details", "Band");
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