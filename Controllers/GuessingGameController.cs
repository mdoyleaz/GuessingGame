using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

using GuessingGame.Library;


namespace Mvc.Controllers
{
    public class GuessingGameController : Controller
    {
        const string SessionName = "_Name";
        const string SessionRandomInt = "_Random";

        public void SetSessionName(string name) => HttpContext.Session.SetString(SessionName, name);
        public void SetSessionRandomInt(int randomInt) => HttpContext.Session.SetInt32(SessionRandomInt, randomInt);

        public string GetSessionName()
        {
            return HttpContext.Session.GetString(SessionName);
        }

        public string GetSessionRandomInt()
        {
            return HttpContext.Session.GetString(SessionRandomInt);
        }

        public IActionResult Index(string name)
        {
            if (name != null)
            {
                SetSessionName(name);
                Console.WriteLine(GetSessionName());
            }
            return View();
        }

        public IActionResult PlayGame(int roundNum, int userGuess)
        {
            Console.WriteLine(HttpContext.Session.GetString(SessionName));
            int randomInt = GameLogic.RandomNumber(20);
            SetSessionRandomInt(randomInt);
            return View();
        }
    }
}