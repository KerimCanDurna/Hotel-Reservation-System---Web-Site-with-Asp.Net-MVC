using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;
namespace OtelMvcProje.Controllers
{
    public class DefaultController : Controller
    {
        DbOtelYeniEntities db = new DbOtelYeniEntities();

        public ActionResult Hakkimda()
        {
            var veriler = db.TblHakkimda.ToList();
            return View(veriler);
        }

        public PartialViewResult Ekibimiz()
        {
            var ekiplistesi = db.TblEkibimiz.ToList();
            return PartialView(ekiplistesi);
        }
        public PartialViewResult istatistik()
        {
            return PartialView();
        }
        public PartialViewResult Referans()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            
            return PartialView();
        }

        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }

    }
}