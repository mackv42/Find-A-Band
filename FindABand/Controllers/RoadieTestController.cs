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
    public class RoadieTestController : Controller
    {

        private readonly ApplicationDbContext _context;

        public RoadieTestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult TakeTest()
        {
            TakeTestViewModel model = new TakeTestViewModel();
            model.Questions = _context.RoadieTestQuestions.Where(x => true).ToList();
            model.Answers = new List<double>(new double[model.Questions.Count()]);
            return View(model);
        }

        public static double Compare(List<TestAnswer> answerList1, List<TestAnswer> answerList2)
        {
            double result = 0;
            for( int i=0; i<answerList1.Count(); i++)
            {
                result += Math.Abs(answerList1[i].Answer - answerList2[i].Answer);
            }

            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakeTest(List<double> Answers)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var testAnswers = new List<TestAnswer>();
            var Questions = _context.RoadieTestQuestions.Where(x => true).ToList();
            int i = 0;

            foreach (var answer in Answers)
            {
                var ans = new TestAnswer();
                ans.Answer = answer;
                ans.UserId = userId;
                ans.QuestionId = Questions[i++].QuestionId;
                _context.TestAnswers.Add(ans);
            }

            _context.SaveChanges();
            //return View();
            return RedirectToAction("Index", "Home");
        }
    }
}