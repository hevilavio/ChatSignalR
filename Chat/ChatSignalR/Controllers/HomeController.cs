using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatSignalR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Identificacao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConversaChat(string remetente)
        {
            if (String.IsNullOrEmpty(remetente))
            {
                return RedirectToAction("Identificacao", "Home");
            }
            
            ViewBag.Remetente = remetente;
            
            return View();
        }

    }
}
