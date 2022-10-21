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
        public ActionResult Index()
        {
            return View(listKategori);
        }
        [ActionName("Index")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel(Name = "ActionBtn", Data = "Tambahkan")]
        public ActionResult Tambahkan()
        {
            return RedirectToAction("TambahKategori");
        }
        [ActionName("Index")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel(Name = "ActionBtn", Data = "Hapus")]
        public ActionResult Hapus()
        {
            listKategori.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult TambahKategori()
        {
            return View();
        }
        [ActionName("TambahKategori")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel2(Name = "TambahAction", Data = "Simpan")]
        public ActionResult Simpan(KategoriModel Kategori)
        {
            listKategori.Add(Kategori);
            return RedirectToAction("Index");
        }
        [ActionName("TambahKategori")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel2(Name = "TambahAction", Data = "Batal")]
        public ActionResult Batal()
        {
            return RedirectToAction("Index");
        }

    }
}