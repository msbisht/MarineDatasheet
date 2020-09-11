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
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(ViewDashboardController));
        // GET: ViewDashboard
        public ActionResult Dashboard()
        {
            log.Info("Before Paramater called");
            //try
            //{
            return View();

            //    var adminCount = _ICacheManager.Get<object>("AdminCount");

            //    if (adminCount == null)
            //    {
            //        var admincount = _IUsers.GetTotalAdminsCount();
            //        _ICacheManager.Add("AdminCount", admincount);
            //        ViewBag.AdminCount = admincount;
            //    }
            //    else
            //    {
            //        ViewBag.AdminCount = adminCount;
            //    }

            //    var usersCount = _ICacheManager.Get<object>("UsersCount");

            //    if (usersCount == null)
            //    {
            //        var userscount = _IUsers.GetTotalUsersCount();
            //        _ICacheManager.Add("UsersCount", userscount);
            //        ViewBag.UsersCount = userscount;
            //    }
            //    else
            //    {
            //        ViewBag.UsersCount = usersCount;
            //    }

            //    var projectCount = _ICacheManager.Get<object>("ProjectCount");

            //    if (projectCount == null)
            //    {
            //        var projectcount = _IProject.GetTotalProjectsCounts();
            //        _ICacheManager.Add("ProjectCount", projectcount);
            //        ViewBag.ProjectCount = projectcount;
            //    }
            //    else
            //    {
            //        ViewBag.ProjectCount = projectCount;
            //    }

            //    return View();
            //}
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
        }
    }
}