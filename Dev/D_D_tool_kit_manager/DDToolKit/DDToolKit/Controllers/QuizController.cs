using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDToolKit.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }

        public string AnswerChecker(int? input, int? answer)
        {
            if (input == answer)
                return "Correct";
            else
                return "Incorrect";
        }

        [HttpGet]
        public ActionResult Questions()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questions(int? a1, int? a2, int? a3, int? a4, int? a5,
            int? a6, int? a7, int? a8, int? a9, int? a10)
        {
            List<string> results = new List<string>();

            results.Add(AnswerChecker(a1, 2));
            results.Add(AnswerChecker(a2, 1));
            results.Add(AnswerChecker(a3, 4));
            results.Add(AnswerChecker(a4, 3));
            results.Add(AnswerChecker(a5, 2));
            results.Add(AnswerChecker(a6, 1));
            results.Add(AnswerChecker(a7, 1));
            results.Add(AnswerChecker(a8, 2));
            results.Add(AnswerChecker(a9, 2));
            results.Add(AnswerChecker(a10, 3));



            int correctCount = 0;
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i] == "Correct")
                {
                    correctCount++;
                }
            }




            ViewBag.Results = results;
            return View();
        }

        [HttpPost]
        public ActionResult Answers(int numAnswers)
        {
            List<string> myList = new List<string>();

            //numAnswers = 0;
            for (int i = 0; i < myList.Count(); i++)
            {
                if (myList[i] == "Correct")
                {
                    
                }
            }

            ViewBag.Answers = myList;
            return View();


        }




    }
}