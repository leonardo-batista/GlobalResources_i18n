using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_i18n.Controllers
{
    public class AccueilController : Controller
    {

        public ActionResult Accueil()
        {
            return View();
        }

        public ActionResult Idiome(string idiome)
        {
            var idiomeCookie = new HttpCookie("idiome", idiome)
            {
                HttpOnly = true
            };

            Response.AppendCookie(idiomeCookie);

            return RedirectToAction("Accueil", "Accueil");

        }

        public ActionResult AutrePage()
        {
            return View();
        }
    }
}