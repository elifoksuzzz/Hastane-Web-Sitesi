using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UyumsoftHastaneWS.Controllers
{
    public class KurumsalController : Controller
    {
        // GET: Kurumsal
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult PatientRights()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult AboutUs()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult VisitorRights()
        {
            return View();
        }
    }
}