using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementSample.Controllers
{
    public class CookieTestController : Controller
    {
        // GET: CookieTest
        public ActionResult Index()
        {
            return View();
        }

        //write the cookie
        public ActionResult CreateCookie()
        {
            HttpCookie cookie = new HttpCookie("Test");
            cookie.Value = "snickerdoodle";
            cookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(cookie);
            return View();
        }

        //read the cookie
        public ActionResult ReadCookie()
        {
            HttpCookie myCookie = Request.Cookies["Test"];
            if (myCookie != null)
            {
                ViewBag.CookieData = myCookie.Value;
            }
            else
            {
                ViewBag.CookieData = "No cookie present";
            }
            return View();
        }
    }
}