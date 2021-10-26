using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvcProject.Models.EntityFramework;
using OgrenciNotMvcProject.Models;

namespace OgrenciNotMvcProject.Controllers
{
    public class NotController : Controller
    {
        // GET: Sinav

        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var notlar = db.Tbl_Notlar.ToList();
            return View(notlar);
        }
        [HttpGet]
        public ActionResult YeniSinav()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSınav(Tbl_Notlar tb)
        {
            db.Tbl_Notlar.Add(tb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult NotGetir(int id)
        {
            var not = db.Tbl_Notlar.Find(id);
            return View("NotGetir", not);
        }
        [HttpPost]
        public ActionResult NotGetir(Tbl_Notlar p , int Sınav1,int Sınav2,int Sınav3,int Proje, Class1 model)
        {
            if(model.islem=="HESAPLA")
            {
                //işlem1
                int ortalama = (Sınav1 + Sınav2 + Sınav3 + Proje) / 4;
                
                ViewBag.ort = ortalama;
                if (ortalama>=50)
                {
                    ViewBag.durum = "Geçti";
                }
                else
                {
                    ViewBag.durum = "Kaldı";
                }
            }
            if(model.islem=="NOTGUNCELLE")
            {
                var snv = db.Tbl_Notlar.Find(p.NotID);
                snv.Sınav1 = p.Sınav1;
                snv.Sınav2 = p.Sınav2;
                snv.Sınav3 = p.Sınav3;
                snv.Proje = p.Proje;
                snv.Ortalama = p.Ortalama;
                db.SaveChanges();
                return RedirectToAction("Index", "Not");
                
            }
            
            return View();
        }
    }
}