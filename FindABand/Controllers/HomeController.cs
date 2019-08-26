using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindABand.Models;
using FindABand.Data;

namespace FindABand.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;

            //context.Genres.Add(new Models.Genre("Blues"));
            //context.Genres.Add(new Models.Genre("Jazz"));
            //context.Genres.Add(new Models.Genre("Folk"));
            //context.Genres.Add(new Models.Genre("Country"));
            //context.Genres.Add(new Models.Genre("Rock"));
            //context.Genres.Add(new Models.Genre("Metal"));
            //context.Genres.Add(new Models.Genre("Surf"));
            //context.Genres.Add(new Models.Genre("Ska"));
            //context.Genres.Add(new Models.Genre("EDM / Electronic"));
            //context.Genres.Add(new Models.Genre("Hip Hop"));
            //context.Genres.Add(new Models.Genre("Rap"));
            //context.Genres.Add(new Models.Genre("Pop"));
            //context.Genres.Add(new Models.Genre("R&B"));
            //context.Genres.Add(new Models.Genre("Reggae"));
            //context.Genres.Add(new Models.Genre("Latin"));
            //context.Genres.Add(new Models.Genre("Classical"));
            //context.Genres.Add(new Models.Genre("religious/spirtual"));
            //context.Genres.Add(new Models.Genre("Cultural"));
            //Polka
            //context.SaveChanges();
            //_context = context;

            //context.Instruments.Add(new Models.Instrument("Guitar"));
            //context.Instruments.Add(new Models.Instrument("Bass"));
            //context.Instruments.Add(new Models.Instrument("Drums"));
            //context.Instruments.Add(new Models.Instrument("Piano"));
            //context.Instruments.Add(new Models.Instrument("Banjo"));
            //context.Instruments.Add(new Models.Instrument("Mandolin"));
            //context.Instruments.Add(new Models.Instrument("Violin"));
            //context.Instruments.Add(new Models.Instrument("Cello"));
            //context.Instruments.Add(new Models.Instrument("Upright Bass"));
            //context.Instruments.Add(new Models.Instrument("Trumpet"));
            //context.Instruments.Add(new Models.Instrument("Trombone"));
            //context.Instruments.Add(new Models.Instrument("Saxophone"));
            //context.Instruments.Add(new Models.Instrument("Clarinet"));
            //context.Instruments.Add(new Models.Instrument("Flute"));
            //context.Instruments.Add(new Models.Instrument("Voice (Vocalist)"));
            //Accordion
            //context.SaveChanges();
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}