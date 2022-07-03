using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using UyumsoftHastaneWS.Models;

namespace UyumsoftHastaneWS.Controllers
{
    public class HekimlerController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            Model m = new Model();

            List<Hekimler> hekimlerlist = m.Hekimlers.ToList();
            return View(hekimlerlist);
        }
        [HttpGet]
        [Authorize(Roles ="A")]
        public ActionResult HekimSil(int id)
        {
            Model m = new Model();
            Hekimler hekimler = m.Hekimlers.FirstOrDefault(x => x.hekim_id == id);
            return View(hekimler);

        }
        [HttpPost]
        [Authorize(Roles = "A")]
        public ActionResult HekimSil(Hekimler hekimler)
        {
            Model m = new Model();

            hekimler = m.Hekimlers

                .FirstOrDefault(x => x.hekim_id == hekimler.hekim_id);

            m.Hekimlers.Remove(hekimler);


            m.SaveChanges();

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "A")]
        public ActionResult HekimEkle()
        {
            Model m = new Model();
            ViewBag.TibbiBolum = m.TibbiBolums.ToList();
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "A")]
        public ActionResult HekimEkle(Hekimler hekimler)
        {
            Model m = new Model();
            m.Hekimlers.Add(hekimler);
            m.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        }
    
}
