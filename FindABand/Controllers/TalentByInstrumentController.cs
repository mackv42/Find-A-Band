using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using FindABand.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindABand.Controllers
{
    public class TalentByInstrumentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TalentByInstrumentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TalentByInstrument/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TalentByInstrument/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InstrumentViewModel InstrumentIds)
        {
            var talentByInstrument1 = new TalentByInstrument();
            var talentByInstrument2 = new TalentByInstrument();
            var talentByInstrument3 = new TalentByInstrument();
            string UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            talentByInstrument1.UserId = UserId;
            talentByInstrument2.UserId = UserId;
            talentByInstrument3.UserId = UserId;
            talentByInstrument1.InstrumentId = InstrumentIds.InstrumentId1;
            talentByInstrument2.InstrumentId = InstrumentIds.InstrumentId2;
            talentByInstrument3.InstrumentId = InstrumentIds.InstrumentId3;


            _context.TalentByInstruments.Add(talentByInstrument1);
            _context.TalentByInstruments.Add(talentByInstrument2);
            _context.TalentByInstruments.Add(talentByInstrument3);
            _context.SaveChanges();
            try
            {
                // TODO: Add insert logic here
                
                return RedirectToAction("Create", "Song");
            }
            catch
            {
                return View();
            }
        }
    }
}