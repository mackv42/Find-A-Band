using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindABand.Controllers
{
    public class RoadieTestController : Controller
    {

        private readonly ApplicationDbContext _context;

        public RoadieTestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult TakeTest()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakeTest(TestAnswer answers)
        {
            
            return RedirectToAction("SentRequests", "BandInvite");
        }
    }
}