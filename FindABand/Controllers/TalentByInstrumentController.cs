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
        public async Task<ActionResult> Create()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            InstrumentViewModel m = new InstrumentViewModel();
            var instruments = _context.TalentByInstruments.Where(x => x.UserId == userId).ToList();
            foreach( var i in instruments)
            {
                m.PlayedInstruments.Add(_context.Instruments.Where(x => x.InstrumentId == i.InstrumentId).FirstOrDefault());
            }
            return View(m);
        }

        // POST: TalentByInstrument/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(InstrumentViewModel InstrumentData)
        {
            var talentByInstrument1 = new TalentByInstrument();
            string UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            talentByInstrument1.UserId = UserId;
            talentByInstrument1.InstrumentId = InstrumentData.CreatedInstrument;


            _context.TalentByInstruments.Add(talentByInstrument1);
            await _context.SaveChangesAsync();
            try
            {
                // TODO: Add insert logic here
                
                return RedirectToAction("Create", "TalentByInstrument");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int instrumentId)
        {
            string UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            TalentByInstrument delete = _context.TalentByInstruments.Where(x => x.UserId == UserId).FirstOrDefault();
            _context.TalentByInstruments.Remove(delete);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create", "TalentByInstrument");
        }
    }
}