using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UyumsoftHastaneWS.Models;

namespace UyumsoftHastaneWS.Controllers
{
    public class RandevularController : Controller
    {
        // GET: Randevular
        public ActionResult Index()
        {
            Model m = new Model();

            List<Randevular> rlist = m.Randevulars.ToList();
            return View(rlist);
        }
        [HttpGet]
        [Authorize(Roles = "H")]
        public ActionResult RandevuSil(int id)
        {
            Model m = new Model();
            Randevular r = m.Randevulars.FirstOrDefault(x => x.randevu_id == id);
            return View(r);

        }
        [HttpPost]
        [Authorize(Roles = "H")]
        public ActionResult RandevuSil(Randevular r)
        {
            Model m = new Model();

            r = m.Randevulars.FirstOrDefault(x => x.randevu_id == r.randevu_id);

            m.Randevulars.Remove(r);
            m.SaveChanges();

            return RedirectToAction("Index");
        }
        [Authorize(Roles ="H")]
        public ActionResult RandevuEkle()
        {
            Model m = new Model();
            ViewBag.TibbiBolum = m.TibbiBolums.ToList();
            ViewBag.Hekimler = m.Hekimlers.ToList();
            ViewBag.Kullanicilar = m.Kullanicilars.ToList();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "H")]
        public ActionResult RandevuEkle(Randevular r)
        {
            Model m = new Model();
            m.Randevulars.Add(r);
            m.SaveChangesAsync();

            return RedirectToAction("Index","Home");
        }




        //[Authorize(Roles = "H")]
        //public ActionResult Goruntule()
        //{
        //    Model m = new Model();
        //    ViewBag.TibbiBolum = m.TibbiBolums.ToList();
        //    ViewBag.Hekimler = m.Hekimlers.ToList();
        //    ViewBag.Kullanicilar = m.Kullanicilars.ToList();
        //    return View();
        //}

        //[HttpPost]
        [Authorize(Roles = "H")]
        public ActionResult Goruntule()
        {
            Model m = new Model();
            ViewBag.Kullanicilar = m.Kullanicilars.ToList();
            List<Randevular> rlist = m.Randevulars.ToList();
            return View(rlist);

        }

    }
}










