using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheHashSlingingSlasher.Models;

namespace TheHashSlingingSlasher.Controllers
{
    public class BarangController : Controller
    {
        public static List<BarangModel> listBarang = new List<BarangModel>();
        // GET: Barang
        public ActionResult Index(string command)
        {
            if (listBarang != null && listBarang.Count > 0)
            {
                return View(listBarang);
            }

            for (int i = 0; i < 10; i++)
            {
                BarangModel newBarang = new BarangModel();
                newBarang.KodeBarang = "KodeBarang" + i;
                newBarang.NamaBarang = "NamaBarang" + i;
                newBarang.Keterangan = "Keterangan" + i;
                newBarang.Jumlah = 100;
                listBarang.Add(newBarang);
            }


            return View(listBarang);
            

        }
        public ActionResult Tambah()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tambah(BarangModel barang)
        {
            listBarang.Add(barang);
            return RedirectToAction("Index");
        }


    }
    
}