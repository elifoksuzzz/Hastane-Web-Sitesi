using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UyumsoftHastaneWS.Models;

namespace UyumsoftHastaneWS.Controllers
{
    public class BolumlerimizController : Controller
    {
        // GET: Bolumlerimiz
        [Authorize(Roles ="A")]
        public ActionResult Index()
        {
            Model m = new Model();

            List<TibbiBolum> tblist = m.TibbiBolums.ToList();
            return View(tblist);
           
        }
        [AllowAnonymous]
        public ActionResult Brain()
        {
            return View();
        }
         [AllowAnonymous]
          public ActionResult CheckUp()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Child()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Dermatology()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Emergency()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Eyes()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult GeneralSurgery()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult InternalMedicine()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Neurology()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Otolaryngology()
        {
            return View();
        }

        [Authorize(Roles = "A")]
        public ActionResult BolumEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "A")]
        public ActionResult BolumEkle(TibbiBolum tb)
        {
            Model m = new Model();
            m.TibbiBolums.Add(tb);
            m.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "A")]
        public ActionResult BolumSil(int id)
        {
            Model m = new Model();
            TibbiBolum tb = m.TibbiBolums.FirstOrDefault(x => x.tibbiBolum_id == id);
            return View(tb);

        }
        [HttpPost]
        [Authorize(Roles = "A")]
        public ActionResult BolumSil(TibbiBolum tb)
        {
            Model m = new Model();

            tb = m.TibbiBolums

                .FirstOrDefault(x => x.tibbiBolum_id == tb.tibbiBolum_id);

            m.TibbiBolums.Remove(tb);


            m.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}