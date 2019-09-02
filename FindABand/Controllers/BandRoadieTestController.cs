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
    public class BandRoadieTestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BandRoadieTestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Create(int bandId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefault();
            var band = _context.Bands.Where(x => x.BandId == bandId).FirstOrDefault();

            BandRoadieTestQuestionViewModel model = new BandRoadieTestQuestionViewModel();
            model.NewQuestion = new BandRoadieTestQuestion();
            model.NewQuestion.BandId = bandId;
            model.TestQuestions = _context.BandRoadieTestQuestions.Where(x => x.BandId == bandId).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(BandRoadieTestQuestion NewQuestion)
        {
            var addQuestion = new BandRoadieTestQuestion();
            addQuestion.BandId = NewQuestion.BandId;
            addQuestion.Question = NewQuestion.Question;
            addQuestion.Weight = NewQuestion.Weight;
            _context.BandRoadieTestQuestions.Add(addQuestion);

            _context.SaveChanges();

            return RedirectToAction("Create", new { bandId = addQuestion.BandId });
        }
    }
}