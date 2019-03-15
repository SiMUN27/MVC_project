using MVCProjektRWA.Models.MyModels;
using MVCProjektRWA.Models.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCProjektRWA.Controllers
{
    public class AJAXController : Controller
    {
        public int HTTPstatusCode { get; private set; }
        public ActionResult GetKupci()
        {
            return Json(Repozitorij.GetKupceGrada(2), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetKupac(int id)
        {
            return Json(Repozitorij.GetKupac(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateKupac(Kupac k)
        {
            if (Repozitorij.UpdateKupac(k) > 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotModified);
            }
        }
    }
}