using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvcProject.Models.EntityFramework;

namespace OgrenciNotMvcProject.Controllers
{
    public class KulupController : Controller
    {
        // GET: Kulup

        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var kulupler = db.Tbl_Kulup.ToList();
            return View(kulupler);
        }
        [HttpGet]
        public ActionResult YeniKulup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKulup(Tbl_Kulup p2)
        {
            db.Tbl_Kulup.Add(p2);
            db.SaveChanges();
            return View();

        }
        public ActionResult Sil(int id)
        {
            var kulup = db.Tbl_Kulup.Find(id);
            db.Tbl_Kulup.Remove(kulup);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult KulupGetir(int id)
        {
            var kulupg = db.Tbl_Kulup.Find(id);

            return View("KulupGetir",kulupg);
        }
        public ActionResult Guncelle(Tbl_Kulup p)
        {
            var klp = db.Tbl_Kulup.Find(p.KulupID);
            klp.KulupAd = p.KulupAd;
            db.SaveChanges();
            return RedirectToAction("Index", "Kulup");
        }
    }
}