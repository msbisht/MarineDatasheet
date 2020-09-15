using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarineDataSheet.Controllers
{
    public class ViewDashboardController : Controller
    {
        MarinedataEntities dbobje = new MarinedataEntities();
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(ViewDashboardController));
        // GET: ViewDashboard
        public ActionResult Dashboard()
        {
           log.Info("Before Paramater called");
            ViewBag.UsersCount = dbobje.Data.Where(x => x.Datasheet_status == "Käytössä").Count();
            ViewBag.ProjectCount = dbobje.Data.Where(x => x.Datasheet_status == "Ei käytössä").Count();
            return View();
        }
    }
}