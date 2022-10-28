using System.Collections.Generic;
using System.Web.Mvc;
using TheHashSlingingSlasher.Models;

namespace TheHashSlingingSlasher.Controllers
{
    public class BarangController : Controller
    {
        public static List<BarangModel> listBarang = new List<BarangModel>();
        public ActionResult Index()
        {
            return View(listBarang);
        }
        [ActionName("Index")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel(Name = "ActionBtn2", Data = "Add")]
        public ActionResult Add()
        {
            return RedirectToAction("Tambah");
        }
        [ActionName("Index")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel2(Name = "ActionBtn2", Data = "Delete")]
        public ActionResult Delete()
        {
            listBarang.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Tambah()
        {
            return View();
        }
        [ActionName("Tambah")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel2(Name = "TambahAction2", Data = "Simpan")]
        public ActionResult Simpan(BarangModel Barang)
        {
            listBarang.Add(Barang);
            return RedirectToAction("Index");
        }
        [ActionName("Tambah")]
        [AcceptVerbs(HttpVerbs.Post)]
        [AttributeModel(Name = "TambahAction2", Data = "Cancel")]
        public ActionResult Cancel()
        {
            return RedirectToAction("Index");
        }
    }
}