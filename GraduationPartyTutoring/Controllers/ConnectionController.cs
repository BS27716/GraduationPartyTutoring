using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraduationPartyTutoring.Controllers
{
    public class ConnectionController : Controller
    {
        // GET: Connection
        public ActionResult Prompt()
        {
            return View();
        }

        public string Index()
        {
            return "Would you like to be <sup>CONNECTED</sup> with a tutor or a student?";
        }

        public string Student()
        {
            return "You are now being <sup>CONNECTED</sup> with a student///";
        }

        public string Welcome(string name, int ID)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID is " + ID + ".");
        }

        public ActionResult Tutor(string name, int numTimes = 1)
        {
            ViewBag.Name = name;
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}