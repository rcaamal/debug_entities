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

        public string CheckAnswer(int? answer, int? correctAnswer)
        {

            if (answer == correctAnswer)
            {
                return "Correct";
            }

            return "Incorrect";
        }


        [HttpPost]
        public ActionResult Index(int? Ans1, int? Ans2)
        {
            // make a list to add all correct answers
            List<string> correctAnswers = new List<string>();
            correctAnswers.Add(CheckAnswer(Ans1, 1));
            correctAnswers.Add(CheckAnswer(Ans2, 3));
           
           

            /*correctAnswers.Add(Ans1);*/

            int numOfCorrectAnswers = 0;
            for (int  i =0; i < correctAnswers.Count(); i++)
            {
                if(correctAnswers[i] == "Correct")
                {
                    numOfCorrectAnswers++;

                }
            }

            ViewBag.answers = correctAnswers;
            
            
            return View();
        }




    }
}