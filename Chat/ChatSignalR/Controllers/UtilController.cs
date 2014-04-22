using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ChatSignalR.Controllers
{
    public class UtilController : Controller
    {
        public static ActionResult ToJson(object o)
        {
            ContentResult c = new ContentResult();
            c.Content = new JavaScriptSerializer().Serialize(o);
            return c;
        }

    }
}
