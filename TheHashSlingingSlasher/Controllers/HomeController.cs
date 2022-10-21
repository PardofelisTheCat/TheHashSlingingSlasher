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

        public ActionResult About(int? nilai )
        {

            ViewBag.Message = "yeah.";
            /*  ViewBag.Nilai = "";*/
            string color = null;


            string keterangan = "";
            if (nilai >= 90)
            {
                keterangan = "Cool bro";
                color = "green";


            }

            else if (nilai >= 75 && nilai < 90)
            {
                keterangan = " Great ";
                color = "yellow";
            }
            else
            {
                keterangan = "Fools";
                color = "red";
            }

            AboutModel model = new AboutModel();

            model.Nilai = nilai;
            model.Keterangan = keterangan;
            /*model.tanggal = DateTime.Now;*/
            model.Warna = color;


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