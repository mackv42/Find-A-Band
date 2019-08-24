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
    public class InstrumentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstrumentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Instrument> List()
        {
            return _context.Instruments.Where(x => true).ToList();
        }
    }
}