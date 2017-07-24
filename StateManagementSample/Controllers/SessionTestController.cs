using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementSample.Controllers
{
    public class SessionTestController : Controller
    {
        public ActionResult CreateSession()
        {
            Session["Test"] = "Joe"; // 55.5, false... sessions store objects
            return View();
        }

        public ActionResult ReadSession()
        {
            if (Session["Test"] != null)
            {
                string name = Session["Test"] as string;
                ViewBag.Data = name;
            }
            return View();

        }
    }
}