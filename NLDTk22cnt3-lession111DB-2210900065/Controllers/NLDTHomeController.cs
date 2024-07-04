using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLDTk22cnt3_lession111DB_2210900065.Controllers
{
    public class NLDTHomeController : Controller
    {
        public ActionResult NLDTIndex()
        {
            return View();
        }

        public ActionResult NLDTAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NLDTContact()
        {
            ViewBag.msv = "2210900065 ";
            ViewBag.fullname = "nguyen le duc thanh ";

            return View();
        }
    }
}