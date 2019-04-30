using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vizew.WebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
        //    throw new ArgumentException("Problem varsa problem yoxdur!");
            return View();
        }
    }
}