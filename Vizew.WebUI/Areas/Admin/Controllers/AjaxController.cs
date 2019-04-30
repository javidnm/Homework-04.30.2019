using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations.Model;
using Vizew.WebUI.Models;
using Vizew.WebUI.Models.Entity;

namespace Vizew.WebUI.Areas.Admin.Controllers
{
    public class AjaxController : Controller
    {


        // GET: Admin/Ajax
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendMessage(int? id, string answer)
        {
            VizewDbContext db = new VizewDbContext();
            Contact contact = db.Contact.FirstOrDefault(p => p.Id == id);
            //if (contact == null)
            //{
            //    return HttpNotFound();
            //}
            contact.IsAnswered = true;
            contact.AnsweredDate = DateTime.Now;
            contact.Answer = answer;
            db.SaveChanges();
            return Json(contact);
        }
    }
}