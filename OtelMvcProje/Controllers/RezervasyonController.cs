using OtelMvcProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelMvcProje.Controllers
{
    public class RezervasyonController : Controller
    {
        // GET: Rezervasyon
        DbOtelYeniEntities db = new DbOtelYeniEntities();

        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblOnRezervasyon t)
        {
            var misafirmail = (string)Session["Mail"];
            // var misafirid = db.TblYeniKayit.Where(x => x.Mail == misafirmail).Select(x => x.ID).FirstOrDefault();

            //p.Durum = 15;
            //p.Misafir = misafirid;
            t.Mail = misafirmail;
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOnRezervasyon.Add(t);
            db.SaveChanges();
            return RedirectToAction("Rezervasyonlarim","Misafir");
        }
    }
}