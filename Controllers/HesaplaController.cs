using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvcProject.Controllers
{
    public class HesaplaController : Controller
    {
        // GET: Hesapla
        public ActionResult Index(int sayı1=0 , int sayı2=0)
        {
            int sonuc = sayı1 + sayı2;
            ViewBag.snc = sonuc;
            return View();
        }
    }
}