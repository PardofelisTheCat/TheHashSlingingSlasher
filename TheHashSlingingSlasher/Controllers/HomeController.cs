using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheHashSlingingSlasher.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Nilai(int? nilai )
        {

            ViewBag.Message = "yeah...";
            string keterangan;

            string color;
            if (nilai >= 90)
            {
                keterangan = "Cool!";
                color = "green";


            }

            else if (nilai >= 75 && nilai < 90)
            {
                keterangan = "Great! ";
                color = "yellow";
            }
            else
            {
                keterangan = "Too Bad!";
                color = "red";
            }

            AboutModel model = new AboutModel
            {
                Nilai = nilai,
                Keterangan = keterangan,
                Warna = color
            };


            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Coba()
        {

            return View();
        }
    }

    public class AboutModel
    {
        public int? Nilai { get; set; }
        public string Keterangan { get; set; }
        public string Warna { get; set; }

    }
}