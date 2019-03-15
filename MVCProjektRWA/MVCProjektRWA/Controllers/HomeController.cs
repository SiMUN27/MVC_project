using MVCProjektRWA.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjektRWA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Drzave()
        {
            var model = Repozitorij.GetDrzave();
            return View(model);
        }

        [Authorize]
        public ActionResult Gradovi(int id)
        {
            var model = Repozitorij.GetGradForDrzava(id);
            return View(model);
        }
        [Authorize]
        public ActionResult SviGradovi()
        {
            var model = Repozitorij.GetGradove();
            return View(model);
        }
        //[Authorize]
        public ActionResult Kupci(int id)
        {
            var model = Repozitorij.GetKupceGrada(id);
            return View(model);
        }

        public ActionResult UpdateKupac(int id)
        {
            ViewBag.gradovi = Repozitorij.GetGradove();
            var model = Repozitorij.GetKupac(id);
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.gradovi = Repozitorij.GetGradove();
            return View();
        }

        [Authorize]
        public ActionResult Racuni(int id)
        {
            var model = Repozitorij.GetRacuneKupca(id);
            return View(model);
        }
        [Authorize]
        public ActionResult Stavke(int id)
        {
            var model = Repozitorij.GetStavkeRacuna(id);
            return View(model);
        }

        //edit Authorize(roles)...

        //[ChildActionOnly] //sprijecava dohvat metodi izvana.
        //public ActionResult GetNazivGrada(int id)
        //{
        //    return PartialView("_Grad", Repozitorij.GetGrad(id));
        //}

    }
}