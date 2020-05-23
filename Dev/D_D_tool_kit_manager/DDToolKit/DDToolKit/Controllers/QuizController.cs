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

        [HttpGet]
        public ActionResult Answers()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Answers(int? Ans1, int? Ans2, int? Ans3, int? Ans4, int? Ans5,
            int? Ans6, int? Ans7, int? Ans8, int? Ans9, int? Ans10)
        {
            int correctAnswers = 0;
            List<string> myList = new List<string>();


            
           if(Ans1 == 2)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans2 == 3)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans3 == 2)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans4 == 1)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans5 == 2)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans6 == 2)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans7 == 3)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans8 == 1)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans9 == 3)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }
            if (Ans10 == 1)
            {
                myList.Add("Correct");
                correctAnswers++;
            }
            else
            {
                myList.Add("Wrong");
            }

            ViewBag.correctAnswers = correctAnswers;
            ViewBag.Answers = myList;
            return View();

            /*
             * List of correct answers
             * 1. Yes    
             * 2. No    
             * 3. Yes   
             * 4. Yes, mage armor spells works with a sheild    
             * 5. Yes, fall is not a weapon     
             * 6. No    
             * 7. No, is not an automatic failure   
             * 8. Yep, sneak attack works against undead    
             * 9. Target has half-cover + 2 bouns to AC     
             * 10. Yes, but you have disadvantage on attack rolls   
             */
        }




    }
}