using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UyumsoftHastaneWS.Models;

namespace UyumsoftHastaneWS.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Kullanicilar user)
        {
            Model m = new Model();
            Kullanicilar u = m.Kullanicilars.FirstOrDefault(x => x.kullaniciAdi == user.kullaniciAdi && x.parola == user.parola);
            
            if (u != null)
            {
                FormsAuthentication.SetAuthCookie(u.kullaniciAdi, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı adı veya parola hatalı";
                return View();
            }

        }
        [Authorize(Roles = "A,D,H")]
        public ActionResult LogOut()
            {
                
                FormsAuthentication.SignOut();
                return RedirectToAction("Index", "Home");
            }
        [AllowAnonymous]
        public ActionResult KayitOl()
        {
          
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult KayitOl(Kullanicilar k)
        {
            Model m = new Model();
            m.Kullanicilars.Add(k);
            m.SaveChangesAsync();

            return RedirectToAction("Login");
        }

    }
}