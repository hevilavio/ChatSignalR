using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChatSignalR.DAO;

namespace ChatSignalR.Controllers
{
    public class DdosController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Do()
        {
            try
            {
                long id = new DdosDAO().InserirDados("dado em: " + Getstring());
                return UtilController.ToJson(new { ok = true, id = id });
            }
            catch (Exception e)
            {
                return UtilController.ToJson(new { ok = false, msg = e.Message });
            }
        }

        private string Getstring()
        {
            string s = "";
            for (int i = 0; i < 4000; i++)
            {
                s += "t";
            }
            return s;
        }

    }
}
