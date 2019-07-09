using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Shopping()
        {
            return View();
        }

        public string Message()
        {
            return "MVC 1. ders";
        }
    }
}