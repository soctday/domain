using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var subdomain = RouteData.Values["subdomain"].ToString();
            ViewBag.Domain = subdomain;
            return View();
        }

    }
}
