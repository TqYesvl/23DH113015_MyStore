using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23DH113015_MyStore.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult TrangChu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}