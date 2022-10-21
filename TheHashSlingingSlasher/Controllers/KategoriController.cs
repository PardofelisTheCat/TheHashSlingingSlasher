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
    public class KategoriController : Controller
    {
        public static List<KategoriModel> listKategori = new List<KategoriModel>();
        // GET: Kategori
        public ActionResult Index(string command)
        {
            if (listKategori != null && listKategori.Count > 0)
            {
                return View(listKategori);
            }

            for (int i = 0; i < 10; i++)
            {
                KategoriModel newKategori = new KategoriModel();
                newKategori.KodeKategori = "KodeKategori" + i;
                newKategori.NamaKategori = "NamaKategori" + i;
                newKategori.Keterangan = "Keterangan" + i;
                newKategori.Jumlah = 100;
                listKategori.Add(newKategori);
            }


            return View(listKategori);
            

        }
        public ActionResult Tambah()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tambah(KategoriModel Kategori)
        {
            listKategori.Add(Kategori);
            return RedirectToAction("Index");
        }


    }
    
}