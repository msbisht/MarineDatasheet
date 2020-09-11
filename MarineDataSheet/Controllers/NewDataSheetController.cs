using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;


namespace MarineDataSheet.Controllers
{
    public class NewDataSheetController : Controller
    {
        // GET: NewDataSheet
        MarinedataEntities dbobje = new MarinedataEntities();
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(NewDataSheetController));
        public ActionResult Index()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult Index(Datum model)
        {
            try
            {
                Datum tblobj = new Datum();
                tblobj.Datasivun_numero = model.Datasivun_numero;
                dbobje.Data.Add(tblobj);
                dbobje.SaveChanges();
            }
            catch (Exception ex)
            {
                log.Info(ex.StackTrace.ToString());
                throw;
            }
           
            return View();
        }
    }
}