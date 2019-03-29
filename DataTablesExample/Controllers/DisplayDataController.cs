using DataTablesExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTablesExample.Controllers
{
    public class DisplayDataController : Controller
    {
        private dbMRMEntities db = new dbMRMEntities();
        // GET: DisplayData
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }

        public JsonResult GetData()
        {
            List<TechMaster> techMasters = new List<TechMaster>();
            techMasters = db.TechMasters.ToList();
            return Json(techMasters.Select(a => new { a.TechId, a.TechDescription }), JsonRequestBehavior.AllowGet);
        }
    }
}