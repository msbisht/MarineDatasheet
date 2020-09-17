using MarineDataSheet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;
using log4net;

namespace MarineDataSheet.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        // MarinedataEntities db = new MarinedataEntities();
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(DataController));
        public ActionResult Index()
        {
            log.Info("---Action method in Data Controller was called--");
            
            return View();
        }

        [HttpPost]
        public ActionResult LoadData()
        {
            //Get parameters
            try
            {
                log.Info("Before Paramater called");
                var draw = Request.Form.GetValues("draw").FirstOrDefault();
                var start = Request.Form.GetValues("start").FirstOrDefault();
                var length = Request.Form.GetValues("length").FirstOrDefault();
                //Get Sort columns value
                var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
                var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int totalRecords = 0;
                log.Info("ActionMethod was Called Before Database");
                using (MarineDataEntities dc = new MarineDataEntities())
                {
                    var dv = (from a in dc.Data where (a.Datasheet_status== "Käytössä") select a );
                    //Sorting
                    if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                    {
                        dv = dv.OrderBy(sortColumn + " " + sortColumnDir);

                    }
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        dv = dv.Where(m => m.Datasivun_numero == searchValue || m.Code == searchValue || m.Model_No == searchValue);
                    }

                    totalRecords = dv.Count();
                    var data = dv.Skip(skip).Take(pageSize).ToList();
                    return Json(new { draw = draw, recordsFiltered = totalRecords, recordsTotal = totalRecords, data = data }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                throw ex;
            }
            // get Start (paging start index) and length (page size for paging)
           
        }
        public ActionResult UserDetails(int ID)
        {
            MarineDataEntities dc = new MarineDataEntities();
            if (ID == null)
            {

            }
            var userDetailsResponse = dc.Data.Where(x => x.Laskuri == ID);
            return PartialView("_UserDetails", userDetailsResponse);
        }


        [HttpPost]
        public ActionResult ViewRevisionData()
        {
            //Get parameters
            try
            {
                log.Info("Before Paramater called");
                var draw = Request.Form.GetValues("draw").FirstOrDefault();
                var start = Request.Form.GetValues("start").FirstOrDefault();
                var length = Request.Form.GetValues("length").FirstOrDefault();
                //Get Sort columns value
                var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
                var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int totalRecords = 0;
                log.Info("ActionMethod was Called Before Database");
                using (MarineDataEntities dc = new MarineDataEntities())
                {
                    var dv = (from a in dc.Data where (a.Datasheet_status == "Ei käytössä") select a);
                    //Sorting
                    if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                    {
                        dv = dv.OrderBy(sortColumn + " " + sortColumnDir);

                    }
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        dv = dv.Where(m => m.Datasivun_numero == searchValue || m.Code == searchValue || m.Model_No == searchValue);
                    }

                    totalRecords = dv.Count();
                    var data = dv.Skip(skip).Take(pageSize).ToList();
                    return Json(new { draw = draw, recordsFiltered = totalRecords, recordsTotal = totalRecords, data = data }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                throw ex;
            }
            // get Start (paging start index) and length (page size for paging)

        }
    }
}