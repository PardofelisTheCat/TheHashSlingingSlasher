using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheHashSlingingSlasher.Controllers
{
    public class TrollController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}