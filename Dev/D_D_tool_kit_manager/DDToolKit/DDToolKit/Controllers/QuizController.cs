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

        /*public string CheckAnswer(int? answer, int? correctAnswer)
        {

            if (answer == correctAnswer)
            {
                return "Correct";
            }

            return "Incorrect";
        }*/


        [HttpPost]
        public ActionResult Index(string input, string Ans1, string Ans2, int? Ans3, int? Ans4, int? Ans5, int? Ans6, int? Ans7, int? Ans8, int? Ans9
            , int? Ans10, int? Ans11, int? Ans12, int? Ans13, int? Ans14, int? Ans15, int? Ans16, int? Ans17, int? Ans18, int? Ans19, int? Ans20)

        {
            
            List<string> correctAnswers = new List<string>();
            //correctAnswers.Add(Ans1, 3);
            /*correctAnswers.Add(CheckAnswer(Ans2, 1));
            correctAnswers.Add(CheckAnswer(Ans3, 1));
            correctAnswers.Add(CheckAnswer(Ans4, 4));*/
            Ans1 = "3";
            Ans2 = "1";
            string answer;
            if(Ans1 == input)
            {
                answer = "Correct";
            }
            else
            {
                answer = "Incorrect";
            }
            if (Ans2 == input)
            {
                answer = "Correct";
            }
            correctAnswers.Add(Ans1);
            correctAnswers.Add(Ans2);

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