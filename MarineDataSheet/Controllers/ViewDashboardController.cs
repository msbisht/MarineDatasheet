using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarineDataSheet.Controllers
{
    public class ViewDashboardController : Controller
    {
        // GET: ViewDashboard
        public ActionResult Dashboard()
        {
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