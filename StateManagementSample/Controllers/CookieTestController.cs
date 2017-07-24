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
            //adds to reponse automatically
            Response.Cookies["userInfo"]["userName"] = "patrick";
            Response.Cookies["userInfo"]["lastVisit"] = DateTime.Now.ToString();
            Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(1);

            //another cookie method
            HttpCookie cookie = new HttpCookie("Test");
            cookie.Value = "snickerdoodle";
            cookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(cookie); //must add cookie to save it

            return View();
        }

        //read the cookie
        public ActionResult ReadCookie()
        {
            //reading one value from multi-value cookie
            var userInfoUserName = Request.Cookies["userInfo"]["userName"];
            ViewBag.Username = userInfoUserName;



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