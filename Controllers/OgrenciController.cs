using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvcProject.Models.EntityFramework;

namespace OgrenciNotMvcProject.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci

        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var ogrenci = db.Tbl_Ogrenci.ToList();
            return View(ogrenci);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler = (from i in db.Tbl_Kulup.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KulupAd,
                                                 Value = i.KulupID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult YeniOgrenci(Tbl_Ogrenci p3)
        {
            var klp = db.Tbl_Kulup.Where(m => m.KulupID == p3.Tbl_Kulup.KulupID).FirstOrDefault();
            p3.Tbl_Kulup = klp;
            db.Tbl_Ogrenci.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public ActionResult Sil(int id)
        {
            var ogrenci = db.Tbl_Ogrenci.Find(id);
            db.Tbl_Ogrenci.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OgrenciGetir(int id)
        {
            var ogrenci = db.Tbl_Ogrenci.Find(id);
            List<SelectListItem> degerler = (from i in db.Tbl_Kulup.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KulupAd,
                                                 Value = i.KulupID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View("OgrenciGetir", ogrenci);
        }
        public ActionResult Guncelle(Tbl_Ogrenci p)
        {
            var ogr = db.Tbl_Ogrenci.Find(p.OgrenciID);
            ogr.OgrAd = p.OgrAd;
            ogr.OgrSoyad = p.OgrSoyad;
            ogr.OgrFoto = p.OgrFoto;
            ogr.OgrCinsiyet = p.OgrCinsiyet;
            ogr.OgrKulup = p.OgrKulup;
            db.SaveChanges();
            return RedirectToAction("Index", "Ogrenci");
        }
    }
}