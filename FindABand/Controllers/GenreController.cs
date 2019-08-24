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
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenreController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Genre> List()
        {
            return _context.Genres.Where(x => true).ToList();
        }
    }
}