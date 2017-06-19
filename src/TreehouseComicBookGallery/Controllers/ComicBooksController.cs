using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreehouseComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("ComicBooks Controller Detail");
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("Home");
        }
    }
}