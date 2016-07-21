using Hello_AppHarbor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_AppHarbor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return RedirectToAction("Profiles");
        }

        public ActionResult Profiles()
        {
            return View(new Profile());
        }
    }
}
